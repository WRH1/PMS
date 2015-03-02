using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class FOXUSERController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /FOXUSER/

        public ActionResult Index()
        {
            return View(db.FOXUSERs.ToList());
        }

        //
        // GET: /FOXUSER/Details/5

        public ActionResult Details(int id = 0)
        {
            FOXUSER foxuser = db.FOXUSERs.Single(f => f.PK == id);
            if (foxuser == null)
            {
                return HttpNotFound();
            }
            return View(foxuser);
        }

        //
        // GET: /FOXUSER/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FOXUSER/Create

        [HttpPost]
        public ActionResult Create(FOXUSER foxuser)
        {
            if (ModelState.IsValid)
            {
                db.FOXUSERs.AddObject(foxuser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foxuser);
        }

        //
        // GET: /FOXUSER/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FOXUSER foxuser = db.FOXUSERs.Single(f => f.PK == id);
            if (foxuser == null)
            {
                return HttpNotFound();
            }
            return View(foxuser);
        }

        //
        // POST: /FOXUSER/Edit/5

        [HttpPost]
        public ActionResult Edit(FOXUSER foxuser)
        {
            if (ModelState.IsValid)
            {
                db.FOXUSERs.Attach(foxuser);
                db.ObjectStateManager.ChangeObjectState(foxuser, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foxuser);
        }

        //
        // GET: /FOXUSER/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FOXUSER foxuser = db.FOXUSERs.Single(f => f.PK == id);
            if (foxuser == null)
            {
                return HttpNotFound();
            }
            return View(foxuser);
        }

        //
        // POST: /FOXUSER/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FOXUSER foxuser = db.FOXUSERs.Single(f => f.PK == id);
            db.FOXUSERs.DeleteObject(foxuser);
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