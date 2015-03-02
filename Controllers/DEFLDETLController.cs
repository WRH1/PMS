using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFLDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFLDETL/

        public ActionResult Index()
        {
            return View(db.DEFLDETLs.ToList());
        }

        //
        // GET: /DEFLDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFLDETL defldetl = db.DEFLDETLs.Single(d => d.PK == id);
            if (defldetl == null)
            {
                return HttpNotFound();
            }
            return View(defldetl);
        }

        //
        // GET: /DEFLDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFLDETL/Create

        [HttpPost]
        public ActionResult Create(DEFLDETL defldetl)
        {
            if (ModelState.IsValid)
            {
                db.DEFLDETLs.AddObject(defldetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defldetl);
        }

        //
        // GET: /DEFLDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFLDETL defldetl = db.DEFLDETLs.Single(d => d.PK == id);
            if (defldetl == null)
            {
                return HttpNotFound();
            }
            return View(defldetl);
        }

        //
        // POST: /DEFLDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFLDETL defldetl)
        {
            if (ModelState.IsValid)
            {
                db.DEFLDETLs.Attach(defldetl);
                db.ObjectStateManager.ChangeObjectState(defldetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defldetl);
        }

        //
        // GET: /DEFLDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFLDETL defldetl = db.DEFLDETLs.Single(d => d.PK == id);
            if (defldetl == null)
            {
                return HttpNotFound();
            }
            return View(defldetl);
        }

        //
        // POST: /DEFLDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFLDETL defldetl = db.DEFLDETLs.Single(d => d.PK == id);
            db.DEFLDETLs.DeleteObject(defldetl);
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