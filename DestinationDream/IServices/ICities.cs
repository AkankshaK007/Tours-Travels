using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DestinationDream.IServices
{
    public interface ICities
    {
        List<tbl_Cities> GetAll();

        tbl_Cities Find(int id);

        bool Delete(int id);

        string Save(tbl_Cities obj);

    }
}