// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Components.UI.Editor.Section
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Components\UI\Editor\Section\SectionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class SectionTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"<script setup>
const props = defineProps({
  title: String,
  description: String,
});
</script>

<template>
  <div class=""pt-10 grid grid-cols-1 gap-x-8 gap-y-8 md:grid-cols-3"">
    <div class=""px-4 sm:px-0"">
      <h2 class=""text-base font-semibold leading-7 text-gray-900"">
        {{ title }}
      </h2>
      <p class=""mt-1 text-sm leading-6 text-gray-600"">
        {{ description }}
      </p>
    </div>

    <div
         class=""bg-white shadow-sm ring-1 ring-gray-900/5 sm:rounded-xl md:col-span-2"">
      <div class=""px-4 py-6 sm:p-8"">
        <div class=""gap-x-6 gap-y-8"">
          <div class=""space-y-10"">
            <slot />
          </div>
        </div>
      </div>
      <div class=""flex items-center justify-end gap-x-6 border-t border-gray-900/10 px-4 py-4 sm:px-8""
           v-if=""$slots.actions"">
        <slot name=""actions"" />
      </div>
    </div>
  </div>
</template>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}