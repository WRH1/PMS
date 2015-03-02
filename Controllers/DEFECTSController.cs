using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFECTSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFECTS/

        public ActionResult Index()
        {
            return View(db.DEFECTS.ToList());
        }

        //
        // GET: /DEFECTS/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFECT defect = db.DEFECTS.Single(d => d.PK == id);
            if (defect == null)
            {
                return HttpNotFound();
            }
            return View(defect);
        }

        //
        // GET: /DEFECTS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFECTS/Create

        [HttpPost]
        public ActionResult Create(DEFECT defect)
        {
            if (ModelState.IsValid)
            {
                db.DEFECTS.AddObject(defect);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defect);
        }

        //
        // GET: /DEFECTS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFECT defect = db.DEFECTS.Single(d => d.PK == id);
            if (defect == null)
            {
                return HttpNotFound();
            }
            return View(defect);
        }

        //
        // POST: /DEFECTS/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFECT defect)
        {
            if (ModelState.IsValid)
            {
                db.DEFECTS.Attach(defect);
                db.ObjectStateManager.ChangeObjectState(defect, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defect);
        }

        //
        // GET: /DEFECTS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFECT defect = db.DEFECTS.Single(d => d.PK == id);
            if (defect == null)
            {
                return HttpNotFound();
            }
            return View(defect);
        }

        //
        // POST: /DEFECTS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFECT defect = db.DEFECTS.Single(d => d.PK == id);
            db.DEFECTS.DeleteObject(defect);
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