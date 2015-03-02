using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INJURYPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INJURYPIC/

        public ActionResult Index()
        {
            return View(db.INJURYPICs.ToList());
        }

        //
        // GET: /INJURYPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            INJURYPIC injurypic = db.INJURYPICs.Single(i => i.PK == id);
            if (injurypic == null)
            {
                return HttpNotFound();
            }
            return View(injurypic);
        }

        //
        // GET: /INJURYPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INJURYPIC/Create

        [HttpPost]
        public ActionResult Create(INJURYPIC injurypic)
        {
            if (ModelState.IsValid)
            {
                db.INJURYPICs.AddObject(injurypic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(injurypic);
        }

        //
        // GET: /INJURYPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INJURYPIC injurypic = db.INJURYPICs.Single(i => i.PK == id);
            if (injurypic == null)
            {
                return HttpNotFound();
            }
            return View(injurypic);
        }

        //
        // POST: /INJURYPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(INJURYPIC injurypic)
        {
            if (ModelState.IsValid)
            {
                db.INJURYPICs.Attach(injurypic);
                db.ObjectStateManager.ChangeObjectState(injurypic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(injurypic);
        }

        //
        // GET: /INJURYPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INJURYPIC injurypic = db.INJURYPICs.Single(i => i.PK == id);
            if (injurypic == null)
            {
                return HttpNotFound();
            }
            return View(injurypic);
        }

        //
        // POST: /INJURYPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INJURYPIC injurypic = db.INJURYPICs.Single(i => i.PK == id);
            db.INJURYPICs.DeleteObject(injurypic);
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