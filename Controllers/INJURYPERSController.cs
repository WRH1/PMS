using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INJURYPERSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INJURYPERS/

        public ActionResult Index()
        {
            return View(db.INJURYPERS.ToList());
        }

        //
        // GET: /INJURYPERS/Details/5

        public ActionResult Details(int id = 0)
        {
            INJURYPER injuryper = db.INJURYPERS.Single(i => i.PK == id);
            if (injuryper == null)
            {
                return HttpNotFound();
            }
            return View(injuryper);
        }

        //
        // GET: /INJURYPERS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INJURYPERS/Create

        [HttpPost]
        public ActionResult Create(INJURYPER injuryper)
        {
            if (ModelState.IsValid)
            {
                db.INJURYPERS.AddObject(injuryper);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(injuryper);
        }

        //
        // GET: /INJURYPERS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INJURYPER injuryper = db.INJURYPERS.Single(i => i.PK == id);
            if (injuryper == null)
            {
                return HttpNotFound();
            }
            return View(injuryper);
        }

        //
        // POST: /INJURYPERS/Edit/5

        [HttpPost]
        public ActionResult Edit(INJURYPER injuryper)
        {
            if (ModelState.IsValid)
            {
                db.INJURYPERS.Attach(injuryper);
                db.ObjectStateManager.ChangeObjectState(injuryper, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(injuryper);
        }

        //
        // GET: /INJURYPERS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INJURYPER injuryper = db.INJURYPERS.Single(i => i.PK == id);
            if (injuryper == null)
            {
                return HttpNotFound();
            }
            return View(injuryper);
        }

        //
        // POST: /INJURYPERS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INJURYPER injuryper = db.INJURYPERS.Single(i => i.PK == id);
            db.INJURYPERS.DeleteObject(injuryper);
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