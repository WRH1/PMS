using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUDITController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUDIT/

        public ActionResult Index()
        {
            return View(db.AUDITs.ToList());
        }

        //
        // GET: /AUDIT/Details/5

        public ActionResult Details(int id = 0)
        {
            AUDIT audit = db.AUDITs.Single(a => a.PK == id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            return View(audit);
        }

        //
        // GET: /AUDIT/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUDIT/Create

        [HttpPost]
        public ActionResult Create(AUDIT audit)
        {
            if (ModelState.IsValid)
            {
                db.AUDITs.AddObject(audit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(audit);
        }

        //
        // GET: /AUDIT/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUDIT audit = db.AUDITs.Single(a => a.PK == id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            return View(audit);
        }

        //
        // POST: /AUDIT/Edit/5

        [HttpPost]
        public ActionResult Edit(AUDIT audit)
        {
            if (ModelState.IsValid)
            {
                db.AUDITs.Attach(audit);
                db.ObjectStateManager.ChangeObjectState(audit, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(audit);
        }

        //
        // GET: /AUDIT/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUDIT audit = db.AUDITs.Single(a => a.PK == id);
            if (audit == null)
            {
                return HttpNotFound();
            }
            return View(audit);
        }

        //
        // POST: /AUDIT/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUDIT audit = db.AUDITs.Single(a => a.PK == id);
            db.AUDITs.DeleteObject(audit);
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