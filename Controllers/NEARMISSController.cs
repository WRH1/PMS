using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class NEARMISSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /NEARMISS/

        public ActionResult Index()
        {
            return View(db.NEARMISSes.ToList());
        }

        //
        // GET: /NEARMISS/Details/5

        public ActionResult Details(int id = 0)
        {
            NEARMISS nearmiss = db.NEARMISSes.Single(n => n.PK == id);
            if (nearmiss == null)
            {
                return HttpNotFound();
            }
            return View(nearmiss);
        }

        //
        // GET: /NEARMISS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NEARMISS/Create

        [HttpPost]
        public ActionResult Create(NEARMISS nearmiss)
        {
            if (ModelState.IsValid)
            {
                db.NEARMISSes.AddObject(nearmiss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nearmiss);
        }

        //
        // GET: /NEARMISS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NEARMISS nearmiss = db.NEARMISSes.Single(n => n.PK == id);
            if (nearmiss == null)
            {
                return HttpNotFound();
            }
            return View(nearmiss);
        }

        //
        // POST: /NEARMISS/Edit/5

        [HttpPost]
        public ActionResult Edit(NEARMISS nearmiss)
        {
            if (ModelState.IsValid)
            {
                db.NEARMISSes.Attach(nearmiss);
                db.ObjectStateManager.ChangeObjectState(nearmiss, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nearmiss);
        }

        //
        // GET: /NEARMISS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NEARMISS nearmiss = db.NEARMISSes.Single(n => n.PK == id);
            if (nearmiss == null)
            {
                return HttpNotFound();
            }
            return View(nearmiss);
        }

        //
        // POST: /NEARMISS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NEARMISS nearmiss = db.NEARMISSes.Single(n => n.PK == id);
            db.NEARMISSes.DeleteObject(nearmiss);
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