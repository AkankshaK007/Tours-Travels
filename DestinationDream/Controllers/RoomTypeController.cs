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
    public class RoomTypeController : Controller
    {

        // GET: RoomType
        public ActionResult Add()
        {
            TempData["count"] = db.tblRoomTypes.Count();
            return View();
        }

        TravelAgencyEntities db = new TravelAgencyEntities();

        IRoom r;

        public RoomTypeController(IRoom _r)
        {
            r = _r;
            var config = new MapperConfiguration(m => m.CreateMap<RoomType, tblRoomType>().ReverseMap());
        }

        public ActionResult Delete(int id) 
        {
            ResponseModel rep = new ResponseModel();
            var obj = r.Delete(id);
            if (obj == true)
            {
                rep.Code = 0;
                rep.Message = "Deleted";

            }
            return Json(rep,JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAllc(int pageno) 
        {
            ResponseModel rep = new ResponseModel();
            var obj = r.GetAllc(pageno);
            rep.Code = 0;
            rep.Message = obj;
            rep.pageno = pageno;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult GetAll(string key) 
        {
            ResponseModel rep = new ResponseModel();
            var obj = r.GetAll(key);
            rep.Code = 0;
            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult find(int id) 
        {
            ResponseModel rep = new ResponseModel();
            var obj = r.FindS(id);
            rep.Code = 0;
            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(RoomType R) 
        {
            ResponseModel rep = new ResponseModel();
            var O = r.Save(R);
            rep.Code = 0;
            rep.Message = O;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }
    }
}