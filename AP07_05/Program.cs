using System;

namespace AP7_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;
            Console.Write("Introduce la longitud del lado 1: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce la longitud del lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la longitud del lado 3: ");
            lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Triangulo equilatero");
            }
            else if (lado1 == lado2 && lado2 != lado3)
            {
                Console.WriteLine("Triangulo isosceles");
            }
            else if (lado1 != lado2 && lado1 != lado3)
            {
                Console.WriteLine("Triangulo escaleno");
            }
            Console.ReadKey();
        }
    }
}
