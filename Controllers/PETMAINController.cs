using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PETMAINController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PETMAIN/

        public ActionResult Index()
        {
            return View(db.PETMAINs.ToList());
        }

        //
        // GET: /PETMAIN/Details/5

        public ActionResult Details(int id = 0)
        {
            PETMAIN petmain = db.PETMAINs.Single(p => p.PK == id);
            if (petmain == null)
            {
                return HttpNotFound();
            }
            return View(petmain);
        }

        //
        // GET: /PETMAIN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PETMAIN/Create

        [HttpPost]
        public ActionResult Create(PETMAIN petmain)
        {
            if (ModelState.IsValid)
            {
                db.PETMAINs.AddObject(petmain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(petmain);
        }

        //
        // GET: /PETMAIN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PETMAIN petmain = db.PETMAINs.Single(p => p.PK == id);
            if (petmain == null)
            {
                return HttpNotFound();
            }
            return View(petmain);
        }

        //
        // POST: /PETMAIN/Edit/5

        [HttpPost]
        public ActionResult Edit(PETMAIN petmain)
        {
            if (ModelState.IsValid)
            {
                db.PETMAINs.Attach(petmain);
                db.ObjectStateManager.ChangeObjectState(petmain, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(petmain);
        }

        //
        // GET: /PETMAIN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PETMAIN petmain = db.PETMAINs.Single(p => p.PK == id);
            if (petmain == null)
            {
                return HttpNotFound();
            }
            return View(petmain);
        }

        //
        // POST: /PETMAIN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PETMAIN petmain = db.PETMAINs.Single(p => p.PK == id);
            db.PETMAINs.DeleteObject(petmain);
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