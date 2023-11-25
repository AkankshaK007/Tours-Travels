using DestinationDream.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Add()
        {
            ViewBag.msg = CommonRepo.GetState();
            return View();
        }
    }
}