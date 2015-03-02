using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MEEXOVRController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MEEXOVR/

        public ActionResult Index()
        {
            return View(db.MEEXOVRs.ToList());
        }

        //
        // GET: /MEEXOVR/Details/5

        public ActionResult Details(int id = 0)
        {
            MEEXOVR meexovr = db.MEEXOVRs.Single(m => m.PK == id);
            if (meexovr == null)
            {
                return HttpNotFound();
            }
            return View(meexovr);
        }

        //
        // GET: /MEEXOVR/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MEEXOVR/Create

        [HttpPost]
        public ActionResult Create(MEEXOVR meexovr)
        {
            if (ModelState.IsValid)
            {
                db.MEEXOVRs.AddObject(meexovr);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meexovr);
        }

        //
        // GET: /MEEXOVR/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MEEXOVR meexovr = db.MEEXOVRs.Single(m => m.PK == id);
            if (meexovr == null)
            {
                return HttpNotFound();
            }
            return View(meexovr);
        }

        //
        // POST: /MEEXOVR/Edit/5

        [HttpPost]
        public ActionResult Edit(MEEXOVR meexovr)
        {
            if (ModelState.IsValid)
            {
                db.MEEXOVRs.Attach(meexovr);
                db.ObjectStateManager.ChangeObjectState(meexovr, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meexovr);
        }

        //
        // GET: /MEEXOVR/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MEEXOVR meexovr = db.MEEXOVRs.Single(m => m.PK == id);
            if (meexovr == null)
            {
                return HttpNotFound();
            }
            return View(meexovr);
        }

        //
        // POST: /MEEXOVR/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MEEXOVR meexovr = db.MEEXOVRs.Single(m => m.PK == id);
            db.MEEXOVRs.DeleteObject(meexovr);
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