﻿using MaromFit.Models;
using MaromFit.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // metodo Index 
        {
            //criando um obijeto do tipo model do usuario que acabei de criar no model
            // Obijeto do tipo usuario
            Client usuario = new Client()
            {
                Id = 1,
                Name = "Thiago"
            };

            var lstPlanos = new List<Plano>()
            {
                new Models.Plano() {Id = 1, Name = "Plano 1", Value = 100 },
                new Models.Plano() {Id = 2, Name = "Plano 2", Value = 200},
               
            };

            PlanClientViewModel model = new PlanClientViewModel()
            {
                Usuario = usuario,
                Planos = lstPlanos
            }; 

            return View(model);
             
                       
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}