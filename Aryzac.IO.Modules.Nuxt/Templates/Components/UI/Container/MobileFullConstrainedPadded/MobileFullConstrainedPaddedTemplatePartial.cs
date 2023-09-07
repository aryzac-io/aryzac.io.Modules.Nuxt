using System;
using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Components.UI.Container.MobileFullConstrainedPadded
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class MobileFullConstrainedPaddedTemplate : IntentTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Components.UI.Container.MobileFullConstrainedPadded";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public MobileFullConstrainedPaddedTemplate(IOutputTarget outputTarget, object model = null) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                fileName: $"mobile-full-constrained-padded",
                fileExtension: "vue"
            );
        }
    }
}