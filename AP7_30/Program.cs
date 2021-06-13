using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_30
{
    class Program
    {
        static void RellenArray(int[] entArray, int numElementos)
        {
            for (int i=0; i<numElementos; i++)
            {
                Console.Write("Introduce el número entero, que ocupará la posición {0} del array: ", i + 1);
                entArray[i] = int.Parse(Console.ReadLine());
            }
        }

        static void EsParImpar(int[] entMatriz)
        {
            int acumuPar = 0, acumuImpar = 0;
            for(int i=0; i<entMatriz.Length; i++)
            {
                if (entMatriz[i]%2 == 0)
                {
                    acumuPar++;
                }
                else
                {
                    acumuImpar++;
                }                
            }
            Console.WriteLine("El array contiene {0} números pares, y {1} impares.", acumuPar, acumuImpar);
        }

        static void Main(string[] args)
        {
            int numVector = 10;
            int[] entVector = new int[numVector];

            /** 
             * Realizamos un paso de parametros por referencia del array entVector, para que
             * en él se guarde el array calculado por la función RellenArray().
             * Al no devolver (return) la función ningún valor, 
             * la función RellenArray() es de tipo void (vacio).
             */ 
            RellenArray(entVector, numVector);

            /** 
             * La función EsParImpar() es de tipo void (vacio),
             * porque visualiza los datos (no los devuelve (return)); 
             */
            EsParImpar(entVector);

            Console.ReadKey();



            
        }
    }
}
