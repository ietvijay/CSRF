using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrossSiteScriptingAttack.Models;
namespace CrossSiteScriptingAttack.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            //Send CSRF token to view
            TempData["Token"]= ViewBag.Token = Guid.NewGuid();
            return View();
        }

     
        [Route("account/unsecured")]
        public ActionResult Unsecured()
        {
           return View("UnSecuredIndex");
        }
        
        [HttpPost]
        public ActionResult ProcessTransferUnSecured(Account account)
        {

            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }

        }

        [Route("account/secured")]
        public ActionResult Secured()
        {
            //Send CSRF token to view
            TempData["Token"] = ViewBag.Token = Guid.NewGuid();
            return View("SecuredIndex");
        }
        [HttpPost]
        public ActionResult ProcessTransferSecured(Account account, Guid Token)
        {
            //Validate the token
            if (TempData["Token"]==null || Token != (Guid)TempData["Token"])
            {
                return View("Failure");
            }
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }
            
        }

       
    }
}