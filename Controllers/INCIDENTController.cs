using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INCIDENTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INCIDENT/

        public ActionResult Index()
        {
            return View(db.INCIDENTs.ToList());
        }

        //
        // GET: /INCIDENT/Details/5

        public ActionResult Details(int id = 0)
        {
            INCIDENT incident = db.INCIDENTs.Single(i => i.PK == id);
            if (incident == null)
            {
                return HttpNotFound();
            }
            return View(incident);
        }

        //
        // GET: /INCIDENT/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INCIDENT/Create

        [HttpPost]
        public ActionResult Create(INCIDENT incident)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTs.AddObject(incident);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incident);
        }

        //
        // GET: /INCIDENT/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INCIDENT incident = db.INCIDENTs.Single(i => i.PK == id);
            if (incident == null)
            {
                return HttpNotFound();
            }
            return View(incident);
        }

        //
        // POST: /INCIDENT/Edit/5

        [HttpPost]
        public ActionResult Edit(INCIDENT incident)
        {
            if (ModelState.IsValid)
            {
                db.INCIDENTs.Attach(incident);
                db.ObjectStateManager.ChangeObjectState(incident, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incident);
        }

        //
        // GET: /INCIDENT/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INCIDENT incident = db.INCIDENTs.Single(i => i.PK == id);
            if (incident == null)
            {
                return HttpNotFound();
            }
            return View(incident);
        }

        //
        // POST: /INCIDENT/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INCIDENT incident = db.INCIDENTs.Single(i => i.PK == id);
            db.INCIDENTs.DeleteObject(incident);
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