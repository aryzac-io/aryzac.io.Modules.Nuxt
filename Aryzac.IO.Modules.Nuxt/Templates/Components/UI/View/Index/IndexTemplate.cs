// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Components.UI.View.Index
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Components\UI\View\Index\IndexTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class IndexTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("<script setup>\r\n// Props definition\r\nconst props = defineProps({\r\n  loading: {\r\n " +
                    "   type: Boolean,\r\n    default: () => false,\r\n  },\r\n  items: {\r\n    type: Array," +
                    "\r\n    default: () => [],\r\n  },\r\n  config: {\r\n    type: Array,\r\n    default: () =" +
                    "> [],\r\n  },\r\n  actions: {\r\n    type: Array,\r\n    default: () => [],\r\n  },\r\n});\r\n" +
                    "\r\nconst { loading, items, config, actions } = toRefs(props);\r\n\r\n// Use the confi" +
                    "g prop to generate the views\r\nconst views = config.value.map((view) => ({\r\n  slo" +
                    "tName: view.name || \"defaultSlotName\",\r\n  label: view.label || \"defaultLabel\",\r\n" +
                    "  icon: view.icon || \"defaultIconName\",\r\n}));\r\n\r\nconst currentView = ref(views[0" +
                    "].slotName); // default to the first view\r\n\r\nconst tabs = views.map((view) => ({" +
                    "\r\n  name: view.label,\r\n  icon: view.icon,\r\n  current: currentView.value === view" +
                    ".slotName,\r\n  href: \"#\" + view.slotName,\r\n}));\r\n\r\nconst changeView = (tab) => {\r" +
                    "\n  currentView.value = tab.slotName;\r\n};\r\n\r\nconst emit = defineEmits();\r\n\r\nconst" +
                    " load = () => {\r\n  emit(\"load-more\");\r\n};\r\n</script>\r\n\r\n<template>\r\n  <div class" +
                    "=\"flex flex-col\">\r\n    <!-- Use flex-col to stack children vertically -->\r\n\r\n   " +
                    " <!-- Tabs and Actions -->\r\n    <div\r\n      class=\"w-full flex items-center just" +
                    "ify-between p-2 border-b border-gray-200\"\r\n    >\r\n      <!-- Flex container to l" +
                    "ayout tabs and action buttons -->\r\n\r\n      <!-- Tabs component -->\r\n      <div c" +
                    "lass=\"flex-grow\">\r\n        <div class=\"sm:hidden\">\r\n          <label for=\"tabs\" " +
                    "class=\"sr-only\">Select a tab</label>\r\n          <select\r\n            id=\"tabs\"\r\n" +
                    "            name=\"tabs\"\r\n            class=\"block w-full rounded-md border-gray-" +
                    "300 focus:border-indigo-500 focus:ring-indigo-500\"\r\n          >\r\n            <op" +
                    "tion v-for=\"tab in tabs\" :key=\"tab.name\" :selected=\"tab.current\">\r\n             " +
                    " {{ tab.name }}\r\n            </option>\r\n          </select>\r\n        </div>\r\n   " +
                    "     <div class=\"hidden sm:block\">\r\n          <nav class=\"-mb-px flex space-x-8\"" +
                    " aria-label=\"Tabs\">\r\n            <a\r\n              v-for=\"tab in tabs\"\r\n        " +
                    "      :key=\"tab.name\"\r\n              :href=\"tab.href\"\r\n              @click.prev" +
                    "ent=\"changeView(tab)\"\r\n              :class=\"[\r\n                tab.current\r\n   " +
                    "               ? \'border-indigo-500 text-indigo-600\'\r\n                  : \'borde" +
                    "r-transparent text-gray-500 hover:border-gray-300 hover:text-gray-700\',\r\n       " +
                    "         \'group inline-flex items-center border-b-2 py-2 px-4 text-sm font-mediu" +
                    "m\',\r\n              ]\"\r\n              :aria-current=\"tab.current ? \'page\' : undef" +
                    "ined\"\r\n            >\r\n              <icon\r\n                :name=\"tab.icon\"\r\n   " +
                    "             :class=\"[\r\n                  tab.current\r\n                    ? \'te" +
                    "xt-indigo-500\'\r\n                    : \'text-gray-400 group-hover:text-gray-500\'," +
                    "\r\n                  \'-ml-0.5 mr-2 h-5 w-5\',\r\n                ]\"\r\n               " +
                    " aria-hidden=\"true\"\r\n              />\r\n              <span>{{ tab.name }}</span>" +
                    "\r\n            </a>\r\n          </nav>\r\n        </div>\r\n      </div>\r\n\r\n      <!--" +
                    " Actions for quick tasks -->\r\n      <div class=\"space-x-4\">\r\n        <button\r\n  " +
                    "        type=\"button\"\r\n          v-for=\"action in actions\"\r\n          :key=\"acti" +
                    "on.label\"\r\n          @click=\"action.function\"\r\n          class=\"inline-flex item" +
                    "s-center gap-x-1.5 rounded-md bg-indigo-600 px-2.5 py-1.5 text-sm font-semibold " +
                    "text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:out" +
                    "line-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600\"\r\n       " +
                    " >\r\n          <icon\r\n            :name=\"action.icon\"\r\n            class=\"-ml-0.5" +
                    " h-5 w-5\"\r\n            aria-hidden=\"true\"\r\n          />\r\n          {{ action.lab" +
                    "el }}\r\n        </button>\r\n      </div>\r\n    </div>\r\n\r\n    <!-- Content area for " +
                    "the views -->\r\n    <div class=\"flex-grow p-4 w-full\">\r\n      <!-- Ensure the con" +
                    "tent container takes the full width -->\r\n      <div v-for=\"view in views\" :key=\"" +
                    "view.slotName\">\r\n        <!-- Content slots -->\r\n        <slot\r\n          v-if=\"" +
                    "currentView === view.slotName\"\r\n          :name=\"view.slotName\"\r\n          :item" +
                    "s=\"items\"\r\n        ></slot>\r\n\r\n        <!-- Loading progress -->\r\n        <div v" +
                    "-if=\"loading && currentView === view.slotName\">\r\n          <slot :name=\"`${view." +
                    "slotName}-loader`\">\r\n            <div class=\"w-full h-1 bg-blue-200\">\r\n         " +
                    "     <div class=\"h-1 bg-blue-500 animate-pulse\"></div>\r\n            </div>\r\n    " +
                    "      </slot>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</template>\r\n" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
