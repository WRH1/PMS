using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DRMAINController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DRMAIN/

        public ActionResult Index()
        {
            return View(db.DRMAINs.ToList());
        }

        //
        // GET: /DRMAIN/Details/5

        public ActionResult Details(int id = 0)
        {
            DRMAIN drmain = db.DRMAINs.Single(d => d.PK == id);
            if (drmain == null)
            {
                return HttpNotFound();
            }
            return View(drmain);
        }

        //
        // GET: /DRMAIN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DRMAIN/Create

        [HttpPost]
        public ActionResult Create(DRMAIN drmain)
        {
            if (ModelState.IsValid)
            {
                db.DRMAINs.AddObject(drmain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drmain);
        }

        //
        // GET: /DRMAIN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DRMAIN drmain = db.DRMAINs.Single(d => d.PK == id);
            if (drmain == null)
            {
                return HttpNotFound();
            }
            return View(drmain);
        }

        //
        // POST: /DRMAIN/Edit/5

        [HttpPost]
        public ActionResult Edit(DRMAIN drmain)
        {
            if (ModelState.IsValid)
            {
                db.DRMAINs.Attach(drmain);
                db.ObjectStateManager.ChangeObjectState(drmain, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drmain);
        }

        //
        // GET: /DRMAIN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DRMAIN drmain = db.DRMAINs.Single(d => d.PK == id);
            if (drmain == null)
            {
                return HttpNotFound();
            }
            return View(drmain);
        }

        //
        // POST: /DRMAIN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DRMAIN drmain = db.DRMAINs.Single(d => d.PK == id);
            db.DRMAINs.DeleteObject(drmain);
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