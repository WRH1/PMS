using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class BRKDOWNController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /BRKDOWN/

        public ActionResult Index()
        {
            return View(db.BRKDOWNs.ToList());
        }

        //
        // GET: /BRKDOWN/Details/5

        public ActionResult Details(int id = 0)
        {
            BRKDOWN brkdown = db.BRKDOWNs.Single(b => b.PK == id);
            if (brkdown == null)
            {
                return HttpNotFound();
            }
            return View(brkdown);
        }

        //
        // GET: /BRKDOWN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BRKDOWN/Create

        [HttpPost]
        public ActionResult Create(BRKDOWN brkdown)
        {
            if (ModelState.IsValid)
            {
                db.BRKDOWNs.AddObject(brkdown);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brkdown);
        }

        //
        // GET: /BRKDOWN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BRKDOWN brkdown = db.BRKDOWNs.Single(b => b.PK == id);
            if (brkdown == null)
            {
                return HttpNotFound();
            }
            return View(brkdown);
        }

        //
        // POST: /BRKDOWN/Edit/5

        [HttpPost]
        public ActionResult Edit(BRKDOWN brkdown)
        {
            if (ModelState.IsValid)
            {
                db.BRKDOWNs.Attach(brkdown);
                db.ObjectStateManager.ChangeObjectState(brkdown, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brkdown);
        }

        //
        // GET: /BRKDOWN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BRKDOWN brkdown = db.BRKDOWNs.Single(b => b.PK == id);
            if (brkdown == null)
            {
                return HttpNotFound();
            }
            return View(brkdown);
        }

        //
        // POST: /BRKDOWN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BRKDOWN brkdown = db.BRKDOWNs.Single(b => b.PK == id);
            db.BRKDOWNs.DeleteObject(brkdown);
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