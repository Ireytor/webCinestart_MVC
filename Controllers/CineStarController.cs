using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace webCinestart_MVC.Controllers
{
    public class CineStarController : Controller
    {
        CineStar_Dao cineStar_Dao = new CineStar_Dao();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cine()
        {
            return View(cineStar_Dao.getCines());
        }

        public ActionResult Pelicula(int id)
        {
            var peli = cineStar_Dao.getPelicula(id);
            return View(peli);
        }

        public ActionResult Peliculas(string id)
        {
            int idEstado = (id == "cartelera") ? 1 : 2;
            var peliculas = cineStar_Dao.getPeliculas(idEstado);
            ViewBag.Titulo = (id == "cartelera") ? "Cartelera" : "Próximos Estrenos";
            return View(peliculas);
        }
    }
}