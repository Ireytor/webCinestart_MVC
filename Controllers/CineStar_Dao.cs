using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using webCinestart_MVC.Models;

namespace webCinestart_MVC.Controllers
{
    public class CineStar_Dao
    {
        Db db = new Db("cnCinestar");

        internal List<Cine> getCines()
        {
            db.Sentencia("sp_getCines");
            DataTable dt = db.getDataTable();
            if (dt == null) return null;

            List<Cine> cines = new List<Cine>();
            foreach (DataRow dr in dt.Rows)
            
                cines.Add(new Cine(dr));
            return cines;
        }
    }
}