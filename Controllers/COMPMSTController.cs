using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class COMPMSTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /COMPMST/

        public ActionResult Index()
        {
            return View(db.COMPMSTs.ToList());
        }

        //
        // GET: /COMPMST/Details/5

        public ActionResult Details(int id = 0)
        {
            COMPMST compmst = db.COMPMSTs.Single(c => c.PK == id);
            if (compmst == null)
            {
                return HttpNotFound();
            }
            return View(compmst);
        }

        //
        // GET: /COMPMST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /COMPMST/Create

        [HttpPost]
        public ActionResult Create(COMPMST compmst)
        {
            if (ModelState.IsValid)
            {
                db.COMPMSTs.AddObject(compmst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compmst);
        }

        //
        // GET: /COMPMST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            COMPMST compmst = db.COMPMSTs.Single(c => c.PK == id);
            if (compmst == null)
            {
                return HttpNotFound();
            }
            return View(compmst);
        }

        //
        // POST: /COMPMST/Edit/5

        [HttpPost]
        public ActionResult Edit(COMPMST compmst)
        {
            if (ModelState.IsValid)
            {
                db.COMPMSTs.Attach(compmst);
                db.ObjectStateManager.ChangeObjectState(compmst, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compmst);
        }

        //
        // GET: /COMPMST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            COMPMST compmst = db.COMPMSTs.Single(c => c.PK == id);
            if (compmst == null)
            {
                return HttpNotFound();
            }
            return View(compmst);
        }

        //
        // POST: /COMPMST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            COMPMST compmst = db.COMPMSTs.Single(c => c.PK == id);
            db.COMPMSTs.DeleteObject(compmst);
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