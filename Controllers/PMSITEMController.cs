using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSITEMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSITEM/

        public ActionResult Index()
        {
            return View(db.PMSITEMs.ToList());
        }

        //
        // GET: /PMSITEM/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSITEM pmsitem = db.PMSITEMs.Single(p => p.PK == id);
            if (pmsitem == null)
            {
                return HttpNotFound();
            }
            return View(pmsitem);
        }

        //
        // GET: /PMSITEM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSITEM/Create

        [HttpPost]
        public ActionResult Create(PMSITEM pmsitem)
        {
            if (ModelState.IsValid)
            {
                db.PMSITEMs.AddObject(pmsitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmsitem);
        }

        //
        // GET: /PMSITEM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSITEM pmsitem = db.PMSITEMs.Single(p => p.PK == id);
            if (pmsitem == null)
            {
                return HttpNotFound();
            }
            return View(pmsitem);
        }

        //
        // POST: /PMSITEM/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSITEM pmsitem)
        {
            if (ModelState.IsValid)
            {
                db.PMSITEMs.Attach(pmsitem);
                db.ObjectStateManager.ChangeObjectState(pmsitem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmsitem);
        }

        //
        // GET: /PMSITEM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSITEM pmsitem = db.PMSITEMs.Single(p => p.PK == id);
            if (pmsitem == null)
            {
                return HttpNotFound();
            }
            return View(pmsitem);
        }

        //
        // POST: /PMSITEM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSITEM pmsitem = db.PMSITEMs.Single(p => p.PK == id);
            db.PMSITEMs.DeleteObject(pmsitem);
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