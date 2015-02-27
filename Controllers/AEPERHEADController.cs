using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AEPERHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AEPERHEAD/

        public ActionResult Index()
        {
            return View(db.AEPERHEADs.ToList());
        }

        //
        // GET: /AEPERHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            AEPERHEAD aeperhead = db.AEPERHEADs.Single(a => a.PK == id);
            if (aeperhead == null)
            {
                return HttpNotFound();
            }
            return View(aeperhead);
        }

        //
        // GET: /AEPERHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AEPERHEAD/Create

        [HttpPost]
        public ActionResult Create(AEPERHEAD aeperhead)
        {
            if (ModelState.IsValid)
            {
                db.AEPERHEADs.AddObject(aeperhead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aeperhead);
        }

        //
        // GET: /AEPERHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AEPERHEAD aeperhead = db.AEPERHEADs.Single(a => a.PK == id);
            if (aeperhead == null)
            {
                return HttpNotFound();
            }
            return View(aeperhead);
        }

        //
        // POST: /AEPERHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(AEPERHEAD aeperhead)
        {
            if (ModelState.IsValid)
            {
                db.AEPERHEADs.Attach(aeperhead);
                db.ObjectStateManager.ChangeObjectState(aeperhead, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aeperhead);
        }

        //
        // GET: /AEPERHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AEPERHEAD aeperhead = db.AEPERHEADs.Single(a => a.PK == id);
            if (aeperhead == null)
            {
                return HttpNotFound();
            }
            return View(aeperhead);
        }

        //
        // POST: /AEPERHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AEPERHEAD aeperhead = db.AEPERHEADs.Single(a => a.PK == id);
            db.AEPERHEADs.DeleteObject(aeperhead);
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