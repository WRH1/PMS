using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUXODET4Controller : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUXODET4/

        public ActionResult Index()
        {
            return View(db.AUXODET4.ToList());
        }

        //
        // GET: /AUXODET4/Details/5

        public ActionResult Details(int id = 0)
        {
            AUXODET4 auxodet4 = db.AUXODET4.Single(a => a.PK == id);
            if (auxodet4 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet4);
        }

        //
        // GET: /AUXODET4/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUXODET4/Create

        [HttpPost]
        public ActionResult Create(AUXODET4 auxodet4)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET4.AddObject(auxodet4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auxodet4);
        }

        //
        // GET: /AUXODET4/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUXODET4 auxodet4 = db.AUXODET4.Single(a => a.PK == id);
            if (auxodet4 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet4);
        }

        //
        // POST: /AUXODET4/Edit/5

        [HttpPost]
        public ActionResult Edit(AUXODET4 auxodet4)
        {
            if (ModelState.IsValid)
            {
                db.AUXODET4.Attach(auxodet4);
                db.ObjectStateManager.ChangeObjectState(auxodet4, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auxodet4);
        }

        //
        // GET: /AUXODET4/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUXODET4 auxodet4 = db.AUXODET4.Single(a => a.PK == id);
            if (auxodet4 == null)
            {
                return HttpNotFound();
            }
            return View(auxodet4);
        }

        //
        // POST: /AUXODET4/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUXODET4 auxodet4 = db.AUXODET4.Single(a => a.PK == id);
            db.AUXODET4.DeleteObject(auxodet4);
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