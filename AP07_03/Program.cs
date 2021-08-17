using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacidadHD;
            int numCD;
            Console.Write("Introduce capacidad disco duro en GygaBytes: ");
            capacidadHD = double.Parse(Console.ReadLine());
            capacidadHD = capacidadHD * 1024;
            numCD = (int) Math.Truncate(capacidadHD / 700) + 1;
            //Console.Write("Necesita " + numCD.ToString() + " CDs.");
            //Console.Write("Necesita {0} CDs.", numCD);
            Console.Write($"Necesita {numCD} CDs.");
            Console.ReadKey();
        }
    }
}
