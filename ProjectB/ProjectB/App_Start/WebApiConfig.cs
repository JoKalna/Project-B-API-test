using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProjectB
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
                //name of where the values sit. so on the local host type api/values (controler) 
                //gives as a list of array for our strings. 
                //localhost:61896/api/values
                //get request is mapped to this.
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
