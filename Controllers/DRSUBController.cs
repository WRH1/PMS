using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DRSUBController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DRSUB/

        public ActionResult Index()
        {
            return View(db.DRSUBs.ToList());
        }

        //
        // GET: /DRSUB/Details/5

        public ActionResult Details(int id = 0)
        {
            DRSUB drsub = db.DRSUBs.Single(d => d.PK == id);
            if (drsub == null)
            {
                return HttpNotFound();
            }
            return View(drsub);
        }

        //
        // GET: /DRSUB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DRSUB/Create

        [HttpPost]
        public ActionResult Create(DRSUB drsub)
        {
            if (ModelState.IsValid)
            {
                db.DRSUBs.AddObject(drsub);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drsub);
        }

        //
        // GET: /DRSUB/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DRSUB drsub = db.DRSUBs.Single(d => d.PK == id);
            if (drsub == null)
            {
                return HttpNotFound();
            }
            return View(drsub);
        }

        //
        // POST: /DRSUB/Edit/5

        [HttpPost]
        public ActionResult Edit(DRSUB drsub)
        {
            if (ModelState.IsValid)
            {
                db.DRSUBs.Attach(drsub);
                db.ObjectStateManager.ChangeObjectState(drsub, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drsub);
        }

        //
        // GET: /DRSUB/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DRSUB drsub = db.DRSUBs.Single(d => d.PK == id);
            if (drsub == null)
            {
                return HttpNotFound();
            }
            return View(drsub);
        }

        //
        // POST: /DRSUB/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DRSUB drsub = db.DRSUBs.Single(d => d.PK == id);
            db.DRSUBs.DeleteObject(drsub);
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