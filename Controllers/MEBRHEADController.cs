using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MEBRHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MEBRHEAD/

        public ActionResult Index()
        {
            return View(db.MEBRHEADs.ToList());
        }

        //
        // GET: /MEBRHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            MEBRHEAD mebrhead = db.MEBRHEADs.Single(m => m.PK == id);
            if (mebrhead == null)
            {
                return HttpNotFound();
            }
            return View(mebrhead);
        }

        //
        // GET: /MEBRHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MEBRHEAD/Create

        [HttpPost]
        public ActionResult Create(MEBRHEAD mebrhead)
        {
            if (ModelState.IsValid)
            {
                db.MEBRHEADs.AddObject(mebrhead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mebrhead);
        }

        //
        // GET: /MEBRHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MEBRHEAD mebrhead = db.MEBRHEADs.Single(m => m.PK == id);
            if (mebrhead == null)
            {
                return HttpNotFound();
            }
            return View(mebrhead);
        }

        //
        // POST: /MEBRHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(MEBRHEAD mebrhead)
        {
            if (ModelState.IsValid)
            {
                db.MEBRHEADs.Attach(mebrhead);
                db.ObjectStateManager.ChangeObjectState(mebrhead, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mebrhead);
        }

        //
        // GET: /MEBRHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MEBRHEAD mebrhead = db.MEBRHEADs.Single(m => m.PK == id);
            if (mebrhead == null)
            {
                return HttpNotFound();
            }
            return View(mebrhead);
        }

        //
        // POST: /MEBRHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MEBRHEAD mebrhead = db.MEBRHEADs.Single(m => m.PK == id);
            db.MEBRHEADs.DeleteObject(mebrhead);
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