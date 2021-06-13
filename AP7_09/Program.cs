using System;
using System.Collections;
using System.Collections.Generic;  

namespace AP7_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMenor, numMayor, valor;
            string concatMultiplos;

            numMenor = 1;
            numMayor = 100;
            valor = 3;
            ArrayList multiplos = new ArrayList();

            for (int i=numMenor; i<=numMayor; i++)
            {
                if (i%valor==0)
                {
                    multiplos.Add(i);
                }
            }


            concatMultiplos = "";

            for (int i=0; i<multiplos.Count; i++)
            {
                concatMultiplos += Convert.ToString(multiplos[i]) + ", ";
            }

            Console.WriteLine(concatMultiplos);
            Console.ReadKey();
        }
    }
}
