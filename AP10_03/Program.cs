using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string tituloPeli;
            int anyoEstreno;
            List<CActor> reparto1 = new List<CActor>();
            string continuar;
            CPelicula peli1;
            
            Console.Write("Introduce el título de la película: ");
            tituloPeli = Console.ReadLine();

            Console.Write("Introduce el año de estreno: ");
            anyoEstreno = int.Parse(Console.ReadLine());

            do
            {
                string nombreActor;
                int anyoNac;
                CActor actor;

                Console.Write("\nIntroduce nombre del actor: ");
                nombreActor = Console.ReadLine();
                Console.Write("Introduce año de nacimiento del actor: ");
                anyoNac = Convert.ToInt32(Console.ReadLine());

                actor = new CActor(nombreActor, anyoNac);
                reparto1.Add(actor);

                Console.Write("¿Desea introducir los datos de otro actor (Y/N)? ");
                continuar = Console.ReadLine().ToUpper();
            } while (continuar == "Y");

            peli1 = new CPelicula(tituloPeli, anyoEstreno, reparto1);

            Console.WriteLine("\nListado de actores que participarón en la " +
                "película {0}, siendo menores de edad:", tituloPeli); 
            foreach(CActor elem in peli1.getActoresMenores18())
            {
                elem.VerDatosActor();
            }

            peli1.EdadActoresPeli();

            Console.ReadKey();
        }
    }
}
