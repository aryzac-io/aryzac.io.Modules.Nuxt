using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modelers.WebClient.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.Modules.Metadata.WebApi.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Components.GetMany.IndexComponent
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class IndexComponentTemplateRegistration : FilePerModelTemplateRegistration<OperationModel>
    {
        private readonly IMetadataManager _metadataManager;

        public IndexComponentTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => IndexComponentTemplate.TemplateId;

        [IntentManaged(Mode.Fully)]
        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, OperationModel model)
        {
            return new IndexComponentTemplate(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<OperationModel> GetModels(IApplication application)
        {
            var validVerbs = new List<HttpVerb> { HttpVerb.Get };
            return GetOperationModels(_metadataManager.WebClient(application))
                .Where(m => validVerbs.Contains(HttpEndpointModelFactory.GetEndpoint((IElement)m.Mapping.Element).Verb) &&
                    HttpEndpointModelFactory.GetEndpoint((IElement)m.Mapping.Element).ReturnType.IsCollection);
        }

        public static IList<OperationModel> GetOperationModels(IDesigner designer)
        {
            return (from x in designer.GetElementsOfType("aee6811e-b2f6-4562-a8eb-502029f63bc8")
                    select new OperationModel(x)).ToList();
        }
    }
}