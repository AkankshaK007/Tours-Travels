using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.API
{
    public static class CommonRepo
    {

       
         public static List<SelectListItem> GetState()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            using (var ctx = new TravelAgencyEntities())
            {
                var obj = ctx.tblStates.Select(s => new { s.Id, s.Name }).ToList();
                foreach (var item in obj)
                {
                    SelectListItem t = new SelectListItem();
                    t.Value = item.Id.ToString();
                    t.Text = item.Name;

                    list.Add(t);

                }
                
            }
            return list;
        }

    }
}