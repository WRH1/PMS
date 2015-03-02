using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DBLTITEMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DBLTITEM/

        public ActionResult Index()
        {
            return View(db.DBLTITEMs.ToList());
        }

        //
        // GET: /DBLTITEM/Details/5

        public ActionResult Details(int id = 0)
        {
            DBLTITEM dbltitem = db.DBLTITEMs.Single(d => d.PK == id);
            if (dbltitem == null)
            {
                return HttpNotFound();
            }
            return View(dbltitem);
        }

        //
        // GET: /DBLTITEM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DBLTITEM/Create

        [HttpPost]
        public ActionResult Create(DBLTITEM dbltitem)
        {
            if (ModelState.IsValid)
            {
                db.DBLTITEMs.AddObject(dbltitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbltitem);
        }

        //
        // GET: /DBLTITEM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DBLTITEM dbltitem = db.DBLTITEMs.Single(d => d.PK == id);
            if (dbltitem == null)
            {
                return HttpNotFound();
            }
            return View(dbltitem);
        }

        //
        // POST: /DBLTITEM/Edit/5

        [HttpPost]
        public ActionResult Edit(DBLTITEM dbltitem)
        {
            if (ModelState.IsValid)
            {
                db.DBLTITEMs.Attach(dbltitem);
                db.ObjectStateManager.ChangeObjectState(dbltitem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbltitem);
        }

        //
        // GET: /DBLTITEM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DBLTITEM dbltitem = db.DBLTITEMs.Single(d => d.PK == id);
            if (dbltitem == null)
            {
                return HttpNotFound();
            }
            return View(dbltitem);
        }

        //
        // POST: /DBLTITEM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DBLTITEM dbltitem = db.DBLTITEMs.Single(d => d.PK == id);
            db.DBLTITEMs.DeleteObject(dbltitem);
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