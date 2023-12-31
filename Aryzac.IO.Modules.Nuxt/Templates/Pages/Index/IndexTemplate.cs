// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Pages.Index
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Pages\Index\IndexTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class IndexTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
<script setup lang=""ts"">
const debug = useDebug();
useDefaultNavigation();
</script>

<template>
  <div class=""relative z-0 flex flex-1 h-full overflow-hidden"">
    <main
          class=""relative z-0 flex-1 overflow-y-auto focus:outline-none xl:order-last"">
      <!-- Start main area-->
      <div class=""inset-0 h-full px-4 py-6 sm:px-6 lg:px-8"">
        <div class=""h-full rounded-lg""
             :class=""{ 'border-2 border-dashed border-gray-200': debug }"" />
      </div>
      <!-- End main area -->
    </main>
  </div>
</template>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
