using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;

namespace Berk_MVC.Areas.tr.Controllers
{
    public class IndexController : Controller
    {
        berk_siteEntities db = new berk_siteEntities();
        // GET: tr/Index
        public ActionResult Index()
        {  
            
            List<Makale> makaleler = db.Makales.Where(x => x.Aktif == true && x.sil==false).OrderByDescending(x => x.Sira).ToList();
                return View(makaleler);   
        }

    }
}