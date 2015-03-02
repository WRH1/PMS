using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFOFFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFOFF/

        public ActionResult Index()
        {
            return View(db.DEFOFFs.ToList());
        }

        //
        // GET: /DEFOFF/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFOFF defoff = db.DEFOFFs.Single(d => d.PK == id);
            if (defoff == null)
            {
                return HttpNotFound();
            }
            return View(defoff);
        }

        //
        // GET: /DEFOFF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFOFF/Create

        [HttpPost]
        public ActionResult Create(DEFOFF defoff)
        {
            if (ModelState.IsValid)
            {
                db.DEFOFFs.AddObject(defoff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defoff);
        }

        //
        // GET: /DEFOFF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFOFF defoff = db.DEFOFFs.Single(d => d.PK == id);
            if (defoff == null)
            {
                return HttpNotFound();
            }
            return View(defoff);
        }

        //
        // POST: /DEFOFF/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFOFF defoff)
        {
            if (ModelState.IsValid)
            {
                db.DEFOFFs.Attach(defoff);
                db.ObjectStateManager.ChangeObjectState(defoff, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defoff);
        }

        //
        // GET: /DEFOFF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFOFF defoff = db.DEFOFFs.Single(d => d.PK == id);
            if (defoff == null)
            {
                return HttpNotFound();
            }
            return View(defoff);
        }

        //
        // POST: /DEFOFF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFOFF defoff = db.DEFOFFs.Single(d => d.PK == id);
            db.DEFOFFs.DeleteObject(defoff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}