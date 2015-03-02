using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINITEMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINITEM/

        public ActionResult Index()
        {
            return View(db.MAINITEMs.ToList());
        }

        //
        // GET: /MAINITEM/Details/5

        public ActionResult Details(string id = null)
        {
            MAINITEM mainitem = db.MAINITEMs.Single(m => m.MAINCODE == id);
            if (mainitem == null)
            {
                return HttpNotFound();
            }
            return View(mainitem);
        }

        //
        // GET: /MAINITEM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINITEM/Create

        [HttpPost]
        public ActionResult Create(MAINITEM mainitem)
        {
            if (ModelState.IsValid)
            {
                db.MAINITEMs.AddObject(mainitem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainitem);
        }

        //
        // GET: /MAINITEM/Edit/5

        public ActionResult Edit(string id = null)
        {
            MAINITEM mainitem = db.MAINITEMs.Single(m => m.MAINCODE == id);
            if (mainitem == null)
            {
                return HttpNotFound();
            }
            return View(mainitem);
        }

        //
        // POST: /MAINITEM/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINITEM mainitem)
        {
            if (ModelState.IsValid)
            {
                db.MAINITEMs.Attach(mainitem);
                db.ObjectStateManager.ChangeObjectState(mainitem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainitem);
        }

        //
        // GET: /MAINITEM/Delete/5

        public ActionResult Delete(string id = null)
        {
            MAINITEM mainitem = db.MAINITEMs.Single(m => m.MAINCODE == id);
            if (mainitem == null)
            {
                return HttpNotFound();
            }
            return View(mainitem);
        }

        //
        // POST: /MAINITEM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            MAINITEM mainitem = db.MAINITEMs.Single(m => m.MAINCODE == id);
            db.MAINITEMs.DeleteObject(mainitem);
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