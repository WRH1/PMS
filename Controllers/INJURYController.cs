using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INJURYController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INJURY/

        public ActionResult Index()
        {
            return View(db.INJURies.ToList());
        }

        //
        // GET: /INJURY/Details/5

        public ActionResult Details(int id = 0)
        {
            INJURY injury = db.INJURies.Single(i => i.PK == id);
            if (injury == null)
            {
                return HttpNotFound();
            }
            return View(injury);
        }

        //
        // GET: /INJURY/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INJURY/Create

        [HttpPost]
        public ActionResult Create(INJURY injury)
        {
            if (ModelState.IsValid)
            {
                db.INJURies.AddObject(injury);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(injury);
        }

        //
        // GET: /INJURY/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INJURY injury = db.INJURies.Single(i => i.PK == id);
            if (injury == null)
            {
                return HttpNotFound();
            }
            return View(injury);
        }

        //
        // POST: /INJURY/Edit/5

        [HttpPost]
        public ActionResult Edit(INJURY injury)
        {
            if (ModelState.IsValid)
            {
                db.INJURies.Attach(injury);
                db.ObjectStateManager.ChangeObjectState(injury, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(injury);
        }

        //
        // GET: /INJURY/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INJURY injury = db.INJURies.Single(i => i.PK == id);
            if (injury == null)
            {
                return HttpNotFound();
            }
            return View(injury);
        }

        //
        // POST: /INJURY/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INJURY injury = db.INJURies.Single(i => i.PK == id);
            db.INJURies.DeleteObject(injury);
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