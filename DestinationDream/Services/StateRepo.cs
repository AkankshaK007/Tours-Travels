using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Services
{
    public class StateRepo : IState
    {
        TravelAgencyEntities db = new TravelAgencyEntities();
        public bool Delete(int id)
        {
            var obj = db.tblStates.Find(id);
            if (obj != null)
            {
                db.tblStates.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public dynamic FindS(int id)
        {
            var obj = db.tblStates.Select(s => new { s.Id, s.Name, s.CountryId }).Where(w => w.Id == id).FirstOrDefault();
            if (obj != null)
            {
                return obj;
            }
            return null;
        }

        public dynamic GetAll(string key)
        {
            var objList = db.tblStates.Select(s => new { s.Id, s.Name, CountryId = s.tblCountry.Name }).Where(w => w.Name.Contains(key)).ToList();
            return objList;
        }

        public dynamic GetAllc(int pageno)
        {
            var objList = db.tblStates.Select(s => new { s.Id, s.Name, CountryId = s.tblCountry.Name }).OrderBy(o => o.Id).Skip(4 * pageno).Take(4).ToList();
            return objList;
        }

        public string Save(State obj)
        {
            try
            {
                if (obj.Id == 0)
                {
                    tblState list = new tblState();

                    list.Id = 5;
                    list.Name = obj.Name;
                    list.CountryId = obj.CountryId;
                    db.tblStates.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";
                }
                else
                {
                    var o = db.tblStates.Find(obj.Id);
                    o.Id = obj.Id;
                    o.Name = obj.Name;
                    o.CountryId = obj.CountryId;
                    db.tblStates.Attach(o);
                    db.Entry(o).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Updated Successfully";
                }
            }
            catch (Exception)
            {


            }
            return "";

        }
    }
}