using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Berk_MVC.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: admin/Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}