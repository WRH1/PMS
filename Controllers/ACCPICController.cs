using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ACCPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /ACCPIC/

        public ActionResult Index()
        {
            return View(db.ACCPICs.ToList());
        }

        //
        // GET: /ACCPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            ACCPIC accpic = db.ACCPICs.Single(a => a.PK == id);
            if (accpic == null)
            {
                return HttpNotFound();
            }
            return View(accpic);
        }

        //
        // GET: /ACCPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ACCPIC/Create

        [HttpPost]
        public ActionResult Create(ACCPIC accpic)
        {
            if (ModelState.IsValid)
            {
                db.ACCPICs.AddObject(accpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accpic);
        }

        //
        // GET: /ACCPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ACCPIC accpic = db.ACCPICs.Single(a => a.PK == id);
            if (accpic == null)
            {
                return HttpNotFound();
            }
            return View(accpic);
        }

        //
        // POST: /ACCPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(ACCPIC accpic)
        {
            if (ModelState.IsValid)
            {
                db.ACCPICs.Attach(accpic);
                db.ObjectStateManager.ChangeObjectState(accpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accpic);
        }

        //
        // GET: /ACCPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ACCPIC accpic = db.ACCPICs.Single(a => a.PK == id);
            if (accpic == null)
            {
                return HttpNotFound();
            }
            return View(accpic);
        }

        //
        // POST: /ACCPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ACCPIC accpic = db.ACCPICs.Single(a => a.PK == id);
            db.ACCPICs.DeleteObject(accpic);
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