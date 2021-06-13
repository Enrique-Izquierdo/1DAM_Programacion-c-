using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_04
{
    class Program
    {
        static void Main(string[] args)
        {
            CMaquina maq1 = new CMaquina(30);            
            CTarjeta tarj1 = new CTarjeta(20);
            CTarjeta tarj2 = new CTarjeta(18);

            Console.WriteLine("{0}", maq1.Extraer(tarj1));
            Console.WriteLine("{0}", maq1.Extraer(tarj2));

            maq1.VerInfo();
            tarj1.VerSaldo();
            tarj2.VerSaldo();

            CMaquina.setPrecio(1.80);
            maq1.VerInfo();
            Console.ReadKey();

        }
    }
}
