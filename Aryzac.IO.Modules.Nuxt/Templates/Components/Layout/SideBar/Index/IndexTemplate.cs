// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Components.Layout.SideBar.Index
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
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Components\Layout\SideBar\Index\IndexTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class IndexTemplate : IntentTemplateBase<object>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n<script setup lang=\"ts\">\r\nimport {\r\n    Dialog,\r\n    DialogPanel,\r\n    Transiti" +
                    "onChild,\r\n    TransitionRoot,\r\n} from \"@headlessui/vue\";\r\n\r\nconst { sections } =" +
                    " useNavigation();\r\nconst { sidebarOpen, closeSidebar } = useSidebar();\r\n</script" +
                    ">\r\n\r\n<template>\r\n    <TransitionRoot as=\"template\"\r\n                    :show=\"s" +
                    "idebarOpen\">\r\n        <Dialog as=\"div\"\r\n                class=\"relative z-50 lg:" +
                    "hidden\"\r\n                @close=\"closeSidebar\">\r\n            <TransitionChild as" +
                    "=\"template\"\r\n                             enter=\"transition-opacity ease-linear " +
                    "duration-300\"\r\n                             enter-from=\"opacity-0\"\r\n            " +
                    "                 enter-to=\"opacity-100\"\r\n                             leave=\"tra" +
                    "nsition-opacity ease-linear duration-300\"\r\n                             leave-fr" +
                    "om=\"opacity-100\"\r\n                             leave-to=\"opacity-0\">\r\n          " +
                    "      <div class=\"fixed inset-0 bg-gray-900/80\" />\r\n            </TransitionChil" +
                    "d>\r\n\r\n            <div class=\"fixed inset-0 flex\">\r\n                <TransitionC" +
                    "hild as=\"template\"\r\n                                 enter=\"transition ease-in-o" +
                    "ut duration-300 transform\"\r\n                                 enter-from=\"-transl" +
                    "ate-x-full\"\r\n                                 enter-to=\"translate-x-0\"\r\n        " +
                    "                         leave=\"transition ease-in-out duration-300 transform\"\r\n" +
                    "                                 leave-from=\"translate-x-0\"\r\n                   " +
                    "              leave-to=\"-translate-x-full\">\r\n                    <DialogPanel cl" +
                    "ass=\"relative flex flex-1 w-full max-w-xs mr-16\">\r\n                        <Tran" +
                    "sitionChild as=\"template\"\r\n                                         enter=\"ease-" +
                    "in-out duration-300\"\r\n                                         enter-from=\"opaci" +
                    "ty-0\"\r\n                                         enter-to=\"opacity-100\"\r\n        " +
                    "                                 leave=\"ease-in-out duration-300\"\r\n             " +
                    "                            leave-from=\"opacity-100\"\r\n                          " +
                    "               leave-to=\"opacity-0\">\r\n                            <div\r\n        " +
                    "                         class=\"absolute top-0 flex justify-center w-16 pt-5 lef" +
                    "t-full\">\r\n                                <button type=\"button\"\r\n               " +
                    "                         class=\"-m-2.5 p-2.5\"\r\n                                 " +
                    "       @click=\"closeSidebar\">\r\n                                    <span class=\"" +
                    "sr-only\">Close sidebar</span>\r\n                                    <Icon name=\"h" +
                    "eroicons:x-mark\"\r\n                                          class=\"w-6 h-6 text-" +
                    "white\"\r\n                                          aria-hidden=\"true\" />\r\n       " +
                    "                         </button>\r\n                            </div>\r\n        " +
                    "                </TransitionChild>\r\n                        <!-- Sidebar compone" +
                    "nt, swap this element with another sidebar if you like -->\r\n                    " +
                    "    <div\r\n                             class=\"flex flex-col px-6 pb-4 overflow-y" +
                    "-auto bg-white grow gap-y-5\">\r\n                            <div class=\"flex item" +
                    "s-center h-16 shrink-0\">\r\n                                <img class=\"w-auto h-8" +
                    "\"\r\n                                     src=\"https://tailwindui.com/img/logos/ma" +
                    "rk.svg?color=indigo&shade=600\"\r\n                                     alt=\"Your C" +
                    "ompany\" />\r\n                            </div>\r\n                            <nav" +
                    " class=\"flex flex-col flex-1\">\r\n                                <ul role=\"list\"\r" +
                    "\n                                    class=\"flex flex-col flex-1 gap-y-7\">\r\n    " +
                    "                                <layout-sidebar-section :sections=\"sections\" />\r" +
                    "\n\r\n                                    <li class=\"mt-auto\">\r\n                   " +
                    "                     <a href=\"#\"\r\n                                           cla" +
                    "ss=\"flex p-2 -mx-2 text-sm font-semibold leading-6 text-gray-700 rounded-md grou" +
                    "p gap-x-3 hover:bg-gray-50 hover:text-indigo-600\">\r\n                            " +
                    "                <Icon name=\"heroicons:cog-6-tooth\"\r\n                            " +
                    "                      class=\"w-6 h-6 text-gray-400 shrink-0 group-hover:text-ind" +
                    "igo-600\"\r\n                                                  aria-hidden=\"true\" /" +
                    ">\r\n                                            Settings\r\n                       " +
                    "                 </a>\r\n                                    </li>\r\n              " +
                    "                  </ul>\r\n                            </nav>\r\n                   " +
                    "     </div>\r\n                    </DialogPanel>\r\n                </TransitionChi" +
                    "ld>\r\n            </div>\r\n        </Dialog>\r\n    </TransitionRoot>\r\n\r\n    <!-- St" +
                    "atic sidebar for desktop -->\r\n    <div class=\"hidden lg:fixed lg:inset-y-0 lg:z-" +
                    "50 lg:flex lg:w-72 lg:flex-col\">\r\n        <!-- Sidebar component, swap this elem" +
                    "ent with another sidebar if you like -->\r\n        <div\r\n             class=\"flex" +
                    " flex-col px-6 pb-4 overflow-y-auto bg-white border-r border-gray-200 grow gap-y" +
                    "-5\">\r\n            <div class=\"flex items-center h-16 shrink-0\">\r\n               " +
                    " <img class=\"w-auto h-8\"\r\n                     src=\"https://tailwindui.com/img/l" +
                    "ogos/mark.svg?color=indigo&shade=600\"\r\n                     alt=\"Your Company\" /" +
                    ">\r\n            </div>\r\n            <nav class=\"flex flex-col flex-1\">\r\n         " +
                    "       <ul role=\"list\"\r\n                    class=\"flex flex-col flex-1 gap-y-7\"" +
                    ">\r\n                    <layout-sidebar-section :sections=\"sections\" />\r\n\r\n      " +
                    "              <li class=\"mt-auto\">\r\n                        <a href=\"#\"\r\n       " +
                    "                    class=\"flex p-2 -mx-2 text-sm font-semibold leading-6 text-g" +
                    "ray-700 rounded-md group gap-x-3 hover:bg-gray-50 hover:text-indigo-600\">\r\n     " +
                    "                       <Icon name=\"heroicons:cog-6-tooth\"\r\n                     " +
                    "             class=\"w-6 h-6 text-gray-400 shrink-0 group-hover:text-indigo-600\"\r" +
                    "\n                                  aria-hidden=\"true\" />\r\n                      " +
                    "      Settings\r\n                        </a>\r\n                    </li>\r\n       " +
                    "         </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</template>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}