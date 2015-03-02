using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PASSWORDController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PASSWORD/

        public ActionResult Index()
        {
            return View(db.PASSWORDs.ToList());
        }

        //
        // GET: /PASSWORD/Details/5

        public ActionResult Details(int id = 0)
        {
            PASSWORD password = db.PASSWORDs.Single(p => p.PK == id);
            if (password == null)
            {
                return HttpNotFound();
            }
            return View(password);
        }

        //
        // GET: /PASSWORD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PASSWORD/Create

        [HttpPost]
        public ActionResult Create(PASSWORD password)
        {
            if (ModelState.IsValid)
            {
                db.PASSWORDs.AddObject(password);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(password);
        }

        //
        // GET: /PASSWORD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PASSWORD password = db.PASSWORDs.Single(p => p.PK == id);
            if (password == null)
            {
                return HttpNotFound();
            }
            return View(password);
        }

        //
        // POST: /PASSWORD/Edit/5

        [HttpPost]
        public ActionResult Edit(PASSWORD password)
        {
            if (ModelState.IsValid)
            {
                db.PASSWORDs.Attach(password);
                db.ObjectStateManager.ChangeObjectState(password, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(password);
        }

        //
        // GET: /PASSWORD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PASSWORD password = db.PASSWORDs.Single(p => p.PK == id);
            if (password == null)
            {
                return HttpNotFound();
            }
            return View(password);
        }

        //
        // POST: /PASSWORD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PASSWORD password = db.PASSWORDs.Single(p => p.PK == id);
            db.PASSWORDs.DeleteObject(password);
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