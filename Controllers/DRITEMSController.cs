using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DRITEMSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DRITEMS/

        public ActionResult Index()
        {
            return View(db.DRITEMS.ToList());
        }

        //
        // GET: /DRITEMS/Details/5

        public ActionResult Details(int id = 0)
        {
            DRITEM dritem = db.DRITEMS.Single(d => d.PK == id);
            if (dritem == null)
            {
                return HttpNotFound();
            }
            return View(dritem);
        }

        //
        // GET: /DRITEMS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DRITEMS/Create

        [HttpPost]
        public ActionResult Create(DRITEM dritem)
        {
            if (ModelState.IsValid)
            {
                db.DRITEMS.AddObject(dritem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dritem);
        }

        //
        // GET: /DRITEMS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DRITEM dritem = db.DRITEMS.Single(d => d.PK == id);
            if (dritem == null)
            {
                return HttpNotFound();
            }
            return View(dritem);
        }

        //
        // POST: /DRITEMS/Edit/5

        [HttpPost]
        public ActionResult Edit(DRITEM dritem)
        {
            if (ModelState.IsValid)
            {
                db.DRITEMS.Attach(dritem);
                db.ObjectStateManager.ChangeObjectState(dritem, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dritem);
        }

        //
        // GET: /DRITEMS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DRITEM dritem = db.DRITEMS.Single(d => d.PK == id);
            if (dritem == null)
            {
                return HttpNotFound();
            }
            return View(dritem);
        }

        //
        // POST: /DRITEMS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DRITEM dritem = db.DRITEMS.Single(d => d.PK == id);
            db.DRITEMS.DeleteObject(dritem);
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