using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment___2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Register", id = UrlParameter.Optional }
            );

            // Route for the search action
            routes.MapRoute(
                name: "Search",
                url: "{controller}/Index/{selectedDept}", // Adjust the URL pattern as needed
                defaults: new { controller = "Student", action = "Index", selectedDept = UrlParameter.Optional }
            );
        }
    }
}
