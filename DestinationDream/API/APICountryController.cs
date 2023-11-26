using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.API
{
    public class APICountryController : Controller
    {
        ICountry _count;
        public APICountryController(ICountry count)
        {
            _count = count;
        }
        public ActionResult Delete(int id)
        {
            var obj = _count.Delete(id);
            return Json(obj,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAll()
        {
            return Json(_count.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Find(int id)
        {
            var obj = _count.Find(id);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Save(Countries obj)
        {
            if (_count.Save(obj))
            {
                ViewBag.msg = "Saved Successfully";
            }
            else
            {
                ViewBag.msg = "failed";
            }
            return View();
        }
        
    }
}