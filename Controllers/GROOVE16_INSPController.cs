using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class GROOVE16_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /GROOVE16_INSP/

        public ActionResult Index()
        {
            return View(db.GROOVE16_INSP.ToList());
        }

        //
        // GET: /GROOVE16_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            GROOVE16_INSP groove16_insp = db.GROOVE16_INSP.Single(g => g.PK == id);
            if (groove16_insp == null)
            {
                return HttpNotFound();
            }
            return View(groove16_insp);
        }

        //
        // GET: /GROOVE16_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /GROOVE16_INSP/Create

        [HttpPost]
        public ActionResult Create(GROOVE16_INSP groove16_insp)
        {
            if (ModelState.IsValid)
            {
                db.GROOVE16_INSP.AddObject(groove16_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(groove16_insp);
        }

        //
        // GET: /GROOVE16_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GROOVE16_INSP groove16_insp = db.GROOVE16_INSP.Single(g => g.PK == id);
            if (groove16_insp == null)
            {
                return HttpNotFound();
            }
            return View(groove16_insp);
        }

        //
        // POST: /GROOVE16_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(GROOVE16_INSP groove16_insp)
        {
            if (ModelState.IsValid)
            {
                db.GROOVE16_INSP.Attach(groove16_insp);
                db.ObjectStateManager.ChangeObjectState(groove16_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(groove16_insp);
        }

        //
        // GET: /GROOVE16_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GROOVE16_INSP groove16_insp = db.GROOVE16_INSP.Single(g => g.PK == id);
            if (groove16_insp == null)
            {
                return HttpNotFound();
            }
            return View(groove16_insp);
        }

        //
        // POST: /GROOVE16_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            GROOVE16_INSP groove16_insp = db.GROOVE16_INSP.Single(g => g.PK == id);
            db.GROOVE16_INSP.DeleteObject(groove16_insp);
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