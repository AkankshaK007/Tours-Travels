using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.IServices
{
    public interface ICompanyType
    {
        dynamic GetAllc(int pageno);

        dynamic GetAll(string key);
        dynamic FindS(int id);

        bool Delete(int id);

        string Save(CompanyType obj);
    }
}