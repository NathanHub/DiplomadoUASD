using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Explorando_ASP.NET_MVC_5_Prac3.Models
{
    public class Persona
    {
        public string ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DocumentoIdentidad { get; set; }

        public string Sexo { get; set; }

        public string Direccion { get; set; }
    }
}