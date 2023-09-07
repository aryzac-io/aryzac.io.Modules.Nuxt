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

namespace Aryzac.IO.Modules.Nuxt.Templates.Composables.UseDefaultNavigation
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class UseDefaultNavigationTemplate : IntentTemplateBase<object>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Composables.useDefaultNavigation";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public UseDefaultNavigationTemplate(IOutputTarget outputTarget, object model = null) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TemplateFileConfig(
                overwriteBehaviour: OverwriteBehaviour.OverwriteDisabled,
                fileName: $"useDefaultNavigation",
                fileExtension: "ts"
            );
        }
    }
}