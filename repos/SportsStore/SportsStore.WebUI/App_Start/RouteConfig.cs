using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SportsStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "", new
            {
                controller = "Product",
                action = "List",
                category = (string) null,
                page = 1
            });

            routes.MapRoute(
                name: "null",
                url: "page{page}",
                defaults: new
                {
                    controller = "Product",
                    action = "List",
                    category = (string) null
                },
            new { page = @"\d+" }); //  Looks for one or more digits The @ just eliminates the need to escape the backslashes to keep the compiler happy

            routes.MapRoute(null, "{category}", new
            {
                controller = "Product",
                action = "List",
                page = 1
            });

            routes.MapRoute(null, "{category}/Page{page}", new
            {
                controller = "Product",
                action = "List"
            },
            new { page = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}");
               /* defaults: new
                { 
                    controller = "Product", 
                    action = "List", 
                    id = UrlParameter.Optional 
                });*/
        }
    }
}
