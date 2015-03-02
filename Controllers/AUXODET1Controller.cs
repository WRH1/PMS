using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUXODET1Controller : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUXODET1/

        public ActionResult Index()
        {
            return View(db.AUXODET1.ToList());
        }

        //
        // GET: /AUXODET1/Details/5

        public ActionResult Details(int id = 0)
        {
            AUXODET1 auxodet1 = db.AUXODET1.Single(a => a.PK == id);
            if (auxodet1 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet1);
        }

        //
        // GET: /AUXODET1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUXODET1/Create

        [HttpPost]
        public ActionResult Create(AUXODET1 auxodet1)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET1.AddObject(auxodet1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auxodet1);
        }

        //
        // GET: /AUXODET1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUXODET1 auxodet1 = db.AUXODET1.Single(a => a.PK == id);
            if (auxodet1 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet1);
        }

        //
        // POST: /AUXODET1/Edit/5

        [HttpPost]
        public ActionResult Edit(AUXODET1 auxodet1)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET1.Attach(auxodet1);
                db.ObjectStateManager.ChangeObjectState(auxodet1, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auxodet1);
        }

        //
        // GET: /AUXODET1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUXODET1 auxodet1 = db.AUXODET1.Single(a => a.PK == id);
            if (auxodet1 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet1);
        }

        //
        // POST: /AUXODET1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUXODET1 auxodet1 = db.AUXODET1.Single(a => a.PK == id);
            db.AUXODET1.DeleteObject(auxodet1);
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