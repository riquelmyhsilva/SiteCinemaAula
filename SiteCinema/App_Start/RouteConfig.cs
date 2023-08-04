using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SiteCinema
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "movieBarbie",
                url: "Home/movieBarbie/{id}",
                defaults: new { controller = "Home", action = "movieBarbie", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "movieBezouroAzul",
                url: "Home/movieBarbie/{id}",
                defaults: new { controller = "Home", action = "movieBezouroAzul", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "filmeIndisponivel",
                url: "Home/filmeIndisponivel/{id}",
                defaults: new { controller = "Home", action = "filmeIndisponivel", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }  
    }
}
