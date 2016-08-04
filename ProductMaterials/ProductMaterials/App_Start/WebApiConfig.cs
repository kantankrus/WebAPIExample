﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProductMaterials
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
