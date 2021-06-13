using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];
            for (int i=0; i<5; i++)
            {
                Console.Write("Introduce un número entero que ocupará la {0}º posición del array: ", i+1);
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int acumulador = 0;

            foreach(int valor in numArray)
            {
                acumulador += valor;
            }

            Console.WriteLine("La media aritmetica es: {0:N}", acumulador / numArray.Length);
            Console.ReadKey();
        }
    }
}
