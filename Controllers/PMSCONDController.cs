using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSCONDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSCOND/

        public ActionResult Index()
        {
            return View(db.PMSCONDs.ToList());
        }

        //
        // GET: /PMSCOND/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSCOND pmscond = db.PMSCONDs.Single(p => p.PK == id);
            if (pmscond == null)
            {
                return HttpNotFound();
            }
            return View(pmscond);
        }

        //
        // GET: /PMSCOND/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSCOND/Create

        [HttpPost]
        public ActionResult Create(PMSCOND pmscond)
        {
            if (ModelState.IsValid)
            {
                db.PMSCONDs.AddObject(pmscond);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmscond);
        }

        //
        // GET: /PMSCOND/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSCOND pmscond = db.PMSCONDs.Single(p => p.PK == id);
            if (pmscond == null)
            {
                return HttpNotFound();
            }
            return View(pmscond);
        }

        //
        // POST: /PMSCOND/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSCOND pmscond)
        {
            if (ModelState.IsValid)
            {
                db.PMSCONDs.Attach(pmscond);
                db.ObjectStateManager.ChangeObjectState(pmscond, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmscond);
        }

        //
        // GET: /PMSCOND/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSCOND pmscond = db.PMSCONDs.Single(p => p.PK == id);
            if (pmscond == null)
            {
                return HttpNotFound();
            }
            return View(pmscond);
        }

        //
        // POST: /PMSCOND/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSCOND pmscond = db.PMSCONDs.Single(p => p.PK == id);
            db.PMSCONDs.DeleteObject(pmscond);
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