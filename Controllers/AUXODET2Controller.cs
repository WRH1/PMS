using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUXODET2Controller : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUXODET2/

        public ActionResult Index()
        {
            return View(db.AUXODET2.ToList());
        }

        //
        // GET: /AUXODET2/Details/5

        public ActionResult Details(int id = 0)
        {
            AUXODET2 auxodet2 = db.AUXODET2.Single(a => a.PK == id);
            if (auxodet2 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet2);
        }

        //
        // GET: /AUXODET2/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUXODET2/Create

        [HttpPost]
        public ActionResult Create(AUXODET2 auxodet2)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET2.AddObject(auxodet2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auxodet2);
        }

        //
        // GET: /AUXODET2/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUXODET2 auxodet2 = db.AUXODET2.Single(a => a.PK == id);
            if (auxodet2 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet2);
        }

        //
        // POST: /AUXODET2/Edit/5

        [HttpPost]
        public ActionResult Edit(AUXODET2 auxodet2)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET2.Attach(auxodet2);
                db.ObjectStateManager.ChangeObjectState(auxodet2, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auxodet2);
        }

        //
        // GET: /AUXODET2/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUXODET2 auxodet2 = db.AUXODET2.Single(a => a.PK == id);
            if (auxodet2 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet2);
        }

        //
        // POST: /AUXODET2/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUXODET2 auxodet2 = db.AUXODET2.Single(a => a.PK == id);
            db.AUXODET2.DeleteObject(auxodet2);
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