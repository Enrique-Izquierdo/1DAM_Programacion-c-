using System;

namespace AP7_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1, frase2;
            Console.WriteLine("Escribe una frase:");
            frase1 = Console.ReadLine();
            Console.WriteLine("Escribe otra frase:");
            frase2 = Console.ReadLine();

            if (frase1 == frase2)
            {
                Console.WriteLine("Las frases son iguales.");
            }
            else
            {
                Console.WriteLine("Las frases son distintas");
            }

            Console.ReadKey();
        }
    }
}
