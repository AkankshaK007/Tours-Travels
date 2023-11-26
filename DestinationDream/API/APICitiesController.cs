using AutoMapper;
using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.API
{
    public class APICitiesController : Controller
    {
        ICities c;

        Mapper mp = null;
         
        public APICitiesController(ICities _c)
        {
            c = _c;
            var config = new MapperConfiguration(m => m.CreateMap<Cities, tbl_Cities>().ReverseMap());

        }
        [HttpPost]
        public JsonResult Save(Cities M)
        {
            ResponseModel res = new ResponseModel();
            
            var O = c.Save(M);
            res.Code = 0;
            res.Message = O;
            return Json (res, JsonRequestBehavior.AllowGet);
        }

    }
}