using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_35
{
    class Program
    {
        /**
         * El elemento obtenido de un array de elementos de tipo string, 
         * es un string, aunque el elemento este formado por un solo caracter.
         * ATENCIÓN al tipo (string) declarado para los valores devueltos por la función
         * static STRING ObtenerLetra();
         */
        private static string ObtenerLetra(string cadenaNumerica)
        {
            string[] letrasDni = new string[23] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D",
                "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};
            int numLetra;
            numLetra = Convert.ToInt32(cadenaNumerica) % 23;
            return letrasDni[numLetra];
        }

        /**
         * El caracter obtenido de una cadena (string) a traves de su posición, 
         * es de tipo char (no es un string).
         * ATENCIÓN al tipo (char) declarado para los valores devueltos por la función
         * static CHAR ObtenerLetra();
         */
        //private static char ObtenerLetra(string cadenaNumerica)
        //{
        //    string letrasDni = "TRWAGMYFPDXBNJZSQVHLCKE";
        //    int numLetra;
        //    numLetra = Convert.ToInt32(cadenaNumerica) % 23;
        //    return letrasDni[numLetra];
        //}


        static void Main(string[] args)
        {
            string numDni;            
            bool valido;
            
            do
            {
                Console.Write("Introduce un número de DNI: ");
                numDni = Console.ReadLine();
                valido = uint.TryParse(numDni, out _);
                if (!valido)
                {
                    Console.WriteLine("Número introducido no válido, por contener letras o signos.");
                }
                else if (numDni.Length != 8)
                {
                    Console.WriteLine("Número introducido no válido, por no contener 8 digitos.");
                }

            } while (!valido || numDni.Length!=8);

            Console.WriteLine(numDni + ObtenerLetra(numDni));

            Console.ReadKey();

        }
    }
}
