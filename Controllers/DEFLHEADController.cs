using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFLHEADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFLHEAD/

        public ActionResult Index()
        {
            return View(db.DEFLHEADs.ToList());
        }

        //
        // GET: /DEFLHEAD/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFLHEAD deflhead = db.DEFLHEADs.Single(d => d.PK == id);
            if (deflhead == null)
            {
                return HttpNotFound();
            }
            return View(deflhead);
        }

        //
        // GET: /DEFLHEAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFLHEAD/Create

        [HttpPost]
        public ActionResult Create(DEFLHEAD deflhead)
        {
            if (ModelState.IsValid)
            {
                db.DEFLHEADs.AddObject(deflhead);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deflhead);
        }

        //
        // GET: /DEFLHEAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFLHEAD deflhead = db.DEFLHEADs.Single(d => d.PK == id);
            if (deflhead == null)
            {
                return HttpNotFound();
            }
            return View(deflhead);
        }

        //
        // POST: /DEFLHEAD/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFLHEAD deflhead)
        {
            if (ModelState.IsValid)
            {
                db.DEFLHEADs.Attach(deflhead);
                db.ObjectStateManager.ChangeObjectState(deflhead, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deflhead);
        }

        //
        // GET: /DEFLHEAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFLHEAD deflhead = db.DEFLHEADs.Single(d => d.PK == id);
            if (deflhead == null)
            {
                return HttpNotFound();
            }
            return View(deflhead);
        }

        //
        // POST: /DEFLHEAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFLHEAD deflhead = db.DEFLHEADs.Single(d => d.PK == id);
            db.DEFLHEADs.DeleteObject(deflhead);
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