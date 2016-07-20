using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult Data()
        {
            return View();
        }

        public ActionResult Simple()
        {
            return View();
        }
    }
}