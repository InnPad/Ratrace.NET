using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Custom.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Shared/

        public ActionResult Header()
        {
            return PartialView();
        }

    }
}
