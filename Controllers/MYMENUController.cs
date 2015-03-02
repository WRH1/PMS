using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MYMENUController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MYMENU/

        public ActionResult Index()
        {
            return View(db.MYMENUs.ToList());
        }

        //
        // GET: /MYMENU/Details/5

        public ActionResult Details(int id = 0)
        {
            MYMENU mymenu = db.MYMENUs.Single(m => m.PK == id);
            if (mymenu == null)
            {
                return HttpNotFound();
            }
            return View(mymenu);
        }

        //
        // GET: /MYMENU/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MYMENU/Create

        [HttpPost]
        public ActionResult Create(MYMENU mymenu)
        {
            if (ModelState.IsValid)
            {
                db.MYMENUs.AddObject(mymenu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mymenu);
        }

        //
        // GET: /MYMENU/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MYMENU mymenu = db.MYMENUs.Single(m => m.PK == id);
            if (mymenu == null)
            {
                return HttpNotFound();
            }
            return View(mymenu);
        }

        //
        // POST: /MYMENU/Edit/5

        [HttpPost]
        public ActionResult Edit(MYMENU mymenu)
        {
            if (ModelState.IsValid)
            {
                db.MYMENUs.Attach(mymenu);
                db.ObjectStateManager.ChangeObjectState(mymenu, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mymenu);
        }

        //
        // GET: /MYMENU/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MYMENU mymenu = db.MYMENUs.Single(m => m.PK == id);
            if (mymenu == null)
            {
                return HttpNotFound();
            }
            return View(mymenu);
        }

        //
        // POST: /MYMENU/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MYMENU mymenu = db.MYMENUs.Single(m => m.PK == id);
            db.MYMENUs.DeleteObject(mymenu);
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