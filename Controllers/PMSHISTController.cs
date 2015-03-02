using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSHISTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSHIST/

        public ActionResult Index()
        {
            return View(db.PMSHISTs.ToList());
        }

        //
        // GET: /PMSHIST/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSHIST pmshist = db.PMSHISTs.Single(p => p.PK == id);
            if (pmshist == null)
            {
                return HttpNotFound();
            }
            return View(pmshist);
        }

        //
        // GET: /PMSHIST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSHIST/Create

        [HttpPost]
        public ActionResult Create(PMSHIST pmshist)
        {
            if (ModelState.IsValid)
            {
                db.PMSHISTs.AddObject(pmshist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmshist);
        }

        //
        // GET: /PMSHIST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSHIST pmshist = db.PMSHISTs.Single(p => p.PK == id);
            if (pmshist == null)
            {
                return HttpNotFound();
            }
            return View(pmshist);
        }

        //
        // POST: /PMSHIST/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSHIST pmshist)
        {
            if (ModelState.IsValid)
            {
                db.PMSHISTs.Attach(pmshist);
                db.ObjectStateManager.ChangeObjectState(pmshist, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmshist);
        }

        //
        // GET: /PMSHIST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSHIST pmshist = db.PMSHISTs.Single(p => p.PK == id);
            if (pmshist == null)
            {
                return HttpNotFound();
            }
            return View(pmshist);
        }

        //
        // POST: /PMSHIST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSHIST pmshist = db.PMSHISTs.Single(p => p.PK == id);
            db.PMSHISTs.DeleteObject(pmshist);
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