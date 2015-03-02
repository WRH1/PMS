using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LOGBOOKController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /LOGBOOK/

        public ActionResult Index()
        {
            return View(db.LOGBOOKs.ToList());
        }

        //
        // GET: /LOGBOOK/Details/5

        public ActionResult Details(int id = 0)
        {
            LOGBOOK logbook = db.LOGBOOKs.Single(l => l.PK == id);
            if (logbook == null)
            {
                return HttpNotFound();
            }
            return View(logbook);
        }

        //
        // GET: /LOGBOOK/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LOGBOOK/Create

        [HttpPost]
        public ActionResult Create(LOGBOOK logbook)
        {
            if (ModelState.IsValid)
            {
                db.LOGBOOKs.AddObject(logbook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logbook);
        }

        //
        // GET: /LOGBOOK/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LOGBOOK logbook = db.LOGBOOKs.Single(l => l.PK == id);
            if (logbook == null)
            {
                return HttpNotFound();
            }
            return View(logbook);
        }

        //
        // POST: /LOGBOOK/Edit/5

        [HttpPost]
        public ActionResult Edit(LOGBOOK logbook)
        {
            if (ModelState.IsValid)
            {
                db.LOGBOOKs.Attach(logbook);
                db.ObjectStateManager.ChangeObjectState(logbook, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logbook);
        }

        //
        // GET: /LOGBOOK/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LOGBOOK logbook = db.LOGBOOKs.Single(l => l.PK == id);
            if (logbook == null)
            {
                return HttpNotFound();
            }
            return View(logbook);
        }

        //
        // POST: /LOGBOOK/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LOGBOOK logbook = db.LOGBOOKs.Single(l => l.PK == id);
            db.LOGBOOKs.DeleteObject(logbook);
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