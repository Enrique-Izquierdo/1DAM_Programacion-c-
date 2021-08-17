using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ" , posiString, cadena="";            
            int posicion;
            bool valido;

            do
            {
                Console.Write("Introduce una posición (número entero) del " +
                    "abecedario (-1 finaliza el programa): ");
                posiString = Console.ReadLine();
                valido = int.TryParse(posiString, out posicion);
                if (!valido)
                {
                    Console.WriteLine("Ha introducido un valor No valido.");
                }
                else if (posicion>-1 && posicion<abecedario.Length )
                {
                    cadena += abecedario[posicion];
                }

            } while (posicion != -1);


            Console.Write("Cadena resultante: ");
            foreach (char elemento in cadena)
            {
                Console.Write(elemento.ToString() +", ");
            }

            Console.ReadKey();
        }
    }
}
