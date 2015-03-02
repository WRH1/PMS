using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class HATCHHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /HATCHHEAD/

        public ActionResult Index()
        {
            return View(db.HATCHHEADs.ToList());
        }

        //
        // GET: /HATCHHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            HATCHHEAD hatchhead = db.HATCHHEADs.Single(h => h.PK == id);
            if (hatchhead == null)
            {
                return HttpNotFound();
            }
            return View(hatchhead);
        }

        //
        // GET: /HATCHHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HATCHHEAD/Create

        [HttpPost]
        public ActionResult Create(HATCHHEAD hatchhead)
        {
            if (ModelState.IsValid)
            {
                db.HATCHHEADs.AddObject(hatchhead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hatchhead);
        }

        //
        // GET: /HATCHHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            HATCHHEAD hatchhead = db.HATCHHEADs.Single(h => h.PK == id);
            if (hatchhead == null)
            {
                return HttpNotFound();
            }
            return View(hatchhead);
        }

        //
        // POST: /HATCHHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(HATCHHEAD hatchhead)
        {
            if (ModelState.IsValid)
            {
                db.HATCHHEADs.Attach(hatchhead);
                db.ObjectStateManager.ChangeObjectState(hatchhead, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hatchhead);
        }

        //
        // GET: /HATCHHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            HATCHHEAD hatchhead = db.HATCHHEADs.Single(h => h.PK == id);
            if (hatchhead == null)
            {
                return HttpNotFound();
            }
            return View(hatchhead);
        }

        //
        // POST: /HATCHHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            HATCHHEAD hatchhead = db.HATCHHEADs.Single(h => h.PK == id);
            db.HATCHHEADs.DeleteObject(hatchhead);
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