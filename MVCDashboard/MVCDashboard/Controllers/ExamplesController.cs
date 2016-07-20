using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class ExamplesController : Controller
    {
        // GET: Examples
        public ActionResult NoFound()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }

        public ActionResult FacturaPrint()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult Invoice1()
        {
            return View();
        }

        public ActionResult Invoice2()
        {
            return View();
        }

        public ActionResult Invoice3()
        {
            return View();
        }

        public ActionResult InvoicePrint()
        {
            return View();
        }

        public ActionResult Lockscreen()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}