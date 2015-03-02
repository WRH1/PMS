using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class GRPBKController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /GRPBK/

        public ActionResult Index()
        {
            return View(db.GRPBKs.ToList());
        }

        //
        // GET: /GRPBK/Details/5

        public ActionResult Details(int id = 0)
        {
            GRPBK grpbk = db.GRPBKs.Single(g => g.PK == id);
            if (grpbk == null)
            {
                return HttpNotFound();
            }
            return View(grpbk);
        }

        //
        // GET: /GRPBK/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GRPBK/Create

        [HttpPost]
        public ActionResult Create(GRPBK grpbk)
        {
            if (ModelState.IsValid)
            {
                db.GRPBKs.AddObject(grpbk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grpbk);
        }

        //
        // GET: /GRPBK/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GRPBK grpbk = db.GRPBKs.Single(g => g.PK == id);
            if (grpbk == null)
            {
                return HttpNotFound();
            }
            return View(grpbk);
        }

        //
        // POST: /GRPBK/Edit/5

        [HttpPost]
        public ActionResult Edit(GRPBK grpbk)
        {
            if (ModelState.IsValid)
            {
                db.GRPBKs.Attach(grpbk);
                db.ObjectStateManager.ChangeObjectState(grpbk, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grpbk);
        }

        //
        // GET: /GRPBK/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GRPBK grpbk = db.GRPBKs.Single(g => g.PK == id);
            if (grpbk == null)
            {
                return HttpNotFound();
            }
            return View(grpbk);
        }

        //
        // POST: /GRPBK/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            GRPBK grpbk = db.GRPBKs.Single(g => g.PK == id);
            db.GRPBKs.DeleteObject(grpbk);
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