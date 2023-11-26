using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Services
{
    public class CountryRepo :ICountry
    {
        TravelAgencyEntities db = new TravelAgencyEntities();

        public bool Delete(int id)
        {

            var obj = db.tblCountries.Find(id);
            if (obj != null)
            {
                db.tblCountries.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public tblCountry Find(int id)
        {
            var obj = db.tblCountries.Find(id);
            return obj;
        }

        public List<tblCountry> GetAll()
        {
            return db.tblCountries.ToList();
        }

        public bool Save(Countries obj)
        {
            try
            {
                //db.tblCountries.Attach(obj);
                //db.Entry(obj).State = obj.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();
                //return true;

                
            }
            catch (Exception er)
            {

                return false;
            }

            return true;
            
        }

        
    }
}