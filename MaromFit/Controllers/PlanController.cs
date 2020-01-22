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
        ApplicationDbContext _context;
        public PlanController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Plano
        public ActionResult Index()
        {
            List<Plano> planos = _context.Plan.ToList();              

            return View(planos);
          
        }

        [Route("editarPlanos/{planoid:regex(\\d{2}):range(1,10)}/{name}")]
        public ActionResult Edit(int planoid, string name)
        {
            return Content("planoid = " + planoid + " "+ "Nome: " + " "+  name);
        }
    }
}