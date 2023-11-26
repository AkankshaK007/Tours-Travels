using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.Services
{
    public class CitiesRepo : ICities
    {
        TravelAgencyEntities db = new TravelAgencyEntities();
        public bool Delete(int id)
        {
            var obj = db.tbl_Cities.Find(id);
            if (obj!=null)
            {
                db.tbl_Cities.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public tbl_Cities Find(int id)
        {
            var obj = db.tbl_Cities.Find(id);
            return obj;
        }

        public List<tbl_Cities> GetAll()
        {
            return db.tbl_Cities.ToList();
        }


        [HttpPost]
        public string Save(Cities obj)
        {
            try
            {
                if (obj.Id==0)
                {
                    tbl_Cities list = new tbl_Cities();

                    list.Id = 1;
                    list.Name = obj.Name;
                    list.StateId = obj.StateId;
                    db.tbl_Cities.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";
                }
                else
                {
                    var o = db.tbl_Cities.Find(obj.Id);
                    o.Id = obj.Id;
                    o.Name = obj.Name;
                    o.StateId = obj.StateId;
                    db.tbl_Cities.Attach(o);
                    db.Entry(o).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Updated Successfully";

                }
               
            }
            catch (Exception er)
            {

                
            }
            return "";

        }
    }
}