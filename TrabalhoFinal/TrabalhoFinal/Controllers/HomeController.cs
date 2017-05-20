using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Paisagens deslumbrantes";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Visite os Lugares ecologicos mais incriveis.";

            return View();
        }
    }
}