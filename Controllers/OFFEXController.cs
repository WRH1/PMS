using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class OFFEXController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /OFFEX/

        public ActionResult Index()
        {
            return View(db.OFFEXes.ToList());
        }

        //
        // GET: /OFFEX/Details/5

        public ActionResult Details(int id = 0)
        {
            OFFEX offex = db.OFFEXes.Single(o => o.PK == id);
            if (offex == null)
            {
                return HttpNotFound();
            }
            return View(offex);
        }

        //
        // GET: /OFFEX/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OFFEX/Create

        [HttpPost]
        public ActionResult Create(OFFEX offex)
        {
            if (ModelState.IsValid)
            {
                db.OFFEXes.AddObject(offex);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(offex);
        }

        //
        // GET: /OFFEX/Edit/5

        public ActionResult Edit(int id = 0)
        {
            OFFEX offex = db.OFFEXes.Single(o => o.PK == id);
            if (offex == null)
            {
                return HttpNotFound();
            }
            return View(offex);
        }

        //
        // POST: /OFFEX/Edit/5

        [HttpPost]
        public ActionResult Edit(OFFEX offex)
        {
            if (ModelState.IsValid)
            {
                db.OFFEXes.Attach(offex);
                db.ObjectStateManager.ChangeObjectState(offex, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(offex);
        }

        //
        // GET: /OFFEX/Delete/5

        public ActionResult Delete(int id = 0)
        {
            OFFEX offex = db.OFFEXes.Single(o => o.PK == id);
            if (offex == null)
            {
                return HttpNotFound();
            }
            return View(offex);
        }

        //
        // POST: /OFFEX/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            OFFEX offex = db.OFFEXes.Single(o => o.PK == id);
            db.OFFEXes.DeleteObject(offex);
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