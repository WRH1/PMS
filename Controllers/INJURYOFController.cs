using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INJURYOFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INJURYOF/

        public ActionResult Index()
        {
            return View(db.INJURYOFs.ToList());
        }

        //
        // GET: /INJURYOF/Details/5

        public ActionResult Details(int id = 0)
        {
            INJURYOF injuryof = db.INJURYOFs.Single(i => i.PK == id);
            if (injuryof == null)
            {
                return HttpNotFound();
            }
            return View(injuryof);
        }

        //
        // GET: /INJURYOF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INJURYOF/Create

        [HttpPost]
        public ActionResult Create(INJURYOF injuryof)
        {
            if (ModelState.IsValid)
            {
                db.INJURYOFs.AddObject(injuryof);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(injuryof);
        }

        //
        // GET: /INJURYOF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INJURYOF injuryof = db.INJURYOFs.Single(i => i.PK == id);
            if (injuryof == null)
            {
                return HttpNotFound();
            }
            return View(injuryof);
        }

        //
        // POST: /INJURYOF/Edit/5

        [HttpPost]
        public ActionResult Edit(INJURYOF injuryof)
        {
            if (ModelState.IsValid)
            {
                db.INJURYOFs.Attach(injuryof);
                db.ObjectStateManager.ChangeObjectState(injuryof, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(injuryof);
        }

        //
        // GET: /INJURYOF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INJURYOF injuryof = db.INJURYOFs.Single(i => i.PK == id);
            if (injuryof == null)
            {
                return HttpNotFound();
            }
            return View(injuryof);
        }

        //
        // POST: /INJURYOF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INJURYOF injuryof = db.INJURYOFs.Single(i => i.PK == id);
            db.INJURYOFs.DeleteObject(injuryof);
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