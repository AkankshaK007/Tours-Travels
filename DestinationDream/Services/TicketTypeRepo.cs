using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Services
{
    public class TicketTypeRepo : ITicketType
    {
        TravelAgencyEntities db = new TravelAgencyEntities();

        public bool Delete(int id)
        {
            var obj = db.tblTicketTypes.Find(id);
            if (obj != null)
            {
                db.tblTicketTypes.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public dynamic FindS(int id)
        {
            var obj = db.tblTicketTypes.Select(s => new { s.Id, s.Name }).Where(w => w.Id == id).FirstOrDefault();
            if (obj != null)
            {
                return obj;
            }
            return null;
        }

        public dynamic GetAll(string key)
        {
            var objList = db.tblTicketTypes.Select(s => new { s.Id, s.Name }).Where(w => w.Name.Contains(key)).ToList();
            return objList;
        }

        public dynamic GetAllc(int pageno)
        {
            var objList = db.tblTicketTypes.Select(s => new { s.Id, s.Name }).OrderBy(o => o.Id).Skip(4 * pageno).Take(4).ToList();
            return objList;
        }

        public string Save(TicketType obj)
        {
            try
            {
                if (obj.Id == 0)
                {
                    tblTicketType list = new tblTicketType();

                    list.Id = 5;
                    list.Name = obj.Name;

                    db.tblTicketTypes.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";
                }
                else
                {
                    var o = db.tblTicketTypes.Find(obj.Id);
                    o.Id = obj.Id;
                    o.Name = obj.Name;

                    db.tblTicketTypes.Attach(o);
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
