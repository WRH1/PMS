using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class IN_LOCController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /IN_LOC/

        public ActionResult Index()
        {
            return View(db.IN_LOC.ToList());
        }

        //
        // GET: /IN_LOC/Details/5

        public ActionResult Details(int id = 0)
        {
            IN_LOC in_loc = db.IN_LOC.Single(i => i.PK == id);
            if (in_loc == null)
            {
                return HttpNotFound();
            }
            return View(in_loc);
        }

        //
        // GET: /IN_LOC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /IN_LOC/Create

        [HttpPost]
        public ActionResult Create(IN_LOC in_loc)
        {
            if (ModelState.IsValid)
            {
                db.IN_LOC.AddObject(in_loc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(in_loc);
        }

        //
        // GET: /IN_LOC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            IN_LOC in_loc = db.IN_LOC.Single(i => i.PK == id);
            if (in_loc == null)
            {
                return HttpNotFound();
            }
            return View(in_loc);
        }

        //
        // POST: /IN_LOC/Edit/5

        [HttpPost]
        public ActionResult Edit(IN_LOC in_loc)
        {
            if (ModelState.IsValid)
            {
                db.IN_LOC.Attach(in_loc);
                db.ObjectStateManager.ChangeObjectState(in_loc, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(in_loc);
        }

        //
        // GET: /IN_LOC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            IN_LOC in_loc = db.IN_LOC.Single(i => i.PK == id);
            if (in_loc == null)
            {
                return HttpNotFound();
            }
            return View(in_loc);
        }

        //
        // POST: /IN_LOC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            IN_LOC in_loc = db.IN_LOC.Single(i => i.PK == id);
            db.IN_LOC.DeleteObject(in_loc);
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