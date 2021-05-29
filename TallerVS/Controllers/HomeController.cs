using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerVS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        //Ctrl + K+ C = Comentar
        //Ctrl + K+ U = descomentar
        public ActionResult TallerVS()
        {
            ViewBag.Message = "Taller demo de VS";

            return View();

        }
    }
}