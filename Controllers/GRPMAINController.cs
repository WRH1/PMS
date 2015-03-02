using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class GRPMAINController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /GRPMAIN/

        public ActionResult Index()
        {
            return View(db.GRPMAINs.ToList());
        }

        //
        // GET: /GRPMAIN/Details/5

        public ActionResult Details(int id = 0)
        {
            GRPMAIN grpmain = db.GRPMAINs.Single(g => g.PK == id);
            if (grpmain == null)
            {
                return HttpNotFound();
            }
            return View(grpmain);
        }

        //
        // GET: /GRPMAIN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GRPMAIN/Create

        [HttpPost]
        public ActionResult Create(GRPMAIN grpmain)
        {
            if (ModelState.IsValid)
            {
                db.GRPMAINs.AddObject(grpmain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grpmain);
        }

        //
        // GET: /GRPMAIN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GRPMAIN grpmain = db.GRPMAINs.Single(g => g.PK == id);
            if (grpmain == null)
            {
                return HttpNotFound();
            }
            return View(grpmain);
        }

        //
        // POST: /GRPMAIN/Edit/5

        [HttpPost]
        public ActionResult Edit(GRPMAIN grpmain)
        {
            if (ModelState.IsValid)
            {
                db.GRPMAINs.Attach(grpmain);
                db.ObjectStateManager.ChangeObjectState(grpmain, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grpmain);
        }

        //
        // GET: /GRPMAIN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GRPMAIN grpmain = db.GRPMAINs.Single(g => g.PK == id);
            if (grpmain == null)
            {
                return HttpNotFound();
            }
            return View(grpmain);
        }

        //
        // POST: /GRPMAIN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            GRPMAIN grpmain = db.GRPMAINs.Single(g => g.PK == id);
            db.GRPMAINs.DeleteObject(grpmain);
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