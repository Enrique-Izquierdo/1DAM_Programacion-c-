using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_26
{
    class Program
    {
        static bool Primo(uint valor)
        {
            for (int i=2; i<valor; i++)
            {
                if (valor%i == 0)
                {
                    return false;                    
                }                
            }
            return true;
        }

        static void Main(string[] args)
        {
            string numString;
            uint numero;
            bool valido;
            do
            {
                Console.Write("Introduce por teclado un número entero positivo: ");
                numString = Console.ReadLine();
                valido = uint.TryParse(numString, out numero);
                if (!valido)
                {
                    Console.WriteLine("El valor introducido NO es valido.");
                }
            } while (!valido);

            if (Primo(numero))
            {
                Console.WriteLine("{0} es un número primo.", numero);
            }
            else
            {
                Console.WriteLine("{0} es un número compuesto.", numero);
            }

            Console.ReadKey();
        }
    }
}
