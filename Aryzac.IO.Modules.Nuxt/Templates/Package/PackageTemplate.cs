// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Package
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Package\PackageTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class PackageTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
{
  ""name"": ""nuxt-app"",
  ""private"": true,
  ""scripts"": {
    ""build"": ""nuxt build"",
    ""dev"": ""nuxt dev"",
    ""generate"": ""nuxt generate"",
    ""preview"": ""nuxt preview"",
    ""postinstall"": ""nuxt prepare""
  },
  ""devDependencies"": {
    ""@nuxt/content"": ""^2.7.1"",
    ""@nuxt/devtools"": ""latest"",
    ""@nuxt/image"": ""^1.0.0-rc.1"",
    ""@nuxtjs/color-mode"": ""^3.3.0"",
    ""@nuxtjs/i18n"": ""^8.0.0-beta.13"",
    ""@nuxtjs/tailwindcss"": ""^6.8.0"",
    ""@tailwindcss/forms"": ""^0.5.4"",
    ""@types/node"": ""^18.17.0"",
    ""eslint"": ""^8.48.0"",
    ""eslint-config-prettier"": ""^9.0.0"",
    ""eslint-plugin-prettier"": ""^5.0.0"",
    ""nuxt"": ""^3.6.5"",
    ""nuxt-icon"": ""^0.4.2"",
    ""nuxt-seo-kit"": ""^1.3.9"",
    ""prettier"": ""^3.0.2""
  },
  ""dependencies"": {
    ""@headlessui/vue"": ""^1.7.14""
  }
}

");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
