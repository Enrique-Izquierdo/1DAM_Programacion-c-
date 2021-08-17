using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            Console.Write("Introduce el número 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el número 2: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Introduce el número 3: ");
            num3 = double.Parse(Console.ReadLine());

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Los números introducidos no son validos, porque son iguales");
            }
            else if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1.ToString() + " es el mayor de los tres números.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2.ToString() + " es el mayor de los tres números.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3.ToString() + " es el mayor de los tres números.");
            }

            Console.ReadKey();
        }
    }
}
