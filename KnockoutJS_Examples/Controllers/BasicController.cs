﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutJS_Examples.Controllers
{
    public class BasicController : Controller
    {
        //
        // GET: /Basic/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult ClickToEdit()
        {
            return View();
        }
    }
}
