using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class ClientController : Controller
    {
        ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Client> clients = _context.Clients.ToList();
            return View(clients);
        }
    }
}