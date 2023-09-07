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

namespace Aryzac.IO.Modules.Nuxt.Templates.Components.DeleteComponent
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class DeleteComponentTemplateRegistration : FilePerModelTemplateRegistration<OperationModel>
    {
        private readonly IMetadataManager _metadataManager;

        public DeleteComponentTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => DeleteComponentTemplate.TemplateId;

        [IntentManaged(Mode.Fully)]
        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, OperationModel model)
        {
            return new DeleteComponentTemplate(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<OperationModel> GetModels(IApplication application)
        {
            var validVerbs = new List<HttpVerb> { HttpVerb.Delete };
            return GetOperationModels(_metadataManager.WebClient(application)).Where(m => validVerbs.Contains(HttpEndpointModelFactory.GetEndpoint((IElement)m.Mapping.Element).Verb));
        }

        public static IList<OperationModel> GetOperationModels(IDesigner designer)
        {
            return (from x in designer.GetElementsOfType("aee6811e-b2f6-4562-a8eb-502029f63bc8")
                    select new OperationModel(x)).ToList();
        }
    }
}