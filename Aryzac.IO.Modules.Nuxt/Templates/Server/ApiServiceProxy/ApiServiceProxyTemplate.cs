// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Aryzac.IO.Modules.Nuxt.Templates.Server.ApiServiceProxy
{
    using System.Collections.Generic;
    using System.Linq;
    using Intent.Modules.Common;
    using Intent.Modules.Common.Templates;
    using Intent.Metadata.Models;
    using Intent.Modelers.Types.ServiceProxies.Api;
    using Intent.Modules.Metadata.WebApi.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ApiServiceProxyTemplate : IntentTemplateBase<Intent.Modelers.Types.ServiceProxies.Api.OperationModel>
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 10 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"

    var endpoint = GetEndpoint();

            
            #line default
            #line hidden
            this.Write("export default defineEventHandler(async (event) => {\r\n    const config = useRunti" +
                    "meConfig();\r\n");
            
            #line 15 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    foreach (var routeParameter in GetEndpointRouteParameters())
    {

            
            #line default
            #line hidden
            this.Write("    const ");
            
            #line 19 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(routeParameter));
            
            #line default
            #line hidden
            this.Write(" = getRouterParam(event, \'");
            
            #line 19 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(routeParameter));
            
            #line default
            #line hidden
            this.Write("\');\r\n");
            
            #line 20 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    } 

    // Include query parameters
    foreach (var queryParameter in GetEndpointQueryParameters())
    {

            
            #line default
            #line hidden
            this.Write("    const ");
            
            #line 27 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(queryParameter));
            
            #line default
            #line hidden
            this.Write(" = getQueryParameter(event, \'");
            
            #line 27 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(queryParameter));
            
            #line default
            #line hidden
            this.Write("\');\r\n");
            
            #line 28 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"

    }

    // Include header parameters
    var headerParameters = GetEndpointHeaderParameters();

            
            #line default
            #line hidden
            this.Write("    const headers = {\r\n        \'Content-Type\': \'application/json\',\r\n");
            
            #line 36 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    foreach (var headerParameter in headerParameters)
    {

            
            #line default
            #line hidden
            this.Write("        \'");
            
            #line 40 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerParameter));
            
            #line default
            #line hidden
            this.Write("\': getHeaderParameter(event, \'");
            
            #line 40 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(headerParameter));
            
            #line default
            #line hidden
            this.Write("\'),\r\n");
            
            #line 41 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    };\r\n\r\n");
            
            #line 46 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null) 
    { 

            
            #line default
            #line hidden
            this.Write("    const body = await readBody(event);\r\n");
            
            #line 51 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    } 

            
            #line default
            #line hidden
            this.Write("    let url = `/");
            
            #line 54 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.Route.Replace("{", "${")));
            
            #line default
            #line hidden
            this.Write("`;\r\n");
            
            #line 55 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"

    if (GetEndpointQueryParameters().Any())
    {
        var queryParams = string.Join("&", GetEndpointQueryParameters().Select(p => $"{p}=${{{p}}}"));

            
            #line default
            #line hidden
            this.Write("    url += `?");
            
            #line 60 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(queryParams));
            
            #line default
            #line hidden
            this.Write("`;\r\n");
            
            #line 61 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    var response = await $fetch(`${config.apiBaseUri}${url}`, {\r\n        method: " +
                    "\'");
            
            #line 65 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(endpoint.Verb.ToString().ToUpper()));
            
            #line default
            #line hidden
            this.Write("\',\r\n        headers,\r\n");
            
            #line 67 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromBody) != null) 
    { 
        var bodyParam = endpoint.Inputs.First(x => x.Source == HttpInputSource.FromBody);

            
            #line default
            #line hidden
            this.Write("        body,\r\n");
            
            #line 73 "D:\src\aryzac-io\aryzac.io.Modules.Nuxt\Aryzac.IO.Modules.Nuxt\Templates\Server\ApiServiceProxy\ApiServiceProxyTemplate.tt"
 
    } 

            
            #line default
            #line hidden
            this.Write("    });\r\n    return response;\r\n});\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}