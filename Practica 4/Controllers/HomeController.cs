using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Persona.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioDatos()
        {
            return View();
        }

        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefonos = Request.Form["telefonos"].ToString();
            string correo = Request.Form["correo"].ToString();

            var glPersona = new Models.GuardarLeerPersona();
            glPersona.Grabar(nombre, cedula, telefonos, correo);

            return View();
        }


        public ActionResult ListadoDatos()
        {
            var glPersona = new Models.GuardarLeerPersona();
            string todo = glPersona.Leer();
            ViewData["glPersona"] = todo;

            return View();
        }
    }
}