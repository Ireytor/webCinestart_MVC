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
    }
}