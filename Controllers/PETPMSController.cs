using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PETPMSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PETPMS/

        public ActionResult Index()
        {
            return View(db.PETPMS.ToList());
        }

        //
        // GET: /PETPMS/Details/5

        public ActionResult Details(int id = 0)
        {
            PETPM petpm = db.PETPMS.Single(p => p.PK == id);
            if (petpm == null)
            {
                return HttpNotFound();
            }
            return View(petpm);
        }

        //
        // GET: /PETPMS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PETPMS/Create

        [HttpPost]
        public ActionResult Create(PETPM petpm)
        {
            if (ModelState.IsValid)
            {
                db.PETPMS.AddObject(petpm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petpm);
        }

        //
        // GET: /PETPMS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PETPM petpm = db.PETPMS.Single(p => p.PK == id);
            if (petpm == null)
            {
                return HttpNotFound();
            }
            return View(petpm);
        }

        //
        // POST: /PETPMS/Edit/5

        [HttpPost]
        public ActionResult Edit(PETPM petpm)
        {
            if (ModelState.IsValid)
            {
                db.PETPMS.Attach(petpm);
                db.ObjectStateManager.ChangeObjectState(petpm, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petpm);
        }

        //
        // GET: /PETPMS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PETPM petpm = db.PETPMS.Single(p => p.PK == id);
            if (petpm == null)
            {
                return HttpNotFound();
            }
            return View(petpm);
        }

        //
        // POST: /PETPMS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PETPM petpm = db.PETPMS.Single(p => p.PK == id);
            db.PETPMS.DeleteObject(petpm);
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