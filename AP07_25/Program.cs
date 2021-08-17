using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_25
{
    class Program
    {
        static uint CalculoSuma(List<uint> numLisT)
        {
            uint acumulador = 0;
            numLisT.Sort();
            for (uint i = numLisT[0]; i <= numLisT[1]; i++)
            {
                if (i%2 == 0)
                {
                    acumulador += i;
                }
            }
            return acumulador;
        }

        static void Main(string[] args)
        {
            int i = 0;
            string numString;
            bool valido;
            uint num;
            List<uint> numeros = new List<uint>();
            
            do
            {
                Console.Write("Introduce el número {0}º: ", i+1);
                numString = Console.ReadLine();
                valido = uint.TryParse(numString, out num);
                if (valido)
                {
                    numeros.Add(num);
                    i++;
                }
                else
                {
                    Console.WriteLine("El número tecleado no es valido.");
                }
            } while (!valido || i <= 1);

            Console.WriteLine("La suma de los números pares comprendidos entre {0} y {1} es: {2}"
                , numeros[0], numeros[1], CalculoSuma(numeros));            
            
            Console.ReadKey();
        }
    }
}
