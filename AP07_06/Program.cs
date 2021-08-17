using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Método A */

            //string[] vocales = { "a", "e", "i", "o", "u" };
            //string vocal;
            //int posVocal = -1;

            //Console.Write("Dame una vocal: ");
            //vocal = Console.ReadLine();
            //vocal = vocal.ToLower();

            //for (int i = 0; i < vocales.Length; i++)
            //{
            //    if (vocales[i] == vocal)
            //    {
            //        posVocal = i + 1;
            //    }
            //}

            //if (posVocal == -1)
            //{
            //    Console.WriteLine("{0} no es una vocal.", vocal);
            //}
            //else
            //{
            //    Console.WriteLine("La letra {0} ocupa la posición {1}.", vocal, posVocal);
            //}

            //Console.ReadKey();


            /**Método B*/

            string vocal, vocales = "aeiou";
            int posVocal;

            Console.Write("Dame una vocal: ");
            vocal = Console.ReadLine();
            vocal = vocal.ToLower();


            posVocal = vocales.IndexOf(vocal);

            if (posVocal == -1)
            {
                Console.WriteLine("{0} no es una vocal.", vocal);
            }
            else
            {
                Console.WriteLine("La letra {0} ocupa la posición {1}.", vocal, posVocal + 1);
            }

            Console.ReadKey();

        }
    }
}
