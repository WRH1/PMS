using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class BACKUPSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /BACKUPS/

        public ActionResult Index()
        {
            return View(db.BACKUPS.ToList());
        }

        //
        // GET: /BACKUPS/Details/5

        public ActionResult Details(int id = 0)
        {
            BACKUP backup = db.BACKUPS.Single(b => b.PK == id);
            if (backup == null)
            {
                return HttpNotFound();
            }
            return View(backup);
        }

        //
        // GET: /BACKUPS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BACKUPS/Create

        [HttpPost]
        public ActionResult Create(BACKUP backup)
        {
            if (ModelState.IsValid)
            {
                db.BACKUPS.AddObject(backup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(backup);
        }

        //
        // GET: /BACKUPS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BACKUP backup = db.BACKUPS.Single(b => b.PK == id);
            if (backup == null)
            {
                return HttpNotFound();
            }
            return View(backup);
        }

        //
        // POST: /BACKUPS/Edit/5

        [HttpPost]
        public ActionResult Edit(BACKUP backup)
        {
            if (ModelState.IsValid)
            {
                db.BACKUPS.Attach(backup);
                db.ObjectStateManager.ChangeObjectState(backup, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(backup);
        }

        //
        // GET: /BACKUPS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BACKUP backup = db.BACKUPS.Single(b => b.PK == id);
            if (backup == null)
            {
                return HttpNotFound();
            }
            return View(backup);
        }

        //
        // POST: /BACKUPS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BACKUP backup = db.BACKUPS.Single(b => b.PK == id);
            db.BACKUPS.DeleteObject(backup);
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