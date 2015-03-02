using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFPSTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFPST/

        public ActionResult Index()
        {
            return View(db.DEFPSTs.ToList());
        }

        //
        // GET: /DEFPST/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFPST defpst = db.DEFPSTs.Single(d => d.PK == id);
            if (defpst == null)
            {
                return HttpNotFound();
            }
            return View(defpst);
        }

        //
        // GET: /DEFPST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFPST/Create

        [HttpPost]
        public ActionResult Create(DEFPST defpst)
        {
            if (ModelState.IsValid)
            {
                db.DEFPSTs.AddObject(defpst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defpst);
        }

        //
        // GET: /DEFPST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFPST defpst = db.DEFPSTs.Single(d => d.PK == id);
            if (defpst == null)
            {
                return HttpNotFound();
            }
            return View(defpst);
        }

        //
        // POST: /DEFPST/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFPST defpst)
        {
            if (ModelState.IsValid)
            {
                db.DEFPSTs.Attach(defpst);
                db.ObjectStateManager.ChangeObjectState(defpst, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defpst);
        }

        //
        // GET: /DEFPST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFPST defpst = db.DEFPSTs.Single(d => d.PK == id);
            if (defpst == null)
            {
                return HttpNotFound();
            }
            return View(defpst);
        }

        //
        // POST: /DEFPST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFPST defpst = db.DEFPSTs.Single(d => d.PK == id);
            db.DEFPSTs.DeleteObject(defpst);
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