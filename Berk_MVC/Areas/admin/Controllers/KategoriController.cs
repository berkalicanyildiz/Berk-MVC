using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;
using System.IO;

namespace Berk_MVC.Areas.admin.Controllers
{
    public class KategoriController : Controller
    {
        private berk_siteEntities db = new berk_siteEntities();
       
        // GET: admin/Kategori
        public ActionResult Index()
        {
            return View(db.Kategoris.ToList());
        }

        // GET: admin/Kategori/Details/5
       

        // GET: admin/Kategori/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Kategori/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kategori kategori, HttpPostedFileBase yuklenecekDosya)
        {
            if (ModelState.IsValid)
            {
                if (yuklenecekDosya != null)
                {
                    string dosyaYolu = Path.GetFileName(yuklenecekDosya.FileName);
                    var yuklemeYeri = Path.Combine(Server.MapPath("~/uploads"), dosyaYolu);
                    yuklenecekDosya.SaveAs(yuklemeYeri);
                }
                string fcresim = yuklenecekDosya.FileName;
                var resim = "/uploads/" + fcresim;
                kategori.KategoriResim = resim;
              

                db.Kategoris.Add(kategori);
                db.SaveChanges();

                TempData["message"] = "OK";
                return RedirectToAction("Index");
            }
            return View(kategori);
        }

        // GET: admin/Kategori/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = db.Kategoris.Find(id);
            if (kategori == null)
            {
                return HttpNotFound();
            }
            return View(kategori);
        }

        // POST: admin/Kategori/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Kategori kategori, HttpPostedFileBase yuklenecekDosya)
        {
            if (ModelState.IsValid)
            {
                string fcresim = "";
                if (yuklenecekDosya != null)
                {
                    string dosyaYolu = Path.GetFileName(yuklenecekDosya.FileName);
                    var yuklemeYeri = Path.Combine(Server.MapPath("~/uploads"), dosyaYolu);
                    yuklenecekDosya.SaveAs(yuklemeYeri);
                     fcresim = yuklenecekDosya.FileName;
                    var resim = "/uploads/" + fcresim;
                    kategori.KategoriResim = resim;
                }
             
              


                db.Kategoris.Add(kategori);
                db.SaveChanges();

                TempData["message"] = "OK";
                return RedirectToAction("Index");
            }
            return View(kategori);
        }

        // GET: admin/Kategori/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kategori kategori = db.Kategoris.Find(id);
            if (kategori == null)
            {
                return HttpNotFound();
            }
            return View(kategori);
        }

        // POST: admin/Kategori/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kategori kategori = db.Kategoris.Find(id);
            db.Kategoris.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
