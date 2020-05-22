using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptrinhwebAT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index";
            return View();
        }
        public ActionResult Nguyen()
        {
            ViewBag.Message = "Nguyen";
            return View();
        }

        public ActionResult Tran()
        {
            ViewBag.Message = "Tran";

            return View();
        }

        public ActionResult Anh()
        {
            ViewBag.Message = "Anh";

            return View();
        }

        public ActionResult Tu()
        {
            ViewBag.Message = "Tu";

            return View();
        }


    }
}