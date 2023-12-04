using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DestinationDream.Services
{
    public class RoomRepo : IRoom
    {
        TravelAgencyEntities db = new TravelAgencyEntities();
        public bool Delete(int id)
        {
            var obj = db.tblRoomTypes.Find(id);
            if (obj!=null)
            {
                db.tblRoomTypes.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public dynamic FindS(int id)
        {
           var obj = db.tblRoomTypes.Select(s => new {s.Id,s.RoomType}).Where(w=>w.Id==id).FirstOrDefault();
            if (obj!=null) 
            {
                return obj;
            }
            return null;
        }

        public dynamic GetAll(string key) //search
        {
            var objList = db.tblRoomTypes.Select(s=>new {s.Id,s.RoomType}).Where(w=>w.RoomType.Contains(key)).ToList();
            return objList;
        }

        public dynamic GetAllc(int pageno) //
        {
            var objList = db.tblRoomTypes.Select(s => new {s.Id,s.RoomType}).OrderBy(o=>o.Id).Skip(4*pageno).Take(4).ToList();
            return objList;
        }

        [HttpPost]
        public string Save(RoomType obj )
        {
            try
            {
                if (obj.Id==0)
                {
                    tblRoomType list = new tblRoomType();

                    list.Id = 1; 
                    list.RoomType = obj.Type;
                    db.tblRoomTypes.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";

                }
                else
                {
                    var o = db.tblRoomTypes.Find(obj.Id);
                    o.Id = obj.Id;
                    o.RoomType = obj.Type;
                    db.tblRoomTypes.Attach(o);
                    db.Entry(o).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "Update Successfully";

                }
            }
            catch (Exception)
            {

               
            }

            return null;
        }
    }
}