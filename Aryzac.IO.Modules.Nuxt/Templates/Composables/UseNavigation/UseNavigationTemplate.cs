// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Composables.UseNavigation
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Composables\UseNavigation\UseNavigationTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class UseNavigationTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
import { Section } from 'structs/navigation'

export const useNavigation = () => {
  const sections = useState<Section[]>('navigation', () => []);

  const addSection = (
    section: Section
  ) => {
    if (!section.id) { section.id = sections.value.length + 1; }

    sections.value.push(section);
  };

  const removeSection = (id: string|number) => {
    const index = sections.value.findIndex((section) => section.id === id);
    sections.value.splice(index, 1);
  }

  const clearAllSections = () => {
    sections.value = [];
  };

  return { sections, addSection, removeSection, clearAllSections };
};
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
