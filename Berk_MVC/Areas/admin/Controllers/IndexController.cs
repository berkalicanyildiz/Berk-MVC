using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;

namespace Berk_MVC.Areas.admin.Controllers
{
    public class IndexController : Controller
    {
        berk_siteEntities db = new berk_siteEntities();
        // GET: admin/Index
        public ActionResult Index()
        {
            var toplammakale = db.Makales.ToList();
            ViewBag.toplammakale = toplammakale.Count;

            var toplamkategori = db.Kategoris.Count();
            ViewBag.toplamkategori = toplamkategori;

            var toplamokuma = (from u in db.Makales select new { u.makaleOkunma }).Count();
            ViewBag.toplamokuma = toplamokuma;


            return View();
        }
       
    }
}