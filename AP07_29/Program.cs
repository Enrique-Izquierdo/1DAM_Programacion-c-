using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_29
{
    class Program
    {
        static int[] RellenArray(int numElementos)
        {
            int[] enterosArray = new int[numElementos];
            for(int i=0; i<numElementos; i++)
            {
                Console.Write("Introduce un número entero, que ocupará la posición {0} del array: ", i+1);
                enterosArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return enterosArray;
        }

        static void MostrarArray(int[] matriz)
        {
            Console.WriteLine("\tIndice\tValor");
            for (int i=0; i<matriz.Length; i++)
            {
                Console.WriteLine("\t{0}\t{1}", i, matriz[i]);
            }
        }

        static void Main(string[] args)
        {
            int elementosArray = 10;

            MostrarArray(RellenArray(elementosArray));

            Console.ReadKey();



        }
    }
}
