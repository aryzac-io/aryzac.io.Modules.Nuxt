using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modelers.WebClient.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Registrations;
using Intent.Registrations;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TemplateRegistration.FilePerModel", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Server.ApiServiceProxy
{
    [IntentManaged(Mode.Merge, Body = Mode.Merge, Signature = Mode.Fully)]
    public class ApiServiceProxyTemplateRegistration : FilePerModelTemplateRegistration<OperationModel>
    {
        private readonly IMetadataManager _metadataManager;

        public ApiServiceProxyTemplateRegistration(IMetadataManager metadataManager)
        {
            _metadataManager = metadataManager;
        }

        public override string TemplateId => ApiServiceProxyTemplate.TemplateId;

        [IntentManaged(Mode.Fully)]
        public override ITemplate CreateTemplateInstance(IOutputTarget outputTarget, OperationModel model)
        {
            return new ApiServiceProxyTemplate(outputTarget, model);
        }

        [IntentManaged(Mode.Merge, Body = Mode.Ignore, Signature = Mode.Fully)]
        public override IEnumerable<OperationModel> GetModels(IApplication application)
        {
            return GetOperationModels(_metadataManager.WebClient(application));
        }
        public static IList<OperationModel> GetOperationModels(IDesigner designer)
        {
            return (from x in designer.GetElementsOfType("aee6811e-b2f6-4562-a8eb-502029f63bc8")
                    select new OperationModel(x)).ToList();
        }
    }
}