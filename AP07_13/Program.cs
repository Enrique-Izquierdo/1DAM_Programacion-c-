using System;
using System.Collections.Generic;

namespace AP7_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combi = new int[6];
            Random rnd = new Random();

            for (int i=0; i<6; i++)
            {
                combi[i] = rnd.Next(1, 50);
                Console.Write("{0,4}", combi[i]);
            }
                        
            Console.ReadKey();
        }
    }
}
