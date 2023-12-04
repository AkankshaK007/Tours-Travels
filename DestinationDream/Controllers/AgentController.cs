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
    public class AgentController : Controller
    {
        // GET: Agent
        public ActionResult Add()
        {
            TempData["count"] = db.tblAgents.Count();
            return View();
        }
        TravelAgencyEntities db = new TravelAgencyEntities();

        IAgent a;
        public AgentController(IAgent _a)
        {
            a = _a;
            var config = new MapperConfiguration(m => m.CreateMap<Agent, tblAgent>().ReverseMap());

        }

        public ActionResult Delete(int id)
        {
            ResponseModel rep = new ResponseModel();
            var obj = a.Delete(id);
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
            var obj = a.GetAllc(pageno);
            rep.Code = 0;
            rep.Message = obj;
            rep.pageno = pageno;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAll(string key)
        {
            ResponseModel rep = new ResponseModel();
            var obj = a.GetAll(key);
            rep.Code = 0;

            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult FindS(int id)
        {
            ResponseModel res = new ResponseModel();
            var obj = a.FindS(id);
            res.Code = 0;
            res.Message = obj;
            return Json(res, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public JsonResult Save(Agent M)
        {
            ResponseModel res = new ResponseModel();

            var O = a.Save(M);
            res.Code = 0;
            res.Message = O;
            return Json(res, JsonRequestBehavior.AllowGet);
        }

		
	}
}