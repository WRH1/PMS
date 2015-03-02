using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LINERController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /LINER/

        public ActionResult Index()
        {
            return View(db.LINERs.ToList());
        }

        //
        // GET: /LINER/Details/5

        public ActionResult Details(int id = 0)
        {
            LINER liner = db.LINERs.Single(l => l.PK == id);
            if (liner == null)
            {
                return HttpNotFound();
            }
            return View(liner);
        }

        //
        // GET: /LINER/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LINER/Create

        [HttpPost]
        public ActionResult Create(LINER liner)
        {
            if (ModelState.IsValid)
            {
                db.LINERs.AddObject(liner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(liner);
        }

        //
        // GET: /LINER/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LINER liner = db.LINERs.Single(l => l.PK == id);
            if (liner == null)
            {
                return HttpNotFound();
            }
            return View(liner);
        }

        //
        // POST: /LINER/Edit/5

        [HttpPost]
        public ActionResult Edit(LINER liner)
        {
            if (ModelState.IsValid)
            {
                db.LINERs.Attach(liner);
                db.ObjectStateManager.ChangeObjectState(liner, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(liner);
        }

        //
        // GET: /LINER/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LINER liner = db.LINERs.Single(l => l.PK == id);
            if (liner == null)
            {
                return HttpNotFound();
            }
            return View(liner);
        }

        //
        // POST: /LINER/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LINER liner = db.LINERs.Single(l => l.PK == id);
            db.LINERs.DeleteObject(liner);
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