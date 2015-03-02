using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class FILEVARController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /FILEVAR/

        public ActionResult Index()
        {
            return View(db.FILEVARs.ToList());
        }

        //
        // GET: /FILEVAR/Details/5

        public ActionResult Details(int id = 0)
        {
            FILEVAR filevar = db.FILEVARs.Single(f => f.PK == id);
            if (filevar == null)
            {
                return HttpNotFound();
            }
            return View(filevar);
        }

        //
        // GET: /FILEVAR/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FILEVAR/Create

        [HttpPost]
        public ActionResult Create(FILEVAR filevar)
        {
            if (ModelState.IsValid)
            {
                db.FILEVARs.AddObject(filevar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filevar);
        }

        //
        // GET: /FILEVAR/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FILEVAR filevar = db.FILEVARs.Single(f => f.PK == id);
            if (filevar == null)
            {
                return HttpNotFound();
            }
            return View(filevar);
        }

        //
        // POST: /FILEVAR/Edit/5

        [HttpPost]
        public ActionResult Edit(FILEVAR filevar)
        {
            if (ModelState.IsValid)
            {
                db.FILEVARs.Attach(filevar);
                db.ObjectStateManager.ChangeObjectState(filevar, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filevar);
        }

        //
        // GET: /FILEVAR/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FILEVAR filevar = db.FILEVARs.Single(f => f.PK == id);
            if (filevar == null)
            {
                return HttpNotFound();
            }
            return View(filevar);
        }

        //
        // POST: /FILEVAR/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FILEVAR filevar = db.FILEVARs.Single(f => f.PK == id);
            db.FILEVARs.DeleteObject(filevar);
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