using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ACCIDENTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /ACCIDENT/

        public ActionResult Index()
        {
            return View(db.ACCIDENTs.ToList());
        }

        //
        // GET: /ACCIDENT/Details/5

        public ActionResult Details(string id = null)
        {
            ACCIDENT accident = db.ACCIDENTs.Single(a => a.SRNUMB == id);
            if (accident == null)
            {
                return HttpNotFound();
            }
            return View(accident);
        }

        //
        // GET: /ACCIDENT/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ACCIDENT/Create

        [HttpPost]
        public ActionResult Create(ACCIDENT accident)
        {
            if (ModelState.IsValid)
            {
                db.ACCIDENTs.AddObject(accident);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accident);
        }

        //
        // GET: /ACCIDENT/Edit/5

        public ActionResult Edit(string id = null)
        {
            ACCIDENT accident = db.ACCIDENTs.Single(a => a.SRNUMB == id);
            if (accident == null)
            {
                return HttpNotFound();
            }
            return View(accident);
        }

        //
        // POST: /ACCIDENT/Edit/5

        [HttpPost]
        public ActionResult Edit(ACCIDENT accident)
        {
            if (ModelState.IsValid)
            {
                db.ACCIDENTs.Attach(accident);
                db.ObjectStateManager.ChangeObjectState(accident, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accident);
        }

        //
        // GET: /ACCIDENT/Delete/5

        public ActionResult Delete(string id = null)
        {
            ACCIDENT accident = db.ACCIDENTs.Single(a => a.SRNUMB == id);
            if (accident == null)
            {
                return HttpNotFound();
            }
            return View(accident);
        }

        //
        // POST: /ACCIDENT/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            ACCIDENT accident = db.ACCIDENTs.Single(a => a.SRNUMB == id);
            db.ACCIDENTs.DeleteObject(accident);
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