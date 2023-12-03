using AutoMapper;
using DestinationDream.API;
using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.Controllers
{
    public class CompanyTypeController : Controller
    {
        // GET: CompanyType
        public ActionResult Add()
        {
            TempData["count"] = db.tblCompanyTypes.Count();
            return View();
        }

        TravelAgencyEntities db = new TravelAgencyEntities();

        ICompanyType c;

        public CompanyTypeController(ICompanyType _c)
        {
            c = _c;
            var config = new MapperConfiguration(m => m.CreateMap<CompanyType, tblCompanyType>().ReverseMap());

        }

        public ActionResult Delete(int id)
        {
            ResponseModel rep = new ResponseModel();
            var obj = c.Delete(id);
            if (obj == true)
            {
                rep.Code = 0;
                rep.Message = "Deleted";
            }

            return Json(rep, JsonRequestBehavior.AllowGet);

        }

        public ActionResult GetAllc(int pageno)
        {
            ResponseModel rep = new ResponseModel();
            var obj = c.GetAllc(pageno);
            rep.Code = 0;
            rep.Message = obj;
            rep.pageno = pageno;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAll(string key)
        {
            ResponseModel rep = new ResponseModel();
            var obj = c.GetAll(key);
            rep.Code = 0;

            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult find(int id)
        {
            ResponseModel res = new ResponseModel();
            var obj = c.FindS(id);
            res.Code = 0;
            res.Message = obj;
            return Json(res, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Save(CompanyType M)
        {
            ResponseModel res = new ResponseModel();

            var O = c.Save(M);
            res.Code = 0;
            res.Message = O;
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}