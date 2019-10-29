using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Explorando_ASP.NET_MVC_5_Prac3.Models;

namespace Explorando_ASP.NET_MVC_5_Prac3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var coches = new List<Coche>
            {
                new Coche{Tipo= "Jeep", Marca="BMW", Modelo="X6", Color="Azul"},
                new Coche{Tipo= "Auto", Marca="Mercedes", Modelo="AZ00", Color="Blanco"},
                new Coche{Tipo= "Ferrari", Marca="Enzo", Modelo="EZ01", Color="Rojo"}
            };

            return View(coches);
        }
    }
}