﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDashboard.Controllers
{
    public class WidgetsController : Controller
    {
        // GET: Widgets
        public ActionResult Index()
        {
            return View();
        }
    }
}