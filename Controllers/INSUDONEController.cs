using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INSUDONEController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INSUDONE/

        public ActionResult Index()
        {
            return View(db.INSUDONEs.ToList());
        }

        //
        // GET: /INSUDONE/Details/5

        public ActionResult Details(int id = 0)
        {
            INSUDONE insudone = db.INSUDONEs.Single(i => i.PK == id);
            if (insudone == null)
            {
                return HttpNotFound();
            }
            return View(insudone);
        }

        //
        // GET: /INSUDONE/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INSUDONE/Create

        [HttpPost]
        public ActionResult Create(INSUDONE insudone)
        {
            if (ModelState.IsValid)
            {
                db.INSUDONEs.AddObject(insudone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insudone);
        }

        //
        // GET: /INSUDONE/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INSUDONE insudone = db.INSUDONEs.Single(i => i.PK == id);
            if (insudone == null)
            {
                return HttpNotFound();
            }
            return View(insudone);
        }

        //
        // POST: /INSUDONE/Edit/5

        [HttpPost]
        public ActionResult Edit(INSUDONE insudone)
        {
            if (ModelState.IsValid)
            {
                db.INSUDONEs.Attach(insudone);
                db.ObjectStateManager.ChangeObjectState(insudone, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insudone);
        }

        //
        // GET: /INSUDONE/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INSUDONE insudone = db.INSUDONEs.Single(i => i.PK == id);
            if (insudone == null)
            {
                return HttpNotFound();
            }
            return View(insudone);
        }

        //
        // POST: /INSUDONE/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INSUDONE insudone = db.INSUDONEs.Single(i => i.PK == id);
            db.INSUDONEs.DeleteObject(insudone);
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