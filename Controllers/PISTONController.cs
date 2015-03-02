using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PISTONController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PISTON/

        public ActionResult Index()
        {
            return View(db.PISTONs.ToList());
        }

        //
        // GET: /PISTON/Details/5

        public ActionResult Details(int id = 0)
        {
            PISTON piston = db.PISTONs.Single(p => p.PK == id);
            if (piston == null)
            {
                return HttpNotFound();
            }
            return View(piston);
        }

        //
        // GET: /PISTON/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PISTON/Create

        [HttpPost]
        public ActionResult Create(PISTON piston)
        {
            if (ModelState.IsValid)
            {
                db.PISTONs.AddObject(piston);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(piston);
        }

        //
        // GET: /PISTON/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PISTON piston = db.PISTONs.Single(p => p.PK == id);
            if (piston == null)
            {
                return HttpNotFound();
            }
            return View(piston);
        }

        //
        // POST: /PISTON/Edit/5

        [HttpPost]
        public ActionResult Edit(PISTON piston)
        {
            if (ModelState.IsValid)
            {
                db.PISTONs.Attach(piston);
                db.ObjectStateManager.ChangeObjectState(piston, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(piston);
        }

        //
        // GET: /PISTON/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PISTON piston = db.PISTONs.Single(p => p.PK == id);
            if (piston == null)
            {
                return HttpNotFound();
            }
            return View(piston);
        }

        //
        // POST: /PISTON/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PISTON piston = db.PISTONs.Single(p => p.PK == id);
            db.PISTONs.DeleteObject(piston);
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