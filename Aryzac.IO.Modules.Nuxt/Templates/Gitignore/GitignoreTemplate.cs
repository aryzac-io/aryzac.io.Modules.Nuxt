// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Gitignore
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Gitignore\GitignoreTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class GitignoreTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n# Nuxt dev/build outputs\r\n.output\r\n.nuxt\r\n.nitro\r\n.cache\r\ndist\r\n\r\n# Node depend" +
                    "encies\r\nnode_modules\r\n\r\n# Logs\r\nlogs\r\n*.log\r\n\r\n# Misc\r\n.DS_Store\r\n.fleet\r\n.idea\r" +
                    "\n\r\n# Local env files\r\n.env\r\n.env.*\r\n!.env.example\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
