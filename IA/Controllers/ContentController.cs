using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IA.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult men()
        {
            return View();
        }

        public ActionResult QuickView()
        {
            return View("single");
        }

        public ActionResult news()
        {
             return View();
        }
    }
}