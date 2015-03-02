using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MEPERDETController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MEPERDET/

        public ActionResult Index()
        {
            return View(db.MEPERDETs.ToList());
        }

        //
        // GET: /MEPERDET/Details/5

        public ActionResult Details(int id = 0)
        {
            MEPERDET meperdet = db.MEPERDETs.Single(m => m.PK == id);
            if (meperdet == null)
            {
                return HttpNotFound();
            }
            return View(meperdet);
        }

        //
        // GET: /MEPERDET/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MEPERDET/Create

        [HttpPost]
        public ActionResult Create(MEPERDET meperdet)
        {
            if (ModelState.IsValid)
            {
                db.MEPERDETs.AddObject(meperdet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meperdet);
        }

        //
        // GET: /MEPERDET/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MEPERDET meperdet = db.MEPERDETs.Single(m => m.PK == id);
            if (meperdet == null)
            {
                return HttpNotFound();
            }
            return View(meperdet);
        }

        //
        // POST: /MEPERDET/Edit/5

        [HttpPost]
        public ActionResult Edit(MEPERDET meperdet)
        {
            if (ModelState.IsValid)
            {
                db.MEPERDETs.Attach(meperdet);
                db.ObjectStateManager.ChangeObjectState(meperdet, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meperdet);
        }

        //
        // GET: /MEPERDET/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MEPERDET meperdet = db.MEPERDETs.Single(m => m.PK == id);
            if (meperdet == null)
            {
                return HttpNotFound();
            }
            return View(meperdet);
        }

        //
        // POST: /MEPERDET/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MEPERDET meperdet = db.MEPERDETs.Single(m => m.PK == id);
            db.MEPERDETs.DeleteObject(meperdet);
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