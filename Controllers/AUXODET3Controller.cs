using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUXODET3Controller : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUXODET3/

        public ActionResult Index()
        {
            return View(db.AUXODET3.ToList());
        }

        //
        // GET: /AUXODET3/Details/5

        public ActionResult Details(int id = 0)
        {
            AUXODET3 auxodet3 = db.AUXODET3.Single(a => a.PK == id);
            if (auxodet3 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet3);
        }

        //
        // GET: /AUXODET3/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUXODET3/Create

        [HttpPost]
        public ActionResult Create(AUXODET3 auxodet3)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET3.AddObject(auxodet3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auxodet3);
        }

        //
        // GET: /AUXODET3/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUXODET3 auxodet3 = db.AUXODET3.Single(a => a.PK == id);
            if (auxodet3 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet3);
        }

        //
        // POST: /AUXODET3/Edit/5

        [HttpPost]
        public ActionResult Edit(AUXODET3 auxodet3)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET3.Attach(auxodet3);
                db.ObjectStateManager.ChangeObjectState(auxodet3, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auxodet3);
        }

        //
        // GET: /AUXODET3/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUXODET3 auxodet3 = db.AUXODET3.Single(a => a.PK == id);
            if (auxodet3 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet3);
        }

        //
        // POST: /AUXODET3/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUXODET3 auxodet3 = db.AUXODET3.Single(a => a.PK == id);
            db.AUXODET3.DeleteObject(auxodet3);
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