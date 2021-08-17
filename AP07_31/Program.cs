using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_31
{
    class Program
    {
        static void RellenaLista(List<int> lista)
        {
            string numString;
            int num;
            bool valido;
            Console.WriteLine("Inicio nuevo proceso de introducción de datos.");
            do
            {
                Console.Write("Introduce un número entero (0 para finalizar el proceso): ");
                numString = Console.ReadLine();
                valido = int.TryParse(numString, out num);
                if (!valido)
                {
                    Console.WriteLine("Valor introducido NO valido");                     
                }
                else if (num != 0)
                {
                    lista.Add(num);
                }
            } while (!valido || num != 0);
            Console.WriteLine("Finalización del proceso de introducción de datos.\n");
        }


        static void MultiplicaLista(List<int> numList_1, List<int> numList_2)
        {
            if (numList_1.Count == numList_2.Count)
            {
                for(int i=0; i<numList_1.Count; i++)
                {
                    Console.WriteLine("Posición {0}: {1} x {2} = {3}",
                        i + 1, numList_1[i], numList_2[i], numList_1[i] * numList_2[i]);
                }
            }
            else
            {
                Console.WriteLine("Las listas proporcionadas no tienen la misma longitud.");
            }
        }

        static void Main(string[] args)
        {
            List<int> list_1 = new List<int>();
            List<int> list_2 = new List<int>();

            // Llamado a función que efectúa el paso de parametros por referencia.
            RellenaLista(list_1);
            RellenaLista(list_2);

            // Llamada a función que visualiza por pantalla el resultado.
            MultiplicaLista(list_1, list_2);

            Console.ReadKey();
        }
    }
}
