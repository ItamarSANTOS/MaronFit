﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MaromFit
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            
            //ROTA QUE PEGA SOMENTE SE COLOCAR DOIS DIGITOS 
            //EXEMPLO: editarPlanos/00/teste
            //routes.MapRoute("minhaPrimeiraRota"
            //    ,"editarPlanos/{planoId}/{name}"
            //    ,new { controller = "Plano", action = "Edit" }
            //    , new { planoid = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
