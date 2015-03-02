using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INCIDENTPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INCIDENTPIC/

        public ActionResult Index()
        {
            return View(db.INCIDENTPICs.ToList());
        }

        //
        // GET: /INCIDENTPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            INCIDENTPIC incidentpic = db.INCIDENTPICs.Single(i => i.PK == id);
            if (incidentpic == null)
            {
                return HttpNotFound();
            }
            return View(incidentpic);
        }

        //
        // GET: /INCIDENTPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INCIDENTPIC/Create

        [HttpPost]
        public ActionResult Create(INCIDENTPIC incidentpic)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTPICs.AddObject(incidentpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incidentpic);
        }

        //
        // GET: /INCIDENTPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INCIDENTPIC incidentpic = db.INCIDENTPICs.Single(i => i.PK == id);
            if (incidentpic == null)
            {
                return HttpNotFound();
            }
            return View(incidentpic);
        }

        //
        // POST: /INCIDENTPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(INCIDENTPIC incidentpic)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTPICs.Attach(incidentpic);
                db.ObjectStateManager.ChangeObjectState(incidentpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incidentpic);
        }

        //
        // GET: /INCIDENTPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INCIDENTPIC incidentpic = db.INCIDENTPICs.Single(i => i.PK == id);
            if (incidentpic == null)
            {
                return HttpNotFound();
            }
            return View(incidentpic);
        }

        //
        // POST: /INCIDENTPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INCIDENTPIC incidentpic = db.INCIDENTPICs.Single(i => i.PK == id);
            db.INCIDENTPICs.DeleteObject(incidentpic);
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