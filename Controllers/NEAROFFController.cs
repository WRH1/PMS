using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class NEAROFFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /NEAROFF/

        public ActionResult Index()
        {
            return View(db.NEAROFFs.ToList());
        }

        //
        // GET: /NEAROFF/Details/5

        public ActionResult Details(int id = 0)
        {
            NEAROFF nearoff = db.NEAROFFs.Single(n => n.PK == id);
            if (nearoff == null)
            {
                return HttpNotFound();
            }
            return View(nearoff);
        }

        //
        // GET: /NEAROFF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NEAROFF/Create

        [HttpPost]
        public ActionResult Create(NEAROFF nearoff)
        {
            if (ModelState.IsValid)
            {
                db.NEAROFFs.AddObject(nearoff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nearoff);
        }

        //
        // GET: /NEAROFF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NEAROFF nearoff = db.NEAROFFs.Single(n => n.PK == id);
            if (nearoff == null)
            {
                return HttpNotFound();
            }
            return View(nearoff);
        }

        //
        // POST: /NEAROFF/Edit/5

        [HttpPost]
        public ActionResult Edit(NEAROFF nearoff)
        {
            if (ModelState.IsValid)
            {
                db.NEAROFFs.Attach(nearoff);
                db.ObjectStateManager.ChangeObjectState(nearoff, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nearoff);
        }

        //
        // GET: /NEAROFF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NEAROFF nearoff = db.NEAROFFs.Single(n => n.PK == id);
            if (nearoff == null)
            {
                return HttpNotFound();
            }
            return View(nearoff);
        }

        //
        // POST: /NEAROFF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NEAROFF nearoff = db.NEAROFFs.Single(n => n.PK == id);
            db.NEAROFFs.DeleteObject(nearoff);
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