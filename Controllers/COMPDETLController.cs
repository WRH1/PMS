using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class COMPDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /COMPDETL/

        public ActionResult Index()
        {
            return View(db.COMPDETLs.ToList());
        }

        //
        // GET: /COMPDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            COMPDETL compdetl = db.COMPDETLs.Single(c => c.PK == id);
            if (compdetl == null)
            {
                return HttpNotFound();
            }
            return View(compdetl);
        }

        //
        // GET: /COMPDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /COMPDETL/Create

        [HttpPost]
        public ActionResult Create(COMPDETL compdetl)
        {
            if (ModelState.IsValid)
            {
                db.COMPDETLs.AddObject(compdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compdetl);
        }

        //
        // GET: /COMPDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            COMPDETL compdetl = db.COMPDETLs.Single(c => c.PK == id);
            if (compdetl == null)
            {
                return HttpNotFound();
            }
            return View(compdetl);
        }

        //
        // POST: /COMPDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(COMPDETL compdetl)
        {
            if (ModelState.IsValid)
            {
                db.COMPDETLs.Attach(compdetl);
                db.ObjectStateManager.ChangeObjectState(compdetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compdetl);
        }

        //
        // GET: /COMPDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            COMPDETL compdetl = db.COMPDETLs.Single(c => c.PK == id);
            if (compdetl == null)
            {
                return HttpNotFound();
            }
            return View(compdetl);
        }

        //
        // POST: /COMPDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            COMPDETL compdetl = db.COMPDETLs.Single(c => c.PK == id);
            db.COMPDETLs.DeleteObject(compdetl);
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