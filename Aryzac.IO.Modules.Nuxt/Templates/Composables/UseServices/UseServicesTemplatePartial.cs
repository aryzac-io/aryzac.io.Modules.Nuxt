using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Composables.UseServices
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class UseServicesTemplate : IntentTemplateBase<ServiceProxyModel>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Composables.useServices";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public UseServicesTemplate(IOutputTarget outputTarget, ServiceProxyModel model) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                fileName: $"use{Model.Name.ToPascalCase()}Proxy",
                fileExtension: "ts"
            );
        }
    }
}