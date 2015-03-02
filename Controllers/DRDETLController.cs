using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DRDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DRDETL/

        public ActionResult Index()
        {
            return View(db.DRDETLs.ToList());
        }

        //
        // GET: /DRDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            DRDETL drdetl = db.DRDETLs.Single(d => d.PK == id);
            if (drdetl == null)
            {
                return HttpNotFound();
            }
            return View(drdetl);
        }

        //
        // GET: /DRDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DRDETL/Create

        [HttpPost]
        public ActionResult Create(DRDETL drdetl)
        {
            if (ModelState.IsValid)
            {
                db.DRDETLs.AddObject(drdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drdetl);
        }

        //
        // GET: /DRDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DRDETL drdetl = db.DRDETLs.Single(d => d.PK == id);
            if (drdetl == null)
            {
                return HttpNotFound();
            }
            return View(drdetl);
        }

        //
        // POST: /DRDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(DRDETL drdetl)
        {
            if (ModelState.IsValid)
            {
                db.DRDETLs.Attach(drdetl);
                db.ObjectStateManager.ChangeObjectState(drdetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drdetl);
        }

        //
        // GET: /DRDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DRDETL drdetl = db.DRDETLs.Single(d => d.PK == id);
            if (drdetl == null)
            {
                return HttpNotFound();
            }
            return View(drdetl);
        }

        //
        // POST: /DRDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DRDETL drdetl = db.DRDETLs.Single(d => d.PK == id);
            db.DRDETLs.DeleteObject(drdetl);
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