using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Persona.Models
{
    public class GuardarLeerPersona
    {
        public void Grabar(string nombre, string cedula, string telefonos, string correo)
        {
            StreamWriter file = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            file.WriteLine("Nombre:" + nombre + " <hr>");
            file.WriteLine("Cedula:" + cedula + " <hr>");
            file.WriteLine("Telefonos:" + telefonos + " <hr>");
            file.WriteLine("Correo:" + correo + " <hr>");
            file.Close();
        }

        public string Leer()
        {
            StreamReader file = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            string todo = file.ReadToEnd();
            file.Close();

            return todo;
        }
    }
}