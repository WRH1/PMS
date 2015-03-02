using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DBLTHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DBLTHEAD/

        public ActionResult Index()
        {
            return View(db.DBLTHEADs.ToList());
        }

        //
        // GET: /DBLTHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            DBLTHEAD dblthead = db.DBLTHEADs.Single(d => d.PK == id);
            if (dblthead == null)
            {
                return HttpNotFound();
            }
            return View(dblthead);
        }

        //
        // GET: /DBLTHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DBLTHEAD/Create

        [HttpPost]
        public ActionResult Create(DBLTHEAD dblthead)
        {
            if (ModelState.IsValid)
            {
                db.DBLTHEADs.AddObject(dblthead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dblthead);
        }

        //
        // GET: /DBLTHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DBLTHEAD dblthead = db.DBLTHEADs.Single(d => d.PK == id);
            if (dblthead == null)
            {
                return HttpNotFound();
            }
            return View(dblthead);
        }

        //
        // POST: /DBLTHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(DBLTHEAD dblthead)
        {
            if (ModelState.IsValid)
            {
                db.DBLTHEADs.Attach(dblthead);
                db.ObjectStateManager.ChangeObjectState(dblthead, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dblthead);
        }

        //
        // GET: /DBLTHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DBLTHEAD dblthead = db.DBLTHEADs.Single(d => d.PK == id);
            if (dblthead == null)
            {
                return HttpNotFound();
            }
            return View(dblthead);
        }

        //
        // POST: /DBLTHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DBLTHEAD dblthead = db.DBLTHEADs.Single(d => d.PK == id);
            db.DBLTHEADs.DeleteObject(dblthead);
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