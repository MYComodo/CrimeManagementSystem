using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WA.CRM.db;
using WA.CRM.Models;

namespace WA.CRM.Controllers
{
    public class HomeController : Controller
    {
        MVCTestEntities entities = new MVCTestEntities();
        public ActionResult Index()
        {



            return View(entities.MainAdmin);
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