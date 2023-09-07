using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.TypeScript.TypeResolvers;
using Intent.Modules.Metadata.WebApi.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Components.PostComponent
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class PostComponentTemplate : IntentTemplateBase<OperationModel>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Components.PostComponent";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public PostComponentTemplate(IOutputTarget outputTarget, OperationModel model) : base(TemplateId, outputTarget, model)
        {
            Types = new TypeScriptTypeResolver();
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                overwriteBehaviour: OverwriteBehaviour.OverwriteDisabled,
                fileName: $"index",
                relativeLocation: $"{GetServicePath()}/{Model.Name.ToKebabCase()}",
                fileExtension: "vue"
            );
        }

        public string GetServicePath()
        {
            var endpoint = GetEndpoint();

            return ((IElement)endpoint.InternalElement).ParentElement.Name.ToKebabCase();
        }

        public IHttpEndpointModel GetEndpoint()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            return endpoint;
        }

        public List<string> GetEndpointRouteParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromRoute) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromRoute).Select(m => m.Name).ToList();
            }

            return parameters;
        }

        public List<string> GetEndpointQueryParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromQuery) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromQuery).Select(m => m.Name).ToList();
            }

            return parameters;
        }

        public List<string> GetEndpointHeaderParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromHeader) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromHeader).Select(m => m.Name).ToList();
            }

            return parameters;
        }

        public string GetBodyClassName()
        {
            var endpoint = GetEndpoint();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null)
            {
                var bodyParam = endpoint.Inputs.First(x => x.Source == HttpInputSource.FromBody);

                return bodyParam.TypeReference.Element.Name;
            }

            return string.Empty;
        }

        public string GetServiceName()
        {
            var endpoint = GetEndpoint();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null)
            {
                var bodyParam = endpoint.Inputs.First(x => x.Source == HttpInputSource.FromBody);

                return ((IElement)bodyParam.TypeReference.Element).ParentElement.Name.ToPascalCase();
            }

            return string.Empty;
        }

        public string GetComposableServiceName()
        {
            return Model.ParentService.Name;
        }

        public string GetServiceProxyMethodName()
        {
            return Model.Name.ToCamelCase();
        }

        public string GetServiceProxyMethodNameForTitle()
        {
            return Model.Name.ToSentenceCase();
        }

        public string GetServiceProxyMethodCommentForDescription()
        {
            if (!string.IsNullOrWhiteSpace(Model.Comment))
            {
                return Model.Comment;
            }

            if (!string.IsNullOrWhiteSpace(Model.Mapping.Element.Comment))
            {
                return Model.Mapping.Element.Comment;
            }

            return null;
        }

        public string GetInputName(IHttpEndpointInputModel input)
        {
            return input.Name.ToCamelCase();
        }

        public ITypeReference GetInputType(IHttpEndpointInputModel input)
        {
            return input.TypeReference;
        }

        public string GetInputsWithTypes()
        {
            var endpoint = GetEndpoint();

            return endpoint.Inputs.Select(m => $"{m.Name.ToCamelCase()}: {GetTypeName(GetInputType(m))}").Aggregate((a, b) => $"{a}, {b}");
        }

        public string GetInputs()
        {
            var endpoint = GetEndpoint();

            return endpoint.Inputs.Select(m => $"{m.Name.ToCamelCase()}").Aggregate((a, b) => $"{a}, {b}");
        }

        public string GetDTOModelName()
        {
            var endpoint = GetEndpoint();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null)
            {
                var bodyParam = endpoint.Inputs.First(x => x.Source == HttpInputSource.FromBody);

                return bodyParam.TypeReference.Element.Name.ToKebabCase();
            }

            return string.Empty;
        }

        public IEnumerable<IElement> GetDTOModelFields()
        {
            var routeParameters = GetEndpointRouteParameters();

            return ((IElement)Model.Mapping.Element).ChildElements.Where(m => !routeParameters.Contains(m.Name.ToCamelCase()));
        }
    }
}