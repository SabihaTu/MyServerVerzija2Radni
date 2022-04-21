using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyServer
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
                routeTemplate: "api/{controller}/{id}/{login}/{password}/{tura}/{lokacijaID}/{tip}/{napomena}/{longg}/{lat}",
                defaults: new { id = RouteParameter.Optional, login = RouteParameter.Optional,
                    password = RouteParameter.Optional, tura = RouteParameter.Optional,
                    lokacijaID = RouteParameter.Optional, tip = RouteParameter.Optional,
                    napomena = RouteParameter.Optional,
                    longg = RouteParameter.Optional,
                    lat = RouteParameter.Optional
                }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(
                new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
