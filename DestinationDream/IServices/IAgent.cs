using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.IServices
{
    public interface IAgent
    {
        bool Delete(int id);

        dynamic FindS(int id);

        dynamic GetAll(string key);
        dynamic GetAllc(int pageno);     

        string Save(Agent obj);
    }
}