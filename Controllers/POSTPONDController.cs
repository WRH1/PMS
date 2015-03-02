using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class POSTPONDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /POSTPOND/

        public ActionResult Index()
        {
            return View(db.POSTPONDs.ToList());
        }

        //
        // GET: /POSTPOND/Details/5

        public ActionResult Details(int id = 0)
        {
            POSTPOND postpond = db.POSTPONDs.Single(p => p.PK == id);
            if (postpond == null)
            {
                return HttpNotFound();
            }
            return View(postpond);
        }

        //
        // GET: /POSTPOND/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /POSTPOND/Create

        [HttpPost]
        public ActionResult Create(POSTPOND postpond)
        {
            if (ModelState.IsValid)
            {
                db.POSTPONDs.AddObject(postpond);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postpond);
        }

        //
        // GET: /POSTPOND/Edit/5

        public ActionResult Edit(int id = 0)
        {
            POSTPOND postpond = db.POSTPONDs.Single(p => p.PK == id);
            if (postpond == null)
            {
                return HttpNotFound();
            }
            return View(postpond);
        }

        //
        // POST: /POSTPOND/Edit/5

        [HttpPost]
        public ActionResult Edit(POSTPOND postpond)
        {
            if (ModelState.IsValid)
            {
                db.POSTPONDs.Attach(postpond);
                db.ObjectStateManager.ChangeObjectState(postpond, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postpond);
        }

        //
        // GET: /POSTPOND/Delete/5

        public ActionResult Delete(int id = 0)
        {
            POSTPOND postpond = db.POSTPONDs.Single(p => p.PK == id);
            if (postpond == null)
            {
                return HttpNotFound();
            }
            return View(postpond);
        }

        //
        // POST: /POSTPOND/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            POSTPOND postpond = db.POSTPONDs.Single(p => p.PK == id);
            db.POSTPONDs.DeleteObject(postpond);
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