using DestinationDream.IServices;
using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.Services
{
    public class AgentRepo : IAgent
    {
        TravelAgencyEntities db = new TravelAgencyEntities();

        public bool Delete(int id)
        {
            var obj = db.tblAgents.Find(id);
            if (obj != null)
            {
                db.tblAgents.Remove(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public dynamic FindS(int id)
        {
            var obj = db.tblAgents.Select(s => new { s.Id, s.AgentCode,s.Name, s.MobileNo,s.IsActive }).Where(w => w.Id == id).FirstOrDefault();
            if (obj != null)
            {

                return obj;
            }
            return null;
        }

        public dynamic GetAll(string key)
        {
            if (key!="")
            {
				var objList = db.tblAgents.Select(s => new { s.Id, s.AgentCode, s.Name, s.MobileNo, s.IsActive }).Where(w => w.Name.Contains(key)).ToList();
				return objList;
			}
            else
            {
				var objList = db.tblAgents.Select(s => new { s.Id, s.AgentCode, s.Name, s.MobileNo, s.IsActive }).OrderByDescending(o => o.Id).Skip(6 * 0).Take(6).ToList();
				return objList;
			}

			return null;
		}

        public dynamic GetAllc(int pageno)
        {
            var objList = db.tblAgents.Select(s => new { s.Id, s.AgentCode, s.Name, s.MobileNo , s.IsActive}).OrderByDescending(o => o.Id).Skip(6 * pageno).Take(6).ToList();
            return objList;
        }

        public string Save(Agent obj)
        {
            try
            {
                if (obj.Id == 0)
                {

                    tblAgent list = new tblAgent();

                    list.Id = obj.Id;
                    list.AgentCode = obj.AgentCode;
                    list.Name = obj.Name;                   
                    list.MobileNo = obj.MobileNo;

					//obj.IsActive = false;
					list.IsActive = true;

					if (obj.IsActive == false)
                    {
						list.IsActive = false;
					}

                
					db.tblAgents.Add(list);
                    db.SaveChanges();
                    return "Save Successfully";
                }
                else
                {
                    var o = db.tblAgents.Find(obj.Id);
                    o.Id = obj.Id;
                    o.AgentCode = obj.AgentCode;
                    o.Name = obj.Name;
                    o.MobileNo = obj.MobileNo;
                    o.IsActive = obj.IsActive;
                    db.tblAgents.Attach(o);
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