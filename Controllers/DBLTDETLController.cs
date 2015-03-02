using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DBLTDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DBLTDETL/

        public ActionResult Index()
        {
            return View(db.DBLTDETLs.ToList());
        }

        //
        // GET: /DBLTDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            DBLTDETL dbltdetl = db.DBLTDETLs.Single(d => d.PK == id);
            if (dbltdetl == null)
            {
                return HttpNotFound();
            }
            return View(dbltdetl);
        }

        //
        // GET: /DBLTDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DBLTDETL/Create

        [HttpPost]
        public ActionResult Create(DBLTDETL dbltdetl)
        {
            if (ModelState.IsValid)
            {
                db.DBLTDETLs.AddObject(dbltdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbltdetl);
        }

        //
        // GET: /DBLTDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DBLTDETL dbltdetl = db.DBLTDETLs.Single(d => d.PK == id);
            if (dbltdetl == null)
            {
                return HttpNotFound();
            }
            return View(dbltdetl);
        }

        //
        // POST: /DBLTDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(DBLTDETL dbltdetl)
        {
            if (ModelState.IsValid)
            {
                db.DBLTDETLs.Attach(dbltdetl);
                db.ObjectStateManager.ChangeObjectState(dbltdetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbltdetl);
        }

        //
        // GET: /DBLTDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DBLTDETL dbltdetl = db.DBLTDETLs.Single(d => d.PK == id);
            if (dbltdetl == null)
            {
                return HttpNotFound();
            }
            return View(dbltdetl);
        }

        //
        // POST: /DBLTDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DBLTDETL dbltdetl = db.DBLTDETLs.Single(d => d.PK == id);
            db.DBLTDETLs.DeleteObject(dbltdetl);
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