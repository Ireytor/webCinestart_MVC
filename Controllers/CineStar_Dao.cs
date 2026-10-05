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


        internal Pelicula getPelicula(int id)
        {
            db.Sentencia($"exec sp_getPelicula {id}");
            DataTable dt = db.getDataTable();

            if (dt == null || dt.Rows.Count == 0) return null;

            return new Pelicula(dt.Rows[0]);
        }

        internal List<Pelicula> getPeliculas(int idEstado)
        {
            db.Sentencia($"exec sp_getPeliculas {idEstado}");
            DataTable dt = db.getDataTable();
            if (dt == null) return null;

            List<Pelicula> peliculas = new List<Pelicula>();
            foreach (DataRow dr in dt.Rows)
            {
                peliculas.Add(new Pelicula
                {
                    id = int.Parse(dr["id"].ToString()),
                    Titulo = dr["Titulo"].ToString(),
                    Sinopsis = dr["Sinopsis"].ToString(),
                    Link = dr["Link"].ToString()
                }); 
            }

            return peliculas; 
        }

    }
}