using Berk_MVC.Models;
using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Berk_MVC.Areas.tr.Controllers
{
    public class DetayController : Controller
    {
       berk_siteEntities db = new berk_siteEntities();

        // GET: tr/Detay
        public ActionResult Index(int? id, string id2)
        {

            dynamic model = new ExpandoObject();
           

            if (id ==null)
            {
                Response.Redirect("/tr/index");
            }
            List<Makale> makaleler = db.Makales.Where(x => x.id==id).OrderByDescending(x => x.Sira).ToList();


            string katid = db.Makales.Where(x => x.id == id).OrderByDescending(x => x.Sira).FirstOrDefault().KategoriID.ToString();
            int kategoriid = Convert.ToInt32(katid);
            List<Makale> benzer = db.Makales.Where(x => x.KategoriID == kategoriid).ToList();
            model.makale = makaleler;
            model.aynikategori = benzer;
            return View(model);
        }
    }
}