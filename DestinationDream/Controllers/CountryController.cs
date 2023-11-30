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
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Add()
        {
            TempData["count"]=  db.tblCountries.Count();
            return View();
        }

        TravelAgencyEntities db = new TravelAgencyEntities();
        ICountry _count;
        public CountryController(ICountry count)
        {
            _count = count;
            var config = new MapperConfiguration(m => m.CreateMap<Countries,  tblCountry>().ReverseMap());
        }
        public ActionResult Delete(int id)
        {
            ResponseModel rep = new ResponseModel();
            var obj = _count.Delete(id);
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
            var obj = _count.GetAllc(pageno);
            rep.Code = 0;
            rep.pageno = pageno;
            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetAll(string key)
        {
            ResponseModel rep = new ResponseModel();
            var obj = _count.GetAll(key);
            rep.Code = 0;
            rep.Message = obj;
            return Json(rep, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        public ActionResult FindS(int id)
        {
            ResponseModel rep = new ResponseModel();
            var obj = _count.FindS(id);
            rep.Code = 0;
            rep.Message = obj;

            return Json(rep, JsonRequestBehavior.AllowGet);
            
            //var obj = db.tblCountries.Select(s => new { s.Id, s.Code, s.Name }).
            //    Where(w => w.Id == id).FirstOrDefault();
            //return Json(obj, JsonRequestBehavior.AllowGet);


        }
        [HttpPost]
        public ActionResult Save(Countries obj)
        {

            ResponseModel res = new ResponseModel();

            var O = _count.Save(obj);
            res.Code = 0;
            res.Message = O;
            return Json(res, JsonRequestBehavior.AllowGet);
        }




    }
}