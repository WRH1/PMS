using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class BKIMGDBFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /BKIMGDBF/

        public ActionResult Index()
        {
            return View(db.BKIMGDBFs.ToList());
        }

        //
        // GET: /BKIMGDBF/Details/5

        public ActionResult Details(int id = 0)
        {
            BKIMGDBF bkimgdbf = db.BKIMGDBFs.Single(b => b.PK == id);
            if (bkimgdbf == null)
            {
                return HttpNotFound();
            }
            return View(bkimgdbf);
        }

        //
        // GET: /BKIMGDBF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BKIMGDBF/Create

        [HttpPost]
        public ActionResult Create(BKIMGDBF bkimgdbf)
        {
            if (ModelState.IsValid)
            {
                db.BKIMGDBFs.AddObject(bkimgdbf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bkimgdbf);
        }

        //
        // GET: /BKIMGDBF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BKIMGDBF bkimgdbf = db.BKIMGDBFs.Single(b => b.PK == id);
            if (bkimgdbf == null)
            {
                return HttpNotFound();
            }
            return View(bkimgdbf);
        }

        //
        // POST: /BKIMGDBF/Edit/5

        [HttpPost]
        public ActionResult Edit(BKIMGDBF bkimgdbf)
        {
            if (ModelState.IsValid)
            {
                db.BKIMGDBFs.Attach(bkimgdbf);
                db.ObjectStateManager.ChangeObjectState(bkimgdbf, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bkimgdbf);
        }

        //
        // GET: /BKIMGDBF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BKIMGDBF bkimgdbf = db.BKIMGDBFs.Single(b => b.PK == id);
            if (bkimgdbf == null)
            {
                return HttpNotFound();
            }
            return View(bkimgdbf);
        }

        //
        // POST: /BKIMGDBF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BKIMGDBF bkimgdbf = db.BKIMGDBFs.Single(b => b.PK == id);
            db.BKIMGDBFs.DeleteObject(bkimgdbf);
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