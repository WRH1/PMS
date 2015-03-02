using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MEPERFORMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MEPERFORM/

        public ActionResult Index()
        {
            return View(db.MEPERFORMs.ToList());
        }

        //
        // GET: /MEPERFORM/Details/5

        public ActionResult Details(int id = 0)
        {
            MEPERFORM meperform = db.MEPERFORMs.Single(m => m.PK == id);
            if (meperform == null)
            {
                return HttpNotFound();
            }
            return View(meperform);
        }

        //
        // GET: /MEPERFORM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MEPERFORM/Create

        [HttpPost]
        public ActionResult Create(MEPERFORM meperform)
        {
            if (ModelState.IsValid)
            {
                db.MEPERFORMs.AddObject(meperform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meperform);
        }

        //
        // GET: /MEPERFORM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MEPERFORM meperform = db.MEPERFORMs.Single(m => m.PK == id);
            if (meperform == null)
            {
                return HttpNotFound();
            }
            return View(meperform);
        }

        //
        // POST: /MEPERFORM/Edit/5

        [HttpPost]
        public ActionResult Edit(MEPERFORM meperform)
        {
            if (ModelState.IsValid)
            {
                db.MEPERFORMs.Attach(meperform);
                db.ObjectStateManager.ChangeObjectState(meperform, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meperform);
        }

        //
        // GET: /MEPERFORM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MEPERFORM meperform = db.MEPERFORMs.Single(m => m.PK == id);
            if (meperform == null)
            {
                return HttpNotFound();
            }
            return View(meperform);
        }

        //
        // POST: /MEPERFORM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MEPERFORM meperform = db.MEPERFORMs.Single(m => m.PK == id);
            db.MEPERFORMs.DeleteObject(meperform);
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