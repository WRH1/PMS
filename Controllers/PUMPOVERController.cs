using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PUMPOVERController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PUMPOVER/

        public ActionResult Index()
        {
            return View(db.PUMPOVERs.ToList());
        }

        //
        // GET: /PUMPOVER/Details/5

        public ActionResult Details(int id = 0)
        {
            PUMPOVER pumpover = db.PUMPOVERs.Single(p => p.PK == id);
            if (pumpover == null)
            {
                return HttpNotFound();
            }
            return View(pumpover);
        }

        //
        // GET: /PUMPOVER/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PUMPOVER/Create

        [HttpPost]
        public ActionResult Create(PUMPOVER pumpover)
        {
            if (ModelState.IsValid)
            {
                db.PUMPOVERs.AddObject(pumpover);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pumpover);
        }

        //
        // GET: /PUMPOVER/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PUMPOVER pumpover = db.PUMPOVERs.Single(p => p.PK == id);
            if (pumpover == null)
            {
                return HttpNotFound();
            }
            return View(pumpover);
        }

        //
        // POST: /PUMPOVER/Edit/5

        [HttpPost]
        public ActionResult Edit(PUMPOVER pumpover)
        {
            if (ModelState.IsValid)
            {
                db.PUMPOVERs.Attach(pumpover);
                db.ObjectStateManager.ChangeObjectState(pumpover, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pumpover);
        }

        //
        // GET: /PUMPOVER/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PUMPOVER pumpover = db.PUMPOVERs.Single(p => p.PK == id);
            if (pumpover == null)
            {
                return HttpNotFound();
            }
            return View(pumpover);
        }

        //
        // POST: /PUMPOVER/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PUMPOVER pumpover = db.PUMPOVERs.Single(p => p.PK == id);
            db.PUMPOVERs.DeleteObject(pumpover);
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