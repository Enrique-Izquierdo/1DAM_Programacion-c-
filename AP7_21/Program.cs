using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_21
{
    class Program
    {
        static bool EsMultiplo(int valor)
        {
            if (valor % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string numeroString;
            int numero;
            bool valido;

            do
            { 
                Console.Write("Introduce un número: ");
                numeroString = Console.ReadLine();
                valido = int.TryParse(numeroString, out numero);
                if (!valido)
                {
                    Console.WriteLine("El valor introducido no es valido.");
                }
            } while (!valido);

            if (EsMultiplo(numero))
            {
                Console.WriteLine("{0} es multiplo de 10.", numero);
            }
            else
            {
                Console.WriteLine("{0} NO es multiplo de 10.", numero);
            }

            Console.ReadKey();
        }
    }
}
