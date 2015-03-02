using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSBKController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSBK/

        public ActionResult Index()
        {
            return View(db.PMSBKs.ToList());
        }

        //
        // GET: /PMSBK/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSBK pmsbk = db.PMSBKs.Single(p => p.PK == id);
            if (pmsbk == null)
            {
                return HttpNotFound();
            }
            return View(pmsbk);
        }

        //
        // GET: /PMSBK/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSBK/Create

        [HttpPost]
        public ActionResult Create(PMSBK pmsbk)
        {
            if (ModelState.IsValid)
            {
                db.PMSBKs.AddObject(pmsbk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmsbk);
        }

        //
        // GET: /PMSBK/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSBK pmsbk = db.PMSBKs.Single(p => p.PK == id);
            if (pmsbk == null)
            {
                return HttpNotFound();
            }
            return View(pmsbk);
        }

        //
        // POST: /PMSBK/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSBK pmsbk)
        {
            if (ModelState.IsValid)
            {
                db.PMSBKs.Attach(pmsbk);
                db.ObjectStateManager.ChangeObjectState(pmsbk, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmsbk);
        }

        //
        // GET: /PMSBK/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSBK pmsbk = db.PMSBKs.Single(p => p.PK == id);
            if (pmsbk == null)
            {
                return HttpNotFound();
            }
            return View(pmsbk);
        }

        //
        // POST: /PMSBK/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSBK pmsbk = db.PMSBKs.Single(p => p.PK == id);
            db.PMSBKs.DeleteObject(pmsbk);
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