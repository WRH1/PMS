using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class JOBPARTSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /JOBPARTS/

        public ActionResult Index()
        {
            return View(db.JOBPARTS.ToList());
        }

        //
        // GET: /JOBPARTS/Details/5

        public ActionResult Details(int id = 0)
        {
            JOBPART jobpart = db.JOBPARTS.Single(j => j.PK == id);
            if (jobpart == null)
            {
                return HttpNotFound();
            }
            return View(jobpart);
        }

        //
        // GET: /JOBPARTS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /JOBPARTS/Create

        [HttpPost]
        public ActionResult Create(JOBPART jobpart)
        {
            if (ModelState.IsValid)
            {
                db.JOBPARTS.AddObject(jobpart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobpart);
        }

        //
        // GET: /JOBPARTS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            JOBPART jobpart = db.JOBPARTS.Single(j => j.PK == id);
            if (jobpart == null)
            {
                return HttpNotFound();
            }
            return View(jobpart);
        }

        //
        // POST: /JOBPARTS/Edit/5

        [HttpPost]
        public ActionResult Edit(JOBPART jobpart)
        {
            if (ModelState.IsValid)
            {
                db.JOBPARTS.Attach(jobpart);
                db.ObjectStateManager.ChangeObjectState(jobpart, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobpart);
        }

        //
        // GET: /JOBPARTS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            JOBPART jobpart = db.JOBPARTS.Single(j => j.PK == id);
            if (jobpart == null)
            {
                return HttpNotFound();
            }
            return View(jobpart);
        }

        //
        // POST: /JOBPARTS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            JOBPART jobpart = db.JOBPARTS.Single(j => j.PK == id);
            db.JOBPARTS.DeleteObject(jobpart);
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