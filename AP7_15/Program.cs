using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine("Introduce la contraseña: ");
                string contrasena = Console.ReadLine();
                if (contrasena == "ALDEBARAN")
                {
                    Console.WriteLine("Contraseña correcta");
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    contador++;
                }                
            }

            Console.ReadKey();

        }
    }
}
