using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Explorando_ASP.NET_MVC_5_Prac3.Models;

namespace Explorando_ASP.NET_MVC_5_Prac3.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            var persona = new List<Persona>
            {
                new Persona {ID = "1", Nombre = "Matias", Apellido="Guisseppe", DocumentoIdentidad= "55489653", Direccion= "USA", Sexo="M"},
                new Persona {ID = "2", Nombre = "Johep", Apellido="Bokta", DocumentoIdentidad= "124124df", Direccion= "Dublin", Sexo="M"},
                new Persona {ID = "3", Nombre = "Vikta", Apellido="Putin", DocumentoIdentidad= "12312Rssa", Direccion= "Russia", Sexo="F"},
            };

            return View(persona);
        }
    }
}