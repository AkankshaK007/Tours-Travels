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
            return View();
        }

     
        public ActionResult Index()
        {
            return View();
        }
    }
}