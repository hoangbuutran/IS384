﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SHOPBONGDA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Cart",
                url: "Cart/{action}/{id}",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "SHOPBONGDA.Controllers" }
            );

            routes.MapRoute(
                name: "TaiKhoan",
                url: "TaiKhoan/{action}/{id}",
                defaults: new { controller = "TaiKhoan", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "SHOPBONGDA.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TrangChu", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "SHOPBONGDA.Controllers" }
            );
        }
    }
}
