using DestinationDream.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.IServices
{
    public interface ICountry
    {
        List<tblCountry> GetAll();

        tblCountry Find(int id);

        bool Delete(int id);

        bool Save(Countries obj);
    }
}