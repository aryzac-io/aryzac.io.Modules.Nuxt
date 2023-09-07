using System.Collections.Generic;
using Aryzac.IO.Modules.Nuxt.Templates.Services.ServiceProxy;
using Aryzac.IO.Modules.Nuxt.Templates.Structs.DTOs.DTO;
using Aryzac.IO.Modules.Nuxt.Templates.Structs.DTOs.JsonResponse;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: DefaultIntentManaged(Mode.Fully, Targets = Targets.Usings)]
[assembly: IntentTemplate("Intent.ModuleBuilder.Templates.TemplateExtensions", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates
{
    public static class TemplateExtensions
    {
        public static string GetServiceProxyName<T>(this IIntentTemplate<T> template) where T : Intent.Modelers.Types.ServiceProxies.Api.ServiceProxyModel
        {
            return template.GetTypeName(ServiceProxyTemplate.TemplateId, template.Model);
        }

        public static string GetServiceProxyName(this IIntentTemplate template, Intent.Modelers.Types.ServiceProxies.Api.ServiceProxyModel model)
        {
            return template.GetTypeName(ServiceProxyTemplate.TemplateId, model);
        }
        public static string GetDTOName<T>(this IIntentTemplate<T> template) where T : Intent.Modelers.Services.Api.DTOModel
        {
            return template.GetTypeName(DTOTemplate.TemplateId, template.Model);
        }

        public static string GetDTOName(this IIntentTemplate template, Intent.Modelers.Services.Api.DTOModel model)
        {
            return template.GetTypeName(DTOTemplate.TemplateId, model);
        }

        public static string GetJsonResponseName(this IIntentTemplate template)
        {
            return template.GetTypeName(JsonResponseTemplate.TemplateId);
        }

    }
}