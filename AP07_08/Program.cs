using System;

namespace AP7_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, acumulador = 0;
            Console.Write("Introduce un número entero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=num2; i++)
            {
                acumulador += num1;
            }

            Console.WriteLine("{0} x {1} = {2}", num1, num2, acumulador);
            Console.ReadKey();
        }
    }
}
