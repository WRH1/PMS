using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFPIC/

        public ActionResult Index()
        {
            return View(db.DEFPICs.ToList());
        }

        //
        // GET: /DEFPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFPIC defpic = db.DEFPICs.Single(d => d.PK == id);
            if (defpic == null)
            {
                return HttpNotFound();
            }
            return View(defpic);
        }

        //
        // GET: /DEFPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFPIC/Create

        [HttpPost]
        public ActionResult Create(DEFPIC defpic)
        {
            if (ModelState.IsValid)
            {
                db.DEFPICs.AddObject(defpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defpic);
        }

        //
        // GET: /DEFPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFPIC defpic = db.DEFPICs.Single(d => d.PK == id);
            if (defpic == null)
            {
                return HttpNotFound();
            }
            return View(defpic);
        }

        //
        // POST: /DEFPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFPIC defpic)
        {
            if (ModelState.IsValid)
            {
                db.DEFPICs.Attach(defpic);
                db.ObjectStateManager.ChangeObjectState(defpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defpic);
        }

        //
        // GET: /DEFPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFPIC defpic = db.DEFPICs.Single(d => d.PK == id);
            if (defpic == null)
            {
                return HttpNotFound();
            }
            return View(defpic);
        }

        //
        // POST: /DEFPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFPIC defpic = db.DEFPICs.Single(d => d.PK == id);
            db.DEFPICs.DeleteObject(defpic);
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