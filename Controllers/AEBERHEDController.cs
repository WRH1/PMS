using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AEBERHEDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AEBERHED/

        public ActionResult Index()
        {
            return View(db.AEBERHEDs.ToList());
        }

        //
        // GET: /AEBERHED/Details/5

        public ActionResult Details(int id = 0)
        {
            AEBERHED aeberhed = db.AEBERHEDs.Single(a => a.PK == id);
            if (aeberhed == null)
            {
                return HttpNotFound();
            }
            return View(aeberhed);
        }

        //
        // GET: /AEBERHED/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AEBERHED/Create

        [HttpPost]
        public ActionResult Create(AEBERHED aeberhed)
        {
            if (ModelState.IsValid)
            {
                db.AEBERHEDs.AddObject(aeberhed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aeberhed);
        }

        //
        // GET: /AEBERHED/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AEBERHED aeberhed = db.AEBERHEDs.Single(a => a.PK == id);
            if (aeberhed == null)
            {
                return HttpNotFound();
            }
            return View(aeberhed);
        }

        //
        // POST: /AEBERHED/Edit/5

        [HttpPost]
        public ActionResult Edit(AEBERHED aeberhed)
        {
            if (ModelState.IsValid)
            {
                db.AEBERHEDs.Attach(aeberhed);
                db.ObjectStateManager.ChangeObjectState(aeberhed, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aeberhed);
        }

        //
        // GET: /AEBERHED/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AEBERHED aeberhed = db.AEBERHEDs.Single(a => a.PK == id);
            if (aeberhed == null)
            {
                return HttpNotFound();
            }
            return View(aeberhed);
        }

        //
        // POST: /AEBERHED/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AEBERHED aeberhed = db.AEBERHEDs.Single(a => a.PK == id);
            db.AEBERHEDs.DeleteObject(aeberhed);
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