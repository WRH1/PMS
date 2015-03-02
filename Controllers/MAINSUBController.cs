using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINSUBController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINSUB/

        public ActionResult Index()
        {
            return View(db.MAINSUBs.ToList());
        }

        //
        // GET: /MAINSUB/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINSUB mainsub = db.MAINSUBs.Single(m => m.PK == id);
            if (mainsub == null)
            {
                return HttpNotFound();
            }
            return View(mainsub);
        }

        //
        // GET: /MAINSUB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINSUB/Create

        [HttpPost]
        public ActionResult Create(MAINSUB mainsub)
        {
            if (ModelState.IsValid)
            {
                db.MAINSUBs.AddObject(mainsub);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainsub);
        }

        //
        // GET: /MAINSUB/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINSUB mainsub = db.MAINSUBs.Single(m => m.PK == id);
            if (mainsub == null)
            {
                return HttpNotFound();
            }
            return View(mainsub);
        }

        //
        // POST: /MAINSUB/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINSUB mainsub)
        {
            if (ModelState.IsValid)
            {
                db.MAINSUBs.Attach(mainsub);
                db.ObjectStateManager.ChangeObjectState(mainsub, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainsub);
        }

        //
        // GET: /MAINSUB/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINSUB mainsub = db.MAINSUBs.Single(m => m.PK == id);
            if (mainsub == null)
            {
                return HttpNotFound();
            }
            return View(mainsub);
        }

        //
        // POST: /MAINSUB/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINSUB mainsub = db.MAINSUBs.Single(m => m.PK == id);
            db.MAINSUBs.DeleteObject(mainsub);
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