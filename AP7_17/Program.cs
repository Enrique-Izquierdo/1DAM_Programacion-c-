using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string numString;
            uint numero;
            bool validacion, pedirNumero = true;
            int intentos = 0;
            int numCorrecto = rnd.Next(1, 101);

            while (pedirNumero)
            {
                Console.Write("Introduce un número entre 1 y 100: ");
                numString = Console.ReadLine();
                validacion = uint.TryParse(numString, out numero);
                intentos++;

                if (validacion == true && numero == numCorrecto)
                {
                    Console.WriteLine("Ha acertado el número en el intento {0}.", intentos);
                    pedirNumero = false;
                }
                else if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("El valor introducido no es un numero entre 1 y 100.");
                }
                else if (numero < numCorrecto)
                {
                    Console.WriteLine("El número a adivinar es mayor.");
                }
                else
                {
                    Console.WriteLine("El número a adivinar es menor.");
                }
            }
            Console.ReadKey();
        }
    }
}
