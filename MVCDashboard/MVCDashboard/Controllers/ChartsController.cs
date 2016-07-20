using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult ChartJs()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }

        public ActionResult Inline()
        {
            return View();
        }
    }
}