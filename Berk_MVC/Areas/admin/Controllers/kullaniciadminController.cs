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
    public class kullaniciadminController : Controller
    {
        private berk_siteEntities db = new berk_siteEntities();

        // GET: admin/kullaniciadmin
        public ActionResult Index()
        {
            return View(db.kullaniciadmins.ToList());
        }

     

        // GET: admin/kullaniciadmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/kullaniciadmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,adi,soyadi,sifre,email,Aktif,sil")] kullaniciadmin kullaniciadmin)
        {
            if (ModelState.IsValid)
            {
                db.kullaniciadmins.Add(kullaniciadmin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kullaniciadmin);
        }

        // GET: admin/kullaniciadmin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kullaniciadmin kullaniciadmin = db.kullaniciadmins.Find(id);
            if (kullaniciadmin == null)
            {
                return HttpNotFound();
            }
            return View(kullaniciadmin);
        }

        // POST: admin/kullaniciadmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,adi,soyadi,sifre,email,Aktif,sil")] kullaniciadmin kullaniciadmin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kullaniciadmin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kullaniciadmin);
        }

        // GET: admin/kullaniciadmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kullaniciadmin kullaniciadmin = db.kullaniciadmins.Find(id);
            if (kullaniciadmin == null)
            {
                return HttpNotFound();
            }
            return View(kullaniciadmin);
        }

        // POST: admin/kullaniciadmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kullaniciadmin kullaniciadmin = db.kullaniciadmins.Find(id);
            db.kullaniciadmins.Remove(kullaniciadmin);
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
