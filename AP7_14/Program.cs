using System;
using System.Collections;
using System.Collections.Generic;

namespace AP7_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> listaNumeros = new List<uint>();
            int i = 0, acumulador = 0;
            string numString;
            uint numero;
            bool canConvert;

            do
            {
                Console.Write("Escribe un número entero positivo: ");
                numString = Console.ReadLine();
                canConvert = uint.TryParse(numString, out numero);
                if (canConvert == true)
                {
                    Console.WriteLine("Ha introducido el numero {0}.", numero);
                    listaNumeros.Add(numero);
                    i++;
                }
                else
                {
                    Console.WriteLine("{0}, no es un valor valido.", numString);
                }

            } while (i < 2);

            listaNumeros.Sort();

            Console.Write("Ha introducido los siguientes números:");
            foreach(uint elemento in listaNumeros)
            {
                Console.Write("{0,4}",elemento);
            }
            Console.WriteLine("");

            for ( uint j = listaNumeros[0]; j <= listaNumeros[1]; j++ )
            {
                if ( j%2 != 0 )
                {
                    Console.Write("{0,4:0},", j);
                    acumulador++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("El sumatoria de los números impares entre {0} y {1} es {2}.",
                                  listaNumeros[0], listaNumeros[1], acumulador);

            Console.ReadKey();

        }
    }
}
