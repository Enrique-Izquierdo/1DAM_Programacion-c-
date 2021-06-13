using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio S1 = new Socio("Pepe", 38, 'H', 82.5, 1.78f);
            Socio S2 = new Socio();

            Console.WriteLine("");

            S1.Informa();
            Console.WriteLine("{0} tiene un peso {1}", S1.Nombre, S1.CalcularIMC());
            if (S1.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }

            Console.WriteLine("");

            S2.Informa();
            Console.WriteLine("{0} tiene un peso {1}", S2.Nombre, S2.CalcularIMC());
            if (S2.EsMayorDeEdad())
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Es menor de edad.");
            }

            Console.ReadLine();
        }
    }
}
