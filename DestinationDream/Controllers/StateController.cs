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
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Add()
        {

            ViewBag.msg = CommonRepo.GetCountry();
            TempData["count"] = db.tblCountries.Count();
            return View();
        }


        TravelAgencyEntities db = new TravelAgencyEntities();

        IState S;
        public StateController(IState _S)
        {
            S = _S;
            var config = new MapperConfiguration(m => m.CreateMap<State, tblState>().ReverseMap());

        }

        public ActionResult Delete(int id)
        {
            ResponseModel rep = new ResponseModel();
            var obj = S.Delete(id);
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
            var obj = S.GetAllc(pageno);
            rep.Code = 0;
            rep.Message = obj;
            rep.pageno = pageno;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAll(string key)
        {
            ResponseModel rep = new ResponseModel();
            var obj = S.GetAll(key);
            rep.Code = 0;

            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult find(int id)
        {
            ResponseModel res = new ResponseModel();
            var obj = S.FindS(id);
            res.Code = 0;
            res.Message = obj;
            return Json(res, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Save(State M)
        {
            ResponseModel res = new ResponseModel();

            var O = S.Save(M);
            res.Code = 0;
            res.Message = O;
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}