using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINMANUFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINMANUF/

        public ActionResult Index()
        {
            return View(db.MAINMANUFs.ToList());
        }

        //
        // GET: /MAINMANUF/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINMANUF mainmanuf = db.MAINMANUFs.Single(m => m.PK == id);
            if (mainmanuf == null)
            {
                return HttpNotFound();
            }
            return View(mainmanuf);
        }

        //
        // GET: /MAINMANUF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINMANUF/Create

        [HttpPost]
        public ActionResult Create(MAINMANUF mainmanuf)
        {
            if (ModelState.IsValid)
            {
                db.MAINMANUFs.AddObject(mainmanuf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainmanuf);
        }

        //
        // GET: /MAINMANUF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINMANUF mainmanuf = db.MAINMANUFs.Single(m => m.PK == id);
            if (mainmanuf == null)
            {
                return HttpNotFound();
            }
            return View(mainmanuf);
        }

        //
        // POST: /MAINMANUF/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINMANUF mainmanuf)
        {
            if (ModelState.IsValid)
            {
                db.MAINMANUFs.Attach(mainmanuf);
                db.ObjectStateManager.ChangeObjectState(mainmanuf, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainmanuf);
        }

        //
        // GET: /MAINMANUF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINMANUF mainmanuf = db.MAINMANUFs.Single(m => m.PK == id);
            if (mainmanuf == null)
            {
                return HttpNotFound();
            }
            return View(mainmanuf);
        }

        //
        // POST: /MAINMANUF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINMANUF mainmanuf = db.MAINMANUFs.Single(m => m.PK == id);
            db.MAINMANUFs.DeleteObject(mainmanuf);
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