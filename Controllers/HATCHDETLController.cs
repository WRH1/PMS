using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class HATCHDETLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /HATCHDETL/

        public ActionResult Index()
        {
            return View(db.HATCHDETLs.ToList());
        }

        //
        // GET: /HATCHDETL/Details/5

        public ActionResult Details(int id = 0)
        {
            HATCHDETL hatchdetl = db.HATCHDETLs.Single(h => h.PK == id);
            if (hatchdetl == null)
            {
                return HttpNotFound();
            }
            return View(hatchdetl);
        }

        //
        // GET: /HATCHDETL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HATCHDETL/Create

        [HttpPost]
        public ActionResult Create(HATCHDETL hatchdetl)
        {
            if (ModelState.IsValid)
            {
                db.HATCHDETLs.AddObject(hatchdetl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hatchdetl);
        }

        //
        // GET: /HATCHDETL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            HATCHDETL hatchdetl = db.HATCHDETLs.Single(h => h.PK == id);
            if (hatchdetl == null)
            {
                return HttpNotFound();
            }
            return View(hatchdetl);
        }

        //
        // POST: /HATCHDETL/Edit/5

        [HttpPost]
        public ActionResult Edit(HATCHDETL hatchdetl)
        {
            if (ModelState.IsValid)
            {
                db.HATCHDETLs.Attach(hatchdetl);
                db.ObjectStateManager.ChangeObjectState(hatchdetl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hatchdetl);
        }

        //
        // GET: /HATCHDETL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            HATCHDETL hatchdetl = db.HATCHDETLs.Single(h => h.PK == id);
            if (hatchdetl == null)
            {
                return HttpNotFound();
            }
            return View(hatchdetl);
        }

        //
        // POST: /HATCHDETL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            HATCHDETL hatchdetl = db.HATCHDETLs.Single(h => h.PK == id);
            db.HATCHDETLs.DeleteObject(hatchdetl);
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