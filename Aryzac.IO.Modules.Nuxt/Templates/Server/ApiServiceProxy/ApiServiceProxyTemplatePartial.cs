using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Intent.Engine;
using Intent.Metadata.Models;
using Intent.Modelers.Types.ServiceProxies.Api;
using Intent.Modules.Common;
using Intent.Modules.Common.Templates;
using Intent.Modules.Metadata.WebApi.Models;
using Intent.RoslynWeaver.Attributes;
using Intent.Templates;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.ModuleBuilder.ProjectItemTemplate.Partial", Version = "1.0")]

namespace Aryzac.IO.Modules.Nuxt.Templates.Server.ApiServiceProxy
{
    [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
    partial class ApiServiceProxyTemplate : IntentTemplateBase<OperationModel>
    {
        [IntentManaged(Mode.Fully)]
        public const string TemplateId = "Aryzac.IO.Modules.Nuxt.Server.ApiServiceProxy";

        [IntentManaged(Mode.Merge, Signature = Mode.Fully)]
        public ApiServiceProxyTemplate(IOutputTarget outputTarget, OperationModel model) : base(TemplateId, outputTarget, model)
        {
        }

        [IntentManaged(Mode.Fully, Body = Mode.Ignore)]
        public override ITemplateFileConfig GetTemplateFileConfig()
        {
            string route = GetEndpoint().Route;
            string verb = GetEndpoint().Verb.ToString().ToLower();

            route = route.Replace("{", "[").Replace("}", "]");

            (string fileName, string relativeLocation) = ProcessRoute(route, verb);

            // Ensure that the relativeLocation starts with "api/"
            relativeLocation = "api/" + relativeLocation;

            // Create the TemplateFileConfig object
            return new TemplateFileConfig(
                fileName: fileName,
                relativeLocation: relativeLocation,
                fileExtension: "ts"
            );
        }

        private (string fileName, string relativeLocation) ProcessRoute(string route, string verb)
        {
            // Split the route into its segments
            string[] routeSegments = route.Split('/');

            // Remove the "api" segment
            routeSegments = routeSegments.Skip(1).ToArray();

            // The first segment will always be the API version (e.g., "v1")
            string version = routeSegments[0];

            // If we only have the version and base entity
            if (routeSegments.Length == 2)
            {
                return ($"{routeSegments[1]}.{verb}", $"{version}");
            }

            // Build the relative location and file name
            List<string> relativeLocationSegments = new List<string> { version };
            StringBuilder fileNameBuilder = new StringBuilder();

            for (int i = 1; i < routeSegments.Length; i++)
            {
                string segment = routeSegments[i];

                // Check if segment is a parameter
                if (segment.StartsWith("[") && segment.EndsWith("]"))
                {
                    // If it's the last segment, it determines the file name
                    if (i == routeSegments.Length - 1)
                    {
                        fileNameBuilder.Append($"{segment}.{verb}");
                    }
                    else
                    {
                        relativeLocationSegments.Add(segment);
                    }
                }
                // If segment is not a parameter
                else
                {
                    // If it's the last segment and not a parameter, it determines the file name
                    if (i == routeSegments.Length - 1)
                    {
                        fileNameBuilder.Append($"{segment}.{verb}");
                    }
                    else
                    {
                        // Add to the path structure
                        relativeLocationSegments.Add(segment);
                    }
                }
            }

            return (fileNameBuilder.ToString(), string.Join("/", relativeLocationSegments));
        }

        public IHttpEndpointModel GetEndpoint()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            return endpoint;
        }

        public List<string> GetEndpointRouteParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromRoute) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromRoute).Select(m => m.Name).ToList();
            }

            return parameters;
        }

        public List<string> GetEndpointQueryParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromQuery) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromQuery).Select(m => m.Name).ToList();
            }

            return parameters;
        }

        public List<string> GetEndpointHeaderParameters()
        {
            var endpoint = HttpEndpointModelFactory.GetEndpoint((IElement)Model.Mapping.Element);
            if (endpoint is null) { return null; }

            var parameters = new List<string>();

            if (endpoint.Inputs.FirstOrDefault(x => x.Source == HttpInputSource.FromHeader) != null)
            {
                parameters = endpoint.Inputs.Where(m => m.Source == HttpInputSource.FromHeader).Select(m => m.Name).ToList();
            }

            return parameters;
        }
    }
}