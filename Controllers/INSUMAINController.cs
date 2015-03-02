using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class INSUMAINController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /INSUMAIN/

        public ActionResult Index()
        {
            return View(db.INSUMAINs.ToList());
        }

        //
        // GET: /INSUMAIN/Details/5

        public ActionResult Details(int id = 0)
        {
            INSUMAIN insumain = db.INSUMAINs.Single(i => i.PK == id);
            if (insumain == null)
            {
                return HttpNotFound();
            }
            return View(insumain);
        }

        //
        // GET: /INSUMAIN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /INSUMAIN/Create

        [HttpPost]
        public ActionResult Create(INSUMAIN insumain)
        {
            if (ModelState.IsValid)
            {
                db.INSUMAINs.AddObject(insumain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insumain);
        }

        //
        // GET: /INSUMAIN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            INSUMAIN insumain = db.INSUMAINs.Single(i => i.PK == id);
            if (insumain == null)
            {
                return HttpNotFound();
            }
            return View(insumain);
        }

        //
        // POST: /INSUMAIN/Edit/5

        [HttpPost]
        public ActionResult Edit(INSUMAIN insumain)
        {
            if (ModelState.IsValid)
            {
                db.INSUMAINs.Attach(insumain);
                db.ObjectStateManager.ChangeObjectState(insumain, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insumain);
        }

        //
        // GET: /INSUMAIN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            INSUMAIN insumain = db.INSUMAINs.Single(i => i.PK == id);
            if (insumain == null)
            {
                return HttpNotFound();
            }
            return View(insumain);
        }

        //
        // POST: /INSUMAIN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            INSUMAIN insumain = db.INSUMAINs.Single(i => i.PK == id);
            db.INSUMAINs.DeleteObject(insumain);
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