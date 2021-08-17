using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            string caract;
            char c;

            do
            {
                Console.Write("Teclea un caracter: ");
                caract = Console.ReadLine();

                if(caract.Length == 1)
                {
                    c = Convert.ToChar(caract);
                    if (char.IsNumber(c))
                    {
                        acumulador++;
                    }
                } else
                {
                    Console.WriteLine("Ha introducido más de un caracter.");
                }
                
            } while (caract != ".");

            Console.WriteLine("Ha introducido {0} caracteres entre 0 y 9.", acumulador);
            Console.ReadKey();

        }
    }
}
