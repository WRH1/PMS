using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PISTDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PISTDETL/

        public ActionResult Index()
        {
            return View(db.PISTDETLs.ToList());
        }

        //
        // GET: /PISTDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            PISTDETL pistdetl = db.PISTDETLs.Single(p => p.PK == id);
            if (pistdetl == null)
            {
                return HttpNotFound();
            }
            return View(pistdetl);
        }

        //
        // GET: /PISTDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PISTDETL/Create

        [HttpPost]
        public ActionResult Create(PISTDETL pistdetl)
        {
            if (ModelState.IsValid)
            {
                db.PISTDETLs.AddObject(pistdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pistdetl);
        }

        //
        // GET: /PISTDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PISTDETL pistdetl = db.PISTDETLs.Single(p => p.PK == id);
            if (pistdetl == null)
            {
                return HttpNotFound();
            }
            return View(pistdetl);
        }

        //
        // POST: /PISTDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(PISTDETL pistdetl)
        {
            if (ModelState.IsValid)
            {
                db.PISTDETLs.Attach(pistdetl);
                db.ObjectStateManager.ChangeObjectState(pistdetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pistdetl);
        }

        //
        // GET: /PISTDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PISTDETL pistdetl = db.PISTDETLs.Single(p => p.PK == id);
            if (pistdetl == null)
            {
                return HttpNotFound();
            }
            return View(pistdetl);
        }

        //
        // POST: /PISTDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PISTDETL pistdetl = db.PISTDETLs.Single(p => p.PK == id);
            db.PISTDETLs.DeleteObject(pistdetl);
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