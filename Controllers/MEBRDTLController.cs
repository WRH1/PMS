using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MEBRDTLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MEBRDTL/

        public ActionResult Index()
        {
            return View(db.MEBRDTLs.ToList());
        }

        //
        // GET: /MEBRDTL/Details/5

        public ActionResult Details(int id = 0)
        {
            MEBRDTL mebrdtl = db.MEBRDTLs.Single(m => m.PK == id);
            if (mebrdtl == null)
            {
                return HttpNotFound();
            }
            return View(mebrdtl);
        }

        //
        // GET: /MEBRDTL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MEBRDTL/Create

        [HttpPost]
        public ActionResult Create(MEBRDTL mebrdtl)
        {
            if (ModelState.IsValid)
            {
                db.MEBRDTLs.AddObject(mebrdtl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mebrdtl);
        }

        //
        // GET: /MEBRDTL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MEBRDTL mebrdtl = db.MEBRDTLs.Single(m => m.PK == id);
            if (mebrdtl == null)
            {
                return HttpNotFound();
            }
            return View(mebrdtl);
        }

        //
        // POST: /MEBRDTL/Edit/5

        [HttpPost]
        public ActionResult Edit(MEBRDTL mebrdtl)
        {
            if (ModelState.IsValid)
            {
                db.MEBRDTLs.Attach(mebrdtl);
                db.ObjectStateManager.ChangeObjectState(mebrdtl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mebrdtl);
        }

        //
        // GET: /MEBRDTL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MEBRDTL mebrdtl = db.MEBRDTLs.Single(m => m.PK == id);
            if (mebrdtl == null)
            {
                return HttpNotFound();
            }
            return View(mebrdtl);
        }

        //
        // POST: /MEBRDTL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MEBRDTL mebrdtl = db.MEBRDTLs.Single(m => m.PK == id);
            db.MEBRDTLs.DeleteObject(mebrdtl);
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