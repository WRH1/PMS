using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class AEPERDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /AEPERDETL/

        public ActionResult Index()
        {
            return View(db.AEPERDETLs.ToList());
        }

        //
        // GET: /AEPERDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            AEPERDETL aeperdetl = db.AEPERDETLs.Single(a => a.PK == id);
            if (aeperdetl == null)
            {
                return HttpNotFound();
            }
            return View(aeperdetl);
        }

        //
        // GET: /AEPERDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AEPERDETL/Create

        [HttpPost]
        public ActionResult Create(AEPERDETL aeperdetl)
        {
            if (ModelState.IsValid)
            {
                db.AEPERDETLs.AddObject(aeperdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aeperdetl);
        }

        //
        // GET: /AEPERDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            AEPERDETL aeperdetl = db.AEPERDETLs.Single(a => a.PK == id);
            if (aeperdetl == null)
            {
                return HttpNotFound();
            }
            return View(aeperdetl);
        }

        //
        // POST: /AEPERDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(AEPERDETL aeperdetl)
        {
            if (ModelState.IsValid)
            {
                db.AEPERDETLs.Attach(aeperdetl);
                db.ObjectStateManager.ChangeObjectState(aeperdetl, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aeperdetl);
        }

        //
        // GET: /AEPERDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            AEPERDETL aeperdetl = db.AEPERDETLs.Single(a => a.PK == id);
            if (aeperdetl == null)
            {
                return HttpNotFound();
            }
            return View(aeperdetl);
        }

        //
        // POST: /AEPERDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            AEPERDETL aeperdetl = db.AEPERDETLs.Single(a => a.PK == id);
            db.AEPERDETLs.DeleteObject(aeperdetl);
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