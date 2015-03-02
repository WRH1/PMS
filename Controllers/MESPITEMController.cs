using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MESPITEMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MESPITEM/

        public ActionResult Index()
        {
            return View(db.MESPITEMs.ToList());
        }

        //
        // GET: /MESPITEM/Details/5

        public ActionResult Details(int id = 0)
        {
            MESPITEM mespitem = db.MESPITEMs.Single(m => m.PK == id);
            if (mespitem == null)
            {
                return HttpNotFound();
            }
            return View(mespitem);
        }

        //
        // GET: /MESPITEM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MESPITEM/Create

        [HttpPost]
        public ActionResult Create(MESPITEM mespitem)
        {
            if (ModelState.IsValid)
            {
                db.MESPITEMs.AddObject(mespitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mespitem);
        }

        //
        // GET: /MESPITEM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MESPITEM mespitem = db.MESPITEMs.Single(m => m.PK == id);
            if (mespitem == null)
            {
                return HttpNotFound();
            }
            return View(mespitem);
        }

        //
        // POST: /MESPITEM/Edit/5

        [HttpPost]
        public ActionResult Edit(MESPITEM mespitem)
        {
            if (ModelState.IsValid)
            {
                db.MESPITEMs.Attach(mespitem);
                db.ObjectStateManager.ChangeObjectState(mespitem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mespitem);
        }

        //
        // GET: /MESPITEM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MESPITEM mespitem = db.MESPITEMs.Single(m => m.PK == id);
            if (mespitem == null)
            {
                return HttpNotFound();
            }
            return View(mespitem);
        }

        //
        // POST: /MESPITEM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MESPITEM mespitem = db.MESPITEMs.Single(m => m.PK == id);
            db.MESPITEMs.DeleteObject(mespitem);
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