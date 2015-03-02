using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AUXOHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AUXOHEAD/

        public ActionResult Index()
        {
            return View(db.AUXOHEADs.ToList());
        }

        //
        // GET: /AUXOHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            AUXOHEAD auxohead = db.AUXOHEADs.Single(a => a.PK == id);
            if (auxohead == null)
            {
                return HttpNotFound();
            }
            return View(auxohead);
        }

        //
        // GET: /AUXOHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AUXOHEAD/Create

        [HttpPost]
        public ActionResult Create(AUXOHEAD auxohead)
        {
            if (ModelState.IsValid)
            {
                db.AUXOHEADs.AddObject(auxohead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auxohead);
        }

        //
        // GET: /AUXOHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AUXOHEAD auxohead = db.AUXOHEADs.Single(a => a.PK == id);
            if (auxohead == null)
            {
                return HttpNotFound();
            }
            return View(auxohead);
        }

        //
        // POST: /AUXOHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(AUXOHEAD auxohead)
        {
            if (ModelState.IsValid)
            {
                db.AUXOHEADs.Attach(auxohead);
                db.ObjectStateManager.ChangeObjectState(auxohead, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auxohead);
        }

        //
        // GET: /AUXOHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AUXOHEAD auxohead = db.AUXOHEADs.Single(a => a.PK == id);
            if (auxohead == null)
            {
                return HttpNotFound();
            }
            return View(auxohead);
        }

        //
        // POST: /AUXOHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AUXOHEAD auxohead = db.AUXOHEADs.Single(a => a.PK == id);
            db.AUXOHEADs.DeleteObject(auxohead);
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