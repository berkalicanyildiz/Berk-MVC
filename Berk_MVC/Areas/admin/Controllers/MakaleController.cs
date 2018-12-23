using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Berk_MVC.Models;

namespace Berk_MVC.Areas.admin.Controllers
{
    public class MakaleController : Controller
    {
        private berk_siteEntities db = new berk_siteEntities();

        // GET: admin/Makale
        public ActionResult Index()
        {
            var makales = db.Makales.Include(m => m.Kategori);
            return View(makales.ToList());
        }

      
        // GET: admin/Makale/Create
        public ActionResult Create()
        {
            ViewBag.KategoriID = new SelectList(db.Kategoris, "katid", "KategoriAdi");
            return View();
        }

        // POST: admin/Makale/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "id,MakaleBaslik,MakaleOzet,MakaleIcerik,MakaleResim,MakaleTarih,Sira,makaleOkunma,MakaleYorumSayisi,Aktif,KategoriID,sil")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Makales.Add(makale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriID = new SelectList(db.Kategoris, "katid", "KategoriAdi", makale.KategoriID);
            return View(makale);
        }

        // GET: admin/Makale/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makales.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriID = new SelectList(db.Kategoris, "katid", "KategoriAdi", makale.KategoriID);
            return View(makale);
        }

        // POST: admin/Makale/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "id,MakaleBaslik,MakaleOzet,MakaleIcerik,MakaleResim,MakaleTarih,Sira,makaleOkunma,MakaleYorumSayisi,Aktif,KategoriID,sil")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(makale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriID = new SelectList(db.Kategoris, "katid", "KategoriAdi", makale.KategoriID);
            return View(makale);
        }

        // GET: admin/Makale/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Makale makale = db.Makales.Find(id);
            if (makale == null)
            {
                return HttpNotFound();
            }
            return View(makale);
        }

        // POST: admin/Makale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Makale makale = db.Makales.Find(id);
            db.Makales.Remove(makale);
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
