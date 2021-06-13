using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_05
{
    class Program
    {
        private static int CtdadPrestada(List<Publicacion> articulos)
        {
            int acumulado = 0;
            foreach(Publicacion elem in articulos)
            {
                if(elem.Prestado == true) { acumulado++; }                
            }
            return acumulado;
        }

        static void Main(string[] args)
        {
            List<Publicacion> coleccion = new List<Publicacion>();

            coleccion.Add(new Libro(489, "1990", "Tomas"));
            coleccion.Add(new Libro(1897, "2012", "Pepe"));
            coleccion.Add(new Revista(598, "1995", 43));
            coleccion.Add(new Revista(987, "1999", 56));

            foreach (Publicacion elem in coleccion)
            {
                elem.VerInfo();
            }

            Console.WriteLine("\n Número de publicaciones prestadas: {0}", CtdadPrestada(coleccion));
            Console.ReadKey();

            

            coleccion[0].Prestar();
            coleccion[1].Prestar();

            foreach (Publicacion elem in coleccion)
            {
                elem.VerInfo();
            }

            Console.WriteLine("\n Número de publicaciones prestadas: {0}", CtdadPrestada(coleccion));
            Console.ReadKey();

            coleccion[0].Devolver();
            coleccion[1].Devolver();

            foreach (Publicacion elem in coleccion)
            {
                elem.VerInfo();
            }

            Console.WriteLine("\n Número de publicaciones prestadas: {0}", CtdadPrestada(coleccion));
            Console.ReadKey();

        }
    }
}
