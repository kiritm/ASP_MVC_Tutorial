using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "MyHome",
               url: "MyHome",
               defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "MyHome1",
               url: "",
               defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "MyHome2",
               url: "MyHome/MyHome",
               defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
