using System;
using System.Collections;
using System.Collections.Generic;

namespace AP7_11
{
    class Program
    {
        static int[] CalcTotalParImp(ArrayList numer)
        {
            int parTotal = 0, impTotal = 0;
            int[] totalParImp = new int[2];
            foreach (int elemento in numer)
            {
                if (elemento%2 == 0)
                {
                    parTotal++;
                }
                else
                {
                    impTotal++;
                }
            }
            totalParImp[0] = parTotal;
            totalParImp[1] = impTotal;
            return totalParImp;
        }
        
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            int num;
            bool continuar = true;
            int[] ctdadParImpar = new int[2];
            do
            {
                Console.Write("Introduce un número entero (0 finaliza el proceso): ");
                num = Convert.ToInt32(Console.ReadLine());
                if ( num != 0 )
                {
                    numeros.Add(num);
                } else
                {
                    continuar = false;
                }
            } while ( continuar );

            ctdadParImpar = CalcTotalParImp(numeros);

            Console.WriteLine("Ha introducido {0} numeros: {1} pares y {2} impares", numeros.Count, ctdadParImpar[0], ctdadParImpar[1]);
            Console.ReadKey();
        }
    }
}
