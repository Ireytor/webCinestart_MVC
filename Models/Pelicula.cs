using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace webCinestart_MVC.Models
{
    public class Pelicula
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string FechaEstreno { get; set; }
        public string Director { get; set; }
        public string Generos { get; set; }
        public int idClasificacion { get; set; }
        public int idEstado { get; set; }
        public string Duracion { get; set; }
        public string Link { get; set; }
        public string Reparto { get; set; }
        public string Sinopsis { get; set; }
        public string Geneross { get; set; } // Columna calculada por getGenerosDetalle

        public Pelicula() { }

        public Pelicula(DataRow dr)
        {
            id = int.Parse(dr["id"].ToString());
            Titulo = dr["Titulo"].ToString();
            FechaEstreno = dr["FechaEstreno"].ToString();
            Director = dr["Director"].ToString();
            Generos = dr["Generos"].ToString();
            idClasificacion = int.Parse(dr["idClasificacion"].ToString());
            idEstado = int.Parse(dr["idEstado"].ToString());
            Duracion = dr["Duracion"].ToString();
            Link = dr["Link"].ToString();
            Reparto = dr["Reparto"].ToString();
            Sinopsis = dr["Sinopsis"].ToString();
            Geneross = dr["Geneross"].ToString();
        }
    }
}