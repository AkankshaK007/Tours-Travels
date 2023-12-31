﻿using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public dynamic FindS(int id)
        {
            //var obj = db.tblCountries.Find(id);
            //return obj;

            var obj = db.tblCountries.Select(s => new { s.Id, s.Code, s.Name }).Where(w => w.Id == id).FirstOrDefault();
            if (obj != null)
            {

                return obj;
            }
            return null;
        }
        

        public dynamic GetAllc(int pageno)
        {
            var objList = db.tblCountries.Select(s => new { s.Id, s.Name, s.Code }).OrderBy(o=>o.Id).Skip(6* pageno).Take(6).ToList();
            return objList;
        }
        public dynamic GetAll( string key)
        {
            var objList = db.tblCountries.Select(s => new { s.Id, s.Name, s.Code }).Where(w=>w.Name.Contains(key)).ToList();
            return objList;
        }


       
        public string Save(Countries obj)
        {
            
            try
            {
                if (obj.Id == 0)
                {
                    
                    tblCountry list = new tblCountry();

                    //list.Id = obj.Id;
                    list.Code = obj.Code;
                    list.Name = obj.Name;
                 
                    db.tblCountries.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";
                }
                else
                {
                    var o = db.tblCountries.Find(obj.Id);
                    o.Id = obj.Id;
                    o.Code = obj.Code;
                    o.Name = obj.Name;
                  
                    db.tblCountries.Attach(o);
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