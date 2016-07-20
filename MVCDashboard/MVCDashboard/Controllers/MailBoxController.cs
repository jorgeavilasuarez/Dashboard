using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class MailBoxController : Controller
    {
        // GET: MailBox
        public ActionResult Compose()
        {
            return View();
        }

        public ActionResult MailBox()
        {
            return View();
        }

        public ActionResult ReadMail()
        {
            return View();
        }
    }
}