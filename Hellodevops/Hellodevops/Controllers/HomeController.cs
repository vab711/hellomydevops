﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hellodevops.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.test = "test";
            return View();
        }
    }
}