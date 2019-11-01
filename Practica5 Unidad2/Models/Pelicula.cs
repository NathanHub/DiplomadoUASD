using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica5Unidad2.Models
{
    public class Pelicula
    {
        public string Titulo { get; set; }

        public string Director { get; set; }

        public string ActorPrincipal { get; set; }

        public int NumeroActores { get; set; }

        public double Duracion { get; set; }

        public int AnioEstreno { get; set; }

    }
}