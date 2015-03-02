using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MECRSHEDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MECRSHED/

        public ActionResult Index()
        {
            return View(db.MECRSHEDs.ToList());
        }

        //
        // GET: /MECRSHED/Details/5

        public ActionResult Details(int id = 0)
        {
            MECRSHED mecrshed = db.MECRSHEDs.Single(m => m.PK == id);
            if (mecrshed == null)
            {
                return HttpNotFound();
            }
            return View(mecrshed);
        }

        //
        // GET: /MECRSHED/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MECRSHED/Create

        [HttpPost]
        public ActionResult Create(MECRSHED mecrshed)
        {
            if (ModelState.IsValid)
            {
                db.MECRSHEDs.AddObject(mecrshed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mecrshed);
        }

        //
        // GET: /MECRSHED/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MECRSHED mecrshed = db.MECRSHEDs.Single(m => m.PK == id);
            if (mecrshed == null)
            {
                return HttpNotFound();
            }
            return View(mecrshed);
        }

        //
        // POST: /MECRSHED/Edit/5

        [HttpPost]
        public ActionResult Edit(MECRSHED mecrshed)
        {
            if (ModelState.IsValid)
            {
                db.MECRSHEDs.Attach(mecrshed);
                db.ObjectStateManager.ChangeObjectState(mecrshed, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mecrshed);
        }

        //
        // GET: /MECRSHED/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MECRSHED mecrshed = db.MECRSHEDs.Single(m => m.PK == id);
            if (mecrshed == null)
            {
                return HttpNotFound();
            }
            return View(mecrshed);
        }

        //
        // POST: /MECRSHED/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MECRSHED mecrshed = db.MECRSHEDs.Single(m => m.PK == id);
            db.MECRSHEDs.DeleteObject(mecrshed);
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