using System;

namespace AP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CAPITAL DE LA EMPRESA \n");
            double monto1, monto2, monto3, capital, pSoc1, pSoc2, pSoc3;
            
            Console.Write("Ingrese el aporte del socio 1: ");
            monto1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el aporte del socio 2: ");
            monto2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el aporte del socio 3: ");
            monto3 = Convert.ToDouble(Console.ReadLine());

            capital = monto1 + monto2 + monto3;

            pSoc1 = monto1 * 100 / capital;
            pSoc2 = monto2 * 100 / capital;
            pSoc3 = monto3 * 100 / capital;

            Console.WriteLine("Capital total aportado: " + capital.ToString("0.00"));
            Console.WriteLine("Porcentaje socio 1: " + pSoc1.ToString("0.00")+ "%");
            Console.WriteLine("Porcentaje socio 2: " + pSoc2.ToString("0.00") + "%");
            Console.WriteLine("Porcentaje socio 3: " + pSoc3.ToString("0.00") + "%");
            Console.ReadKey();
        }
    }
}
