using System;
using System.Collections.Generic;

namespace AP7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1, columna = 0;
            do
            {
                Console.Write("{0,8}", numero);
                numero = numero * 2 + 1;
                columna++;
                if (columna == 5)
                {
                    Console.WriteLine("");
                    columna = 0;
                }
            } while (numero < 1000);
            Console.ReadKey();
        }
    }
}
