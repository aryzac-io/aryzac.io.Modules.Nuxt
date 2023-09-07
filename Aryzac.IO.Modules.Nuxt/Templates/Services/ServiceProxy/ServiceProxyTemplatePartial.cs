using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aryzac.IO.Modules.Nuxt.Templates.Proxies;
using Aryzac.IO.Modules.Nuxt.Templates.Structs.DTOs.DTO;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.TypeScript.Builder;
using Intent.Modules.Common.TypeScript.Templates;
using Intent.Modules.Metadata.WebApi.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;
using Intent.Utils;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TypeScript.Templates.TypescriptTemplatePartial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Services.ServiceProxy
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    public partial class ServiceProxyTemplate : TypeScriptTemplateBase<Intent.Modelers.Types.ServiceProxies.Api.ServiceProxyModel>, ITypescriptFileBuilderTemplate
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Services.ServiceProxy";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public ServiceProxyTemplate(IOutputTarget outputTarget, Intent.Modelers.Types.ServiceProxies.Api.ServiceProxyModel model) : base(TemplateId, outputTarget, model)
        {
            AddTypeSource(DTOTemplate.TemplateId);

            TypescriptFile = new TypescriptFile(Model.Name.ToPascalCase())
                .AddClass(Model.Name, @class =>
                {
                    @class.Export();

                    foreach (var operation in Model.Operations)
                    {
                        var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)operation.Mapping.Element);
                        if (endpoint is null)
                        {
                            Logging.Log.Warning($"Operation [{operation.Name}] on {ServiceProxyModel.SpecializationType} [{Model.Name}] is not mapped to an Http-exposed service");
                            continue;
                        }
                        AddOperationMethod(@class, operation.Name.ToCamelCase(), endpoint);
                    }
                });
        }

        private void AddOperationMethod(TypescriptClass @class, string name, IHttpEndpointModel endpoint)
        {
            @class.AddMethod(name, GetOperationReturnType(endpoint), method =>
            {
                method.Async();
                method.Public();
                foreach (var input in endpoint.Inputs)
                {
                    method.AddParameter(input.Name.ToCamelCase(), base.GetTypeName(input.TypeReference));
                }

                method.AddStatement($"let url = `/{endpoint.Route.Replace("{", "${")}`;");

                method.AddStatement($"return await {GetOperationFetchType(endpoint)}(url,");

                method.AddStatement($"  {{");
                method.AddStatement($"      method: '{endpoint.Verb.ToString().ToUpper()}',");
                method.AddStatement($"      headers: {{ 'Content-Type': 'application/json' }},");

                if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null)
                {
                    var bodyParam = endpoint.Inputs.First(x => x.Source == HttpInputSource.FromBody);
                    method.AddStatement($"      body: JSON.stringify({bodyParam.Name.ToCamelCase()}),");
                }

                method.AddStatement($"  }}");

                method.AddStatement($");");

                method.AddStatements(GetPreDataServiceCallStatements(endpoint));
            });
        }

        private string GetOperationReturnType(IHttpEndpointModel endpoint)
        {
            if (endpoint.Verb != HttpVerb.Get)
                return $"Promise<{GetReturnType(endpoint)}>";
            else
                return $"Promise";
        }

        private string GetOperationFetchType(IHttpEndpointModel endpoint)
        {
            if (endpoint.Verb != HttpVerb.Get)
                return $"$fetch";
            else
                return $"useLazyFetch";
        }

        public TypescriptFile TypescriptFile { get; }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"use{Model.Name.ToPascalCase()}.proxy",
                fileExtension: "ts"
            );
        }

        public override string TransformText()
        {
            return TypescriptFile.ToString();
        }

        private string GetReturnType(IHttpEndpointModel operation)
        {
            if (operation.ReturnType == null)
            {
                return "boolean";
            }

            return GetTypeName(operation.ReturnType);
        }

        private List<string> GetPreDataServiceCallStatements(IHttpEndpointModel operation)
        {
            var statements = new List<string>();

            var queryParams = operation.Inputs.Where(x => x.Source == HttpInputSource.FromQuery).ToList();
            if (queryParams.Any())
            {
                statements.Add($"let httpParams = new {UseType("HttpParams", "@angular/common/http")}()");
                foreach (var queryParam in queryParams)
                {
                    if (queryParam.TypeReference.Element.Name == "date" || queryParam.TypeReference.Element.Name == "datetime")
                    {
                        statements.Add($@"  .set(""{queryParam.Name.ToCamelCase()}"", {queryParam.Name.ToCamelCase()}.toISOString())");
                        continue;
                    }
                    statements.Add($@"  .set(""{queryParam.Name.ToCamelCase()}"", {queryParam.Name.ToCamelCase()})");
                }
                statements.Add(";");
            }

            var formDataFields = operation.Inputs.Where(x => x.Source == HttpInputSource.FromForm).ToList();
            if (formDataFields.Any())
            {
                statements.Add($"let formData: FormData = new FormData();");
                foreach (var field in formDataFields)
                {
                    statements.Add($@"formData.append(""{field.Name.ToCamelCase()}"", {field.Name.ToCamelCase()}{(!field.TypeReference.HasStringType() ? ".toString()" : "")});");
                }
            }

            var headerFields = operation.Inputs.Where(x => x.Source == HttpInputSource.FromHeader).ToList();
            if (headerFields.Any())
            {
                statements.Add($"let headers = new {UseType("HttpHeaders", "@angular/common/http")}()");
                foreach (var header in headerFields)
                {
                    statements.Add($@"  .append(""{header.HeaderName}"", {header.Name.ToCamelCase()})");
                }
                statements.Add(";");
            }

            if (!statements.Any())
            {
                return new List<string>();
            }

            return statements;
        }

        private string UseType(string type, string location)
        {
            this.AddImport(type, location);
            return type;
        }
    }
}