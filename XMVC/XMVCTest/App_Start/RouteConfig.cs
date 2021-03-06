﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using XMVC;
using XMVC_V2;
namespace XMVCTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add("CommonRoute", new Route("{controller}/{action}", new XMVC_V2.MvcRouteHandler()));          
        }
    }
}