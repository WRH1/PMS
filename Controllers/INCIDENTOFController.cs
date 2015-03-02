using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INCIDENTOFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INCIDENTOF/

        public ActionResult Index()
        {
            return View(db.INCIDENTOFs.ToList());
        }

        //
        // GET: /INCIDENTOF/Details/5

        public ActionResult Details(int id = 0)
        {
            INCIDENTOF incidentof = db.INCIDENTOFs.Single(i => i.PK == id);
            if (incidentof == null)
            {
                return HttpNotFound();
            }
            return View(incidentof);
        }

        //
        // GET: /INCIDENTOF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INCIDENTOF/Create

        [HttpPost]
        public ActionResult Create(INCIDENTOF incidentof)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTOFs.AddObject(incidentof);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incidentof);
        }

        //
        // GET: /INCIDENTOF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INCIDENTOF incidentof = db.INCIDENTOFs.Single(i => i.PK == id);
            if (incidentof == null)
            {
                return HttpNotFound();
            }
            return View(incidentof);
        }

        //
        // POST: /INCIDENTOF/Edit/5

        [HttpPost]
        public ActionResult Edit(INCIDENTOF incidentof)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTOFs.Attach(incidentof);
                db.ObjectStateManager.ChangeObjectState(incidentof, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incidentof);
        }

        //
        // GET: /INCIDENTOF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INCIDENTOF incidentof = db.INCIDENTOFs.Single(i => i.PK == id);
            if (incidentof == null)
            {
                return HttpNotFound();
            }
            return View(incidentof);
        }

        //
        // POST: /INCIDENTOF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INCIDENTOF incidentof = db.INCIDENTOFs.Single(i => i.PK == id);
            db.INCIDENTOFs.DeleteObject(incidentof);
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