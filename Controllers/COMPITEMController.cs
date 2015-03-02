using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class COMPITEMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /COMPITEM/

        public ActionResult Index()
        {
            return View(db.COMPITEMs.ToList());
        }

        //
        // GET: /COMPITEM/Details/5

        public ActionResult Details(int id = 0)
        {
            COMPITEM compitem = db.COMPITEMs.Single(c => c.PK == id);
            if (compitem == null)
            {
                return HttpNotFound();
            }
            return View(compitem);
        }

        //
        // GET: /COMPITEM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /COMPITEM/Create

        [HttpPost]
        public ActionResult Create(COMPITEM compitem)
        {
            if (ModelState.IsValid)
            {
                db.COMPITEMs.AddObject(compitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(compitem);
        }

        //
        // GET: /COMPITEM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            COMPITEM compitem = db.COMPITEMs.Single(c => c.PK == id);
            if (compitem == null)
            {
                return HttpNotFound();
            }
            return View(compitem);
        }

        //
        // POST: /COMPITEM/Edit/5

        [HttpPost]
        public ActionResult Edit(COMPITEM compitem)
        {
            if (ModelState.IsValid)
            {
                db.COMPITEMs.Attach(compitem);
                db.ObjectStateManager.ChangeObjectState(compitem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(compitem);
        }

        //
        // GET: /COMPITEM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            COMPITEM compitem = db.COMPITEMs.Single(c => c.PK == id);
            if (compitem == null)
            {
                return HttpNotFound();
            }
            return View(compitem);
        }

        //
        // POST: /COMPITEM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            COMPITEM compitem = db.COMPITEMs.Single(c => c.PK == id);
            db.COMPITEMs.DeleteObject(compitem);
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