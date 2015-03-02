using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class GROOVPROF_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /GROOVPROF_INSP/

        public ActionResult Index()
        {
            return View(db.GROOVPROF_INSP.ToList());
        }

        //
        // GET: /GROOVPROF_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            GROOVPROF_INSP groovprof_insp = db.GROOVPROF_INSP.Single(g => g.PK == id);
            if (groovprof_insp == null)
            {
                return HttpNotFound();
            }
            return View(groovprof_insp);
        }

        //
        // GET: /GROOVPROF_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GROOVPROF_INSP/Create

        [HttpPost]
        public ActionResult Create(GROOVPROF_INSP groovprof_insp)
        {
            if (ModelState.IsValid)
            {
                db.GROOVPROF_INSP.AddObject(groovprof_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(groovprof_insp);
        }

        //
        // GET: /GROOVPROF_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GROOVPROF_INSP groovprof_insp = db.GROOVPROF_INSP.Single(g => g.PK == id);
            if (groovprof_insp == null)
            {
                return HttpNotFound();
            }
            return View(groovprof_insp);
        }

        //
        // POST: /GROOVPROF_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(GROOVPROF_INSP groovprof_insp)
        {
            if (ModelState.IsValid)
            {
                db.GROOVPROF_INSP.Attach(groovprof_insp);
                db.ObjectStateManager.ChangeObjectState(groovprof_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groovprof_insp);
        }

        //
        // GET: /GROOVPROF_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GROOVPROF_INSP groovprof_insp = db.GROOVPROF_INSP.Single(g => g.PK == id);
            if (groovprof_insp == null)
            {
                return HttpNotFound();
            }
            return View(groovprof_insp);
        }

        //
        // POST: /GROOVPROF_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            GROOVPROF_INSP groovprof_insp = db.GROOVPROF_INSP.Single(g => g.PK == id);
            db.GROOVPROF_INSP.DeleteObject(groovprof_insp);
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