using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class FPLOGBKController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /FPLOGBK/

        public ActionResult Index()
        {
            return View(db.FPLOGBKs.ToList());
        }

        //
        // GET: /FPLOGBK/Details/5

        public ActionResult Details(int id = 0)
        {
            FPLOGBK fplogbk = db.FPLOGBKs.Single(f => f.PK == id);
            if (fplogbk == null)
            {
                return HttpNotFound();
            }
            return View(fplogbk);
        }

        //
        // GET: /FPLOGBK/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FPLOGBK/Create

        [HttpPost]
        public ActionResult Create(FPLOGBK fplogbk)
        {
            if (ModelState.IsValid)
            {
                db.FPLOGBKs.AddObject(fplogbk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fplogbk);
        }

        //
        // GET: /FPLOGBK/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FPLOGBK fplogbk = db.FPLOGBKs.Single(f => f.PK == id);
            if (fplogbk == null)
            {
                return HttpNotFound();
            }
            return View(fplogbk);
        }

        //
        // POST: /FPLOGBK/Edit/5

        [HttpPost]
        public ActionResult Edit(FPLOGBK fplogbk)
        {
            if (ModelState.IsValid)
            {
                db.FPLOGBKs.Attach(fplogbk);
                db.ObjectStateManager.ChangeObjectState(fplogbk, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fplogbk);
        }

        //
        // GET: /FPLOGBK/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FPLOGBK fplogbk = db.FPLOGBKs.Single(f => f.PK == id);
            if (fplogbk == null)
            {
                return HttpNotFound();
            }
            return View(fplogbk);
        }

        //
        // POST: /FPLOGBK/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FPLOGBK fplogbk = db.FPLOGBKs.Single(f => f.PK == id);
            db.FPLOGBKs.DeleteObject(fplogbk);
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