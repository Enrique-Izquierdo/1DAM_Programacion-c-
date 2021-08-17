using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=2; i<=1000; i++)
            {
                bool primo = true;
                for (int j=2; j<i; j++)
                {
                    if (i%j == 0)
                    {
                        primo = false;
                        j = i;
                    }      
                }

                if (primo)
                {
                    Console.Write("{0,4:0},", i);
                }

            }

            Console.ReadKey();

        }
    }
}
