using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MESPDTLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MESPDTL/

        public ActionResult Index()
        {
            return View(db.MESPDTLs.ToList());
        }

        //
        // GET: /MESPDTL/Details/5

        public ActionResult Details(int id = 0)
        {
            MESPDTL mespdtl = db.MESPDTLs.Single(m => m.PK == id);
            if (mespdtl == null)
            {
                return HttpNotFound();
            }
            return View(mespdtl);
        }

        //
        // GET: /MESPDTL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MESPDTL/Create

        [HttpPost]
        public ActionResult Create(MESPDTL mespdtl)
        {
            if (ModelState.IsValid)
            {
                db.MESPDTLs.AddObject(mespdtl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mespdtl);
        }

        //
        // GET: /MESPDTL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MESPDTL mespdtl = db.MESPDTLs.Single(m => m.PK == id);
            if (mespdtl == null)
            {
                return HttpNotFound();
            }
            return View(mespdtl);
        }

        //
        // POST: /MESPDTL/Edit/5

        [HttpPost]
        public ActionResult Edit(MESPDTL mespdtl)
        {
            if (ModelState.IsValid)
            {
                db.MESPDTLs.Attach(mespdtl);
                db.ObjectStateManager.ChangeObjectState(mespdtl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mespdtl);
        }

        //
        // GET: /MESPDTL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MESPDTL mespdtl = db.MESPDTLs.Single(m => m.PK == id);
            if (mespdtl == null)
            {
                return HttpNotFound();
            }
            return View(mespdtl);
        }

        //
        // POST: /MESPDTL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MESPDTL mespdtl = db.MESPDTLs.Single(m => m.PK == id);
            db.MESPDTLs.DeleteObject(mespdtl);
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