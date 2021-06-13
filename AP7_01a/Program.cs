using System;

namespace AP7_01a
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool pedirNumero;
            do
            {
                pedirNumero = true;
                Console.Write("Dame un número entre 1 y 10: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 1 && numero <= 10)
                {
                    pedirNumero = false;
                }
            } while (pedirNumero);

            //Console.WriteLine("Número correcto");
            //Console.ReadKey();

            switch (numero)
            {
                case 1:
                    Console.Write(numero.ToString() + " es igual a I");
                    break;
                case 2:
                    Console.Write(numero.ToString() + " es igual a II");
                    break;
                case 3:
                    Console.Write(numero.ToString() + " es igual a III");
                    break;
                case 4:
                    Console.Write(numero.ToString() + " es igual a IV");
                    break;
                case 5:
                    Console.Write(numero.ToString() + " es igual a V");
                    break;
                case 6:
                    Console.Write(numero.ToString() + " es igual a VI");
                    break;
                case 7:
                    Console.Write(numero.ToString() + " es igual a VII");
                    break;
                case 8:
                    Console.Write(numero.ToString() + " es igual a VIII");
                    break;
                case 9:
                    Console.Write(numero.ToString() + " es igual a IX");
                    break;
                case 10:
                    Console.Write(numero.ToString() + " es igual a X");
                    break;
                default:
                    Console.Write("Error inesperado");
                    break;
            }
            Console.ReadKey();
        }
    }
}
