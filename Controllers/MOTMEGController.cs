using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MOTMEGController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MOTMEG/

        public ActionResult Index()
        {
            return View(db.MOTMEGs.ToList());
        }

        //
        // GET: /MOTMEG/Details/5

        public ActionResult Details(int id = 0)
        {
            MOTMEG motmeg = db.MOTMEGs.Single(m => m.PK == id);
            if (motmeg == null)
            {
                return HttpNotFound();
            }
            return View(motmeg);
        }

        //
        // GET: /MOTMEG/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MOTMEG/Create

        [HttpPost]
        public ActionResult Create(MOTMEG motmeg)
        {
            if (ModelState.IsValid)
            {
                db.MOTMEGs.AddObject(motmeg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motmeg);
        }

        //
        // GET: /MOTMEG/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MOTMEG motmeg = db.MOTMEGs.Single(m => m.PK == id);
            if (motmeg == null)
            {
                return HttpNotFound();
            }
            return View(motmeg);
        }

        //
        // POST: /MOTMEG/Edit/5

        [HttpPost]
        public ActionResult Edit(MOTMEG motmeg)
        {
            if (ModelState.IsValid)
            {
                db.MOTMEGs.Attach(motmeg);
                db.ObjectStateManager.ChangeObjectState(motmeg, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motmeg);
        }

        //
        // GET: /MOTMEG/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MOTMEG motmeg = db.MOTMEGs.Single(m => m.PK == id);
            if (motmeg == null)
            {
                return HttpNotFound();
            }
            return View(motmeg);
        }

        //
        // POST: /MOTMEG/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MOTMEG motmeg = db.MOTMEGs.Single(m => m.PK == id);
            db.MOTMEGs.DeleteObject(motmeg);
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