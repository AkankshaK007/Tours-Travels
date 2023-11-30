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
        public dynamic FindS(int id)
        {
            var obj = db.tbl_Cities.Select(s => new { s.Id, s.Name, s.StateId }).Where(w => w.Id == id).FirstOrDefault();
            if (obj != null)
            {
                return obj;
            }
            return null;

        }
        public dynamic GetAllc(int pageno)
        {
            var objList = db.tbl_Cities.Select(s => new { s.Id, s.Name, StateId= s.tblState.Name }).OrderBy(o => o.Id).Skip(4 * pageno).Take(4).ToList();
            return objList;
        }
        public dynamic GetAll(string key)
        {
            var objList = db.tbl_Cities.Select(s => new { s.Id, s.Name, StateId = s.tblState.Name }).Where(w => w.Name.Contains(key)).ToList();
            return objList;
        }
        [HttpPost]
        public string Save(Cities obj)
        {
            try
            {
                if (obj.Id==0)
                {
                    tbl_Cities list = new tbl_Cities();

                    list.Id = 5;
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
            catch (Exception )
            {

                
            }
            return "";

        }
    }
}


