using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Demo.Web.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Formatters.Clear();
            //config.Formatters.Add(new JsonMediaTypeFormatter());

            MediaTypeHeaderValue mediaTypeHeaderValue = config.Formatters.XmlFormatter.
                SupportedMediaTypes.FirstOrDefault(x => x.MediaType == "application/xml");

            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(mediaTypeHeaderValue);
        }
    }
}
