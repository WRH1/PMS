using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MECRSDTLController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MECRSDTL/

        public ActionResult Index()
        {
            return View(db.MECRSDTLs.ToList());
        }

        //
        // GET: /MECRSDTL/Details/5

        public ActionResult Details(int id = 0)
        {
            MECRSDTL mecrsdtl = db.MECRSDTLs.Single(m => m.PK == id);
            if (mecrsdtl == null)
            {
                return HttpNotFound();
            }
            return View(mecrsdtl);
        }

        //
        // GET: /MECRSDTL/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MECRSDTL/Create

        [HttpPost]
        public ActionResult Create(MECRSDTL mecrsdtl)
        {
            if (ModelState.IsValid)
            {
                db.MECRSDTLs.AddObject(mecrsdtl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mecrsdtl);
        }

        //
        // GET: /MECRSDTL/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MECRSDTL mecrsdtl = db.MECRSDTLs.Single(m => m.PK == id);
            if (mecrsdtl == null)
            {
                return HttpNotFound();
            }
            return View(mecrsdtl);
        }

        //
        // POST: /MECRSDTL/Edit/5

        [HttpPost]
        public ActionResult Edit(MECRSDTL mecrsdtl)
        {
            if (ModelState.IsValid)
            {
                db.MECRSDTLs.Attach(mecrsdtl);
                db.ObjectStateManager.ChangeObjectState(mecrsdtl, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mecrsdtl);
        }

        //
        // GET: /MECRSDTL/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MECRSDTL mecrsdtl = db.MECRSDTLs.Single(m => m.PK == id);
            if (mecrsdtl == null)
            {
                return HttpNotFound();
            }
            return View(mecrsdtl);
        }

        //
        // POST: /MECRSDTL/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MECRSDTL mecrsdtl = db.MECRSDTLs.Single(m => m.PK == id);
            db.MECRSDTLs.DeleteObject(mecrsdtl);
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