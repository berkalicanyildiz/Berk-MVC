using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;
using System.Web.UI.WebControls;
using PagedList;

namespace Berk_MVC.Areas.tr.Controllers
{
    public class KategorilerController : Controller
    {
        berk_siteEntities db = new berk_siteEntities();
        public static PagedDataSource pds;
       
        // GET: tr/Kategoriler
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            var kategoriler = db.Kategoris.Where(x => x.Aktif==true).OrderBy(m => m.katid).ToPagedList<Kategori>(_sayfaNo, 10);

            return View(kategoriler);
        }
    }
}