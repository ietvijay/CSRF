using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackersWebApp.Controllers
{
    public class HackController : Controller
    {
        // GET: Hack
        public ActionResult Index()
        {
            return View();
        }
    }
}