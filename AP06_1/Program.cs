using System;

namespace AP6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ** PROMEDIO DE NOTAS ** ");
            Console.WriteLine(" ");

            string alumno;
            int nota1, nota2, nota3;

            Console.Write("Ingrese nombre del alumno: ");
            alumno = Console.ReadLine();
            Console.Write("Ingrese la nota1 sin decimales: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota2 sin decimales: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la nota3 sin decimales: ");
            nota3 = int.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("El promedio de " + alumno +" es "+ promedio.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
