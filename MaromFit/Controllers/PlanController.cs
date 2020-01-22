using MaromFit.Models;
using MaromFit.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class PlanController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            var lstPlanos = new List<Plano>()
            {
                new Models.Plano() {Id = 1, Name = "Plano A", Value = 85 },
                new Models.Plano() {Id = 2, Name = "Plano B", Value = 100},
                new Models.Plano() {Id = 3, Name = "Plano C", Value = 130}
            };

            PlanClientViewModel model = new PlanClientViewModel()
            {              
                Planos = lstPlanos
            };

            return View(model);
          
        }

        [Route("editarPlanos/{planoid:regex(\\d{2}):range(1,10)}/{name}")]
        public ActionResult Edit(int planoid, string name)
        {
            return Content("planoid = " + planoid + " "+ "Nome: " + " "+  name);
        }
    }
}