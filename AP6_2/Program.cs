using System;

namespace AP6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la medida en metros: ");
            double metros = double.Parse(Console.ReadLine());
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;
            Console.WriteLine(metros.ToString("0.00") + " metros, equivale a " + centimetros.ToString("0.00") + " centimetros, " + 
                pulgadas.ToString("0.00") + " pulgadas, " + pies.ToString("0.00") + " pies, o " + yardas.ToString("0.00") + " yardas");
            Console.ReadKey();
        }
    }
}
