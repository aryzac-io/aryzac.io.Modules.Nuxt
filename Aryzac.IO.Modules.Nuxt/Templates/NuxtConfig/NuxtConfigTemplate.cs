// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.NuxtConfig
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\NuxtConfig\NuxtConfigTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class NuxtConfigTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
  runtimeConfig: {
    apiBaseUri: '', // Default to an empty string, automatically set at runtime using process.env.NUXT_API_BASE_URI
    public: {
    }
  },
  devtools: { enabled: true },
  extends: [
    // https://nuxt.com/modules/seo-kit
    'nuxt-seo-kit'
  ],
  modules: [
    // https://content.nuxtjs.org/get-started
    '@nuxt/content',
    // https://nuxt.com/modules/image
    '@nuxt/image',
    // https://nuxt.com/modules/icon
    'nuxt-icon',
    // https://nuxt.com/modules/color-mode
    '@nuxtjs/color-mode',
    // https://nuxt.com/modules/i18n
    '@nuxtjs/i18n',
    // https://tailwindcss.nuxtjs.org/getting-started
    '@nuxtjs/tailwindcss'
  ],
  colorMode: {
    classSuffix: ''
  },
  tailwindcss: {
    config: {
      darkMode: 'class',
      plugins: [require('@tailwindcss/forms')],
    }
  },
})
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
