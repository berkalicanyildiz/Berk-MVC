using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using System.Web.Mvc;

namespace Berk_MVC
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");




            routes.MapRoute(
                name: "Default",
              url: "{controller}/{action}",
               defaults: new { controller = "Index", action = "Index" },
                namespaces: new string[] { "Berk_MVC.Areas.tr.Controllers" }
            ).DataTokens.Add("Area", "tr");
        }
    }
}
