﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom.Controllers
{
    public class RemoteController : Controller
    {
        //
        // GET: /Remote/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial()
        {
            return PartialView();
        }

    }
}
