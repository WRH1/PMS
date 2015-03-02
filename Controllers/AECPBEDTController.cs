using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AECPBEDTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AECPBEDT/

        public ActionResult Index()
        {
            return View(db.AECPBEDTs.ToList());
        }

        //
        // GET: /AECPBEDT/Details/5

        public ActionResult Details(int id = 0)
        {
            AECPBEDT aecpbedt = db.AECPBEDTs.Single(a => a.PK == id);
            if (aecpbedt == null)
            {
                return HttpNotFound();
            }
            return View(aecpbedt);
        }

        //
        // GET: /AECPBEDT/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AECPBEDT/Create

        [HttpPost]
        public ActionResult Create(AECPBEDT aecpbedt)
        {
            if (ModelState.IsValid)
            {
                db.AECPBEDTs.AddObject(aecpbedt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aecpbedt);
        }

        //
        // GET: /AECPBEDT/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AECPBEDT aecpbedt = db.AECPBEDTs.Single(a => a.PK == id);
            if (aecpbedt == null)
            {
                return HttpNotFound();
            }
            return View(aecpbedt);
        }

        //
        // POST: /AECPBEDT/Edit/5

        [HttpPost]
        public ActionResult Edit(AECPBEDT aecpbedt)
        {
            if (ModelState.IsValid)
            {
                db.AECPBEDTs.Attach(aecpbedt);
                db.ObjectStateManager.ChangeObjectState(aecpbedt, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aecpbedt);
        }

        //
        // GET: /AECPBEDT/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AECPBEDT aecpbedt = db.AECPBEDTs.Single(a => a.PK == id);
            if (aecpbedt == null)
            {
                return HttpNotFound();
            }
            return View(aecpbedt);
        }

        //
        // POST: /AECPBEDT/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AECPBEDT aecpbedt = db.AECPBEDTs.Single(a => a.PK == id);
            db.AECPBEDTs.DeleteObject(aecpbedt);
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