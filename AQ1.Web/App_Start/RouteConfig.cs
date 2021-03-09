﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AQ1.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "dang-nhap.html",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "AQ1.Web.Controllers" }
                );
            routes.MapRoute(
               name: "Register",
               url: "dang-ky.html",
               defaults: new { controller = "Account", action = "Register", id = UrlParameter.Optional },
               namespaces: new string[] { "AQ1.Web.Controllers" }
               );

            routes.MapRoute(
               name: "About",
               url: "gioi-thieu.html",
               defaults: new { controller = "About", action = "Index", id = UrlParameter.Optional },
               namespaces: new string[] { "AQ1.Web.Controllers" }
               );

            routes.MapRoute(
               name: "Product Category",
               url: "{alias}.pc-{productCategoryId}.html",
               defaults: new { controller = "Product", action = "Category", productCategoryId = UrlParameter.Optional },
               namespaces: new string[] { "AQ1.Web.Controllers" }
               );

            routes.MapRoute(
                name: "Product",
                url: "{alias}.p-{productId}.html",
                defaults: new { Controller = "Product", action = "Detail", productId = UrlParameter.Optional },
                namespaces: new string[] { "AQ1.Web.Controllers" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "AQ1.Web.Controllers" }
                );
        }
    }
}
