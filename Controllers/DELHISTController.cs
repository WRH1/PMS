using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DELHISTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DELHIST/

        public ActionResult Index()
        {
            return View(db.DELHISTs.ToList());
        }

        //
        // GET: /DELHIST/Details/5

        public ActionResult Details(int id = 0)
        {
            DELHIST delhist = db.DELHISTs.Single(d => d.PK == id);
            if (delhist == null)
            {
                return HttpNotFound();
            }
            return View(delhist);
        }

        //
        // GET: /DELHIST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DELHIST/Create

        [HttpPost]
        public ActionResult Create(DELHIST delhist)
        {
            if (ModelState.IsValid)
            {
                db.DELHISTs.AddObject(delhist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(delhist);
        }

        //
        // GET: /DELHIST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DELHIST delhist = db.DELHISTs.Single(d => d.PK == id);
            if (delhist == null)
            {
                return HttpNotFound();
            }
            return View(delhist);
        }

        //
        // POST: /DELHIST/Edit/5

        [HttpPost]
        public ActionResult Edit(DELHIST delhist)
        {
            if (ModelState.IsValid)
            {
                db.DELHISTs.Attach(delhist);
                db.ObjectStateManager.ChangeObjectState(delhist, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(delhist);
        }

        //
        // GET: /DELHIST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DELHIST delhist = db.DELHISTs.Single(d => d.PK == id);
            if (delhist == null)
            {
                return HttpNotFound();
            }
            return View(delhist);
        }

        //
        // POST: /DELHIST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DELHIST delhist = db.DELHISTs.Single(d => d.PK == id);
            db.DELHISTs.DeleteObject(delhist);
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