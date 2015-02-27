using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AECRPDTLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AECRPDTL/

        public ActionResult Index()
        {
            return View(db.AECRPDTLs.ToList());
        }

        //
        // GET: /AECRPDTL/Details/5

        public ActionResult Details(int id = 0)
        {
            AECRPDTL aecrpdtl = db.AECRPDTLs.Single(a => a.PK == id);
            if (aecrpdtl == null)
            {
                return HttpNotFound();
            }
            return View(aecrpdtl);
        }

        //
        // GET: /AECRPDTL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AECRPDTL/Create

        [HttpPost]
        public ActionResult Create(AECRPDTL aecrpdtl)
        {
            if (ModelState.IsValid)
            {
                db.AECRPDTLs.AddObject(aecrpdtl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aecrpdtl);
        }

        //
        // GET: /AECRPDTL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AECRPDTL aecrpdtl = db.AECRPDTLs.Single(a => a.PK == id);
            if (aecrpdtl == null)
            {
                return HttpNotFound();
            }
            return View(aecrpdtl);
        }

        //
        // POST: /AECRPDTL/Edit/5

        [HttpPost]
        public ActionResult Edit(AECRPDTL aecrpdtl)
        {
            if (ModelState.IsValid)
            {
                db.AECRPDTLs.Attach(aecrpdtl);
                db.ObjectStateManager.ChangeObjectState(aecrpdtl, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aecrpdtl);
        }

        //
        // GET: /AECRPDTL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AECRPDTL aecrpdtl = db.AECRPDTLs.Single(a => a.PK == id);
            if (aecrpdtl == null)
            {
                return HttpNotFound();
            }
            return View(aecrpdtl);
        }

        //
        // POST: /AECRPDTL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AECRPDTL aecrpdtl = db.AECRPDTLs.Single(a => a.PK == id);
            db.AECRPDTLs.DeleteObject(aecrpdtl);
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