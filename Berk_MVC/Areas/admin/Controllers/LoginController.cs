using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;

namespace Berk_MVC.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        berk_siteEntities db = new berk_siteEntities();
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }
      

        [HttpPost]
        public ActionResult Giris(kullaniciadmin user)
        {
            if (ModelState.IsValid)
            {
                kullaniciadmin yazar = (from u in db.kullaniciadmins
                                        where u.adi.Equals(user.adi) && (u.sifre.Equals(user.sifre))
                                        select u).SingleOrDefault();

                if (yazar == null)
                {
                    ViewBag.Hata = "Hatalı Giriş";

                }
                else
                {
                    Session.Add("AdminID", yazar.id);

                    Response.Redirect("/admin/Index");

                }
            }
           
            return View("Index");
        }
    }
}