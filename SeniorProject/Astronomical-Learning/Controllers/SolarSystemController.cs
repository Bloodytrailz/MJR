﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Astronomical_Learning.Controllers
{
    public class SolarSystemController : Controller
    {
        // GET: SolarSystem
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Moon_Information()
        {
            return View();
        }

        public ActionResult Sun_Information()
        {
            return View();
        }


    }
}