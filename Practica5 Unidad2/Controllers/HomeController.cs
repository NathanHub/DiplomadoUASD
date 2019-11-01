using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica5Unidad2.Models;

namespace Practica5Unidad2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var peliculas = new List<Pelicula>
            {
                new Pelicula{Titulo ="The GodFather", Director="Francis Ford Copola", ActorPrincipal="Al Pacino",
                NumeroActores=30, Duracion =2, AnioEstreno=1994},

                new Pelicula{Titulo ="The Shanwshank", Director="Frank Darabont", ActorPrincipal="Morgan Freeman",
                NumeroActores=15, Duracion =3, AnioEstreno=1972},

                new Pelicula{Titulo ="The Matrix", Director="Lana Wachowski", ActorPrincipal="Keanu Reeves",
                NumeroActores=15, Duracion =2.30, AnioEstreno=1999},

                new Pelicula{Titulo ="City Of God", Director="Fernando Meirelles", ActorPrincipal="Alexandre Rodrigues",
                NumeroActores=10, Duracion =3, AnioEstreno=2002}

            };

            var peliculasConThe = from Pelicula in peliculas
                                  where Pelicula.Titulo.Contains("The")
                                  select Pelicula;

            return View(peliculasConThe);
        }

        [HttpPost]
        public ActionResult Productos()
        {
            var productos = new List<Producto> {
                   new Producto{ID=1, Descripcion="Boligrafo", Precio= 3.5},
                   new Producto{ID=2, Descripcion="Cuaderno Grande", Precio=8.99},
                   new Producto{ID=3, Descripcion="Cuaderno Pequeño", Precio=12.99},
                   new Producto{ID=4, Descripcion="Folios 50 uds", Precio=30.5},
                   new Producto{ID=5, Descripcion="Grapadoras", Precio=8.47},
                   new Producto{ID=6, Descripcion="Tijeras", Precio=9.78},
                   new Producto{ID=7, Descripcion="Cinta Adhesiva", Precio=15.40},
                   new Producto{ID=8, Descripcion="Rotulador", Precio=50.80},
                   new Producto{ID=9, Descripcion="Mochila Escolar", Precio=230.88},
                   new Producto{ID=10, Descripcion="Lapices", Precio=7.79}
            };

            // Productos que contengan I
            var prodsConI = from Producto in productos
                            where Producto.Descripcion.Contains("i")
                            select Producto;

         // Productos que inicien con C 
            var prodsInicienConC = from Producto in productos
                            where Producto.Descripcion.StartsWith("C")
                            select Producto;

            // Productos que finalicen con O
            var prodsTerminenConO = from Producto in productos
                            where Producto.Descripcion.EndsWith("o")
                            select Producto;

            // Productos con precios mayor a 20
            var prodsConPrecionMayorA20 = from Producto in productos
                            where Producto.Precio > 20.0
                            select Producto;

            // Productos con precios menor a 20
            var prodsConPrecionMenorA70 = from Producto in productos
                                          where Producto.Precio < 70.0
                                          select Producto;
            

            return View(prodsConPrecionMayorA20);
        }
    }
}