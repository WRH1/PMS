using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DialogController : Controller
    {
        private PMSDataEntities db = new PMSDataEntities();

        //
        // GET: /Dialog/GroupItem

        public ActionResult GroupItem()
        {
            return View();
        }

        //
        // POST: /Dialog/GroupItem
        [HttpPost]
        public JsonResult GroupItem(string GroupName)
        {
            try
            {
                var groupMain = new GRPMAIN();
                groupMain.GRPMNAME = GroupName;
                db.GRPMAINs.AddObject(groupMain);
                db.SaveChanges();
                return Json("{result:success}");
            }
            catch
            {
                return Json("{result:failure}");
            }
        }


        //
        // GET: /Dialog/MainItem

        public ActionResult MainItem()
        {
            ViewBag.EQPType = new SelectList(db.MAINTYPEs.Where(m=> m.MTCODE > 0), "MTCODE", "MAINTYPE1");
            return View();
        }

        //
        // POST: /Dialog/MainItem
        [HttpPost]
        public JsonResult MainItem(string MainItem, int EQPType, int Num)
        {
            try
            {
                var mainItem = new MAINITEM();
                mainItem.MAINITEM1 = MainItem;
                mainItem.MTCODE = EQPType;
                mainItem.NUM = Num;
                db.MAINITEMs.AddObject(mainItem);
                db.SaveChanges();
                return Json("{result:success}");
            }
            catch
            {
                return Json("{result:failure}");
            }
        }

    }
}
