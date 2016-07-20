using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class LayoutController : Controller
    {
        // GET: Boxed
        public ActionResult Boxed()
        {
            return View();
        }

        // GET: CollapsedSidebar
        public ActionResult CollapsedSidebar()
        {
            return View();
        }

        // GET: Fixed
        public ActionResult Fixed()
        {
            return View();
        }

        // GET: TopNav
        public ActionResult TopNav()
        {
            return View();
        }

    }
}