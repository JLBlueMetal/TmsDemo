﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TmsDemo.Web.Controllers0
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "no page";
            return View();
        }

    }
}