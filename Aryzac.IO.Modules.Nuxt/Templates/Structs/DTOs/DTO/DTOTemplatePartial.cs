using System.Collections.Generic;
using System.Linq;
using Intent.Engine;
using Intent.Modelers.Services.Api;
using Intent.Modules.Common.Templates;
using Intent.Modules.Common.TypeScript.Templates;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Merge)]
[assembly: IntentTemplate("Intent.ModuleBuilder.TypeScript.Templates.TypescriptTemplatePartial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Structs.DTOs.DTO
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class DTOTemplate : TypeScriptTemplateBase<Intent.Modelers.Services.Api.DTOModel>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Structs.DTOs.DTO";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public DTOTemplate(IOutputTarget outputTarget, Intent.Modelers.Services.Api.DTOModel model) : base(TemplateId, outputTarget, model)
        {
            AddTypeSource(TemplateId);
        }

        public string GenericTypes => Model.GenericTypes.Any() ? $"<{string.Join(", ", Model.GenericTypes)}>" : "";

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            return new TypeScriptFileConfig(
                overwriteBehaviour: OverwriteBehaviour.Always,
                fileName: $"{Model.Name.ToKebabCase().RemoveSuffix("-dto")}.dto",
                relativeLocation: $"{Model.InternalElement.ParentElement.Name.ToPascalCase()}",
                className: $"{Model.Name}"
            );
        }

    }
}