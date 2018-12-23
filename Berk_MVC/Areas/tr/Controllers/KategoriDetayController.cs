using Berk_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Berk_MVC.Areas.tr.Controllers
{
    public class KategoriDetayController : Controller
    {
        berk_siteEntities db = new berk_siteEntities();
        
        // GET: tr/KategoriDetay
        public ActionResult Index(int? id, string id2)
        {
            if (id == null)
            {
                Response.Redirect("/tr/index");
            }
            List<Makale> makaleler = db.Makales.Where(x => x.KategoriID == id).OrderByDescending(x => x.Sira).ToList();

            Kategori yazar = (from u in db.Kategoris
                              where u.katid==id
                            select u).FirstOrDefault();

            ViewBag.adi = yazar.KategoriAdi;
            return View(makaleler);
        }
    }
}