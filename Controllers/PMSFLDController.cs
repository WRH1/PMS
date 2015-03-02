using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSFLDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSFLD/

        public ActionResult Index()
        {
            return View(db.PMSFLDs.ToList());
        }

        //
        // GET: /PMSFLD/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSFLD pmsfld = db.PMSFLDs.Single(p => p.PK == id);
            if (pmsfld == null)
            {
                return HttpNotFound();
            }
            return View(pmsfld);
        }

        //
        // GET: /PMSFLD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSFLD/Create

        [HttpPost]
        public ActionResult Create(PMSFLD pmsfld)
        {
            if (ModelState.IsValid)
            {
                db.PMSFLDs.AddObject(pmsfld);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmsfld);
        }

        //
        // GET: /PMSFLD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSFLD pmsfld = db.PMSFLDs.Single(p => p.PK == id);
            if (pmsfld == null)
            {
                return HttpNotFound();
            }
            return View(pmsfld);
        }

        //
        // POST: /PMSFLD/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSFLD pmsfld)
        {
            if (ModelState.IsValid)
            {
                db.PMSFLDs.Attach(pmsfld);
                db.ObjectStateManager.ChangeObjectState(pmsfld, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmsfld);
        }

        //
        // GET: /PMSFLD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSFLD pmsfld = db.PMSFLDs.Single(p => p.PK == id);
            if (pmsfld == null)
            {
                return HttpNotFound();
            }
            return View(pmsfld);
        }

        //
        // POST: /PMSFLD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSFLD pmsfld = db.PMSFLDs.Single(p => p.PK == id);
            db.PMSFLDs.DeleteObject(pmsfld);
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