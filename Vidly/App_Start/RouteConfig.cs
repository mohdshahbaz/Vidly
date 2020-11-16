﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // custom routes.
            //routes.MapRoute(
            //  "MoviesByReleaseDate",
            //"movies/released/{year}/{month}",
            //new { Controller = "Movies", action = "ByReleaseDate" },
            // constraint.
            //new { year = @"2015|2017", month = @"\d{2}" });

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
