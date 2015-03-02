using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINMEGController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINMEG/

        public ActionResult Index()
        {
            return View(db.MAINMEGs.ToList());
        }

        //
        // GET: /MAINMEG/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINMEG mainmeg = db.MAINMEGs.Single(m => m.PK == id);
            if (mainmeg == null)
            {
                return HttpNotFound();
            }
            return View(mainmeg);
        }

        //
        // GET: /MAINMEG/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINMEG/Create

        [HttpPost]
        public ActionResult Create(MAINMEG mainmeg)
        {
            if (ModelState.IsValid)
            {
                db.MAINMEGs.AddObject(mainmeg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainmeg);
        }

        //
        // GET: /MAINMEG/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINMEG mainmeg = db.MAINMEGs.Single(m => m.PK == id);
            if (mainmeg == null)
            {
                return HttpNotFound();
            }
            return View(mainmeg);
        }

        //
        // POST: /MAINMEG/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINMEG mainmeg)
        {
            if (ModelState.IsValid)
            {
                db.MAINMEGs.Attach(mainmeg);
                db.ObjectStateManager.ChangeObjectState(mainmeg, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainmeg);
        }

        //
        // GET: /MAINMEG/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINMEG mainmeg = db.MAINMEGs.Single(m => m.PK == id);
            if (mainmeg == null)
            {
                return HttpNotFound();
            }
            return View(mainmeg);
        }

        //
        // POST: /MAINMEG/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINMEG mainmeg = db.MAINMEGs.Single(m => m.PK == id);
            db.MAINMEGs.DeleteObject(mainmeg);
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