using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSJOBController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSJOB/

        public ActionResult Index()
        {
            return View(db.PMSJOBs.ToList());
        }

        //
        // GET: /PMSJOB/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSJOB pmsjob = db.PMSJOBs.Single(p => p.PK == id);
            if (pmsjob == null)
            {
                return HttpNotFound();
            }
            return View(pmsjob);
        }

        //
        // GET: /PMSJOB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSJOB/Create

        [HttpPost]
        public ActionResult Create(PMSJOB pmsjob)
        {
            if (ModelState.IsValid)
            {
                db.PMSJOBs.AddObject(pmsjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmsjob);
        }

        //
        // GET: /PMSJOB/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSJOB pmsjob = db.PMSJOBs.Single(p => p.PK == id);
            if (pmsjob == null)
            {
                return HttpNotFound();
            }
            return View(pmsjob);
        }

        //
        // POST: /PMSJOB/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSJOB pmsjob)
        {
            if (ModelState.IsValid)
            {
                db.PMSJOBs.Attach(pmsjob);
                db.ObjectStateManager.ChangeObjectState(pmsjob, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmsjob);
        }

        //
        // GET: /PMSJOB/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSJOB pmsjob = db.PMSJOBs.Single(p => p.PK == id);
            if (pmsjob == null)
            {
                return HttpNotFound();
            }
            return View(pmsjob);
        }

        //
        // POST: /PMSJOB/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSJOB pmsjob = db.PMSJOBs.Single(p => p.PK == id);
            db.PMSJOBs.DeleteObject(pmsjob);
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