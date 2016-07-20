using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class UserInterfaceController : Controller
    {
        // GET: UserInterface
        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult General()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Modals()
        {
            return View();
        }

        public ActionResult Sliders()
        {
            return View();
        }

        public ActionResult TimeLine()
        {
            return View();
        }
    }
}