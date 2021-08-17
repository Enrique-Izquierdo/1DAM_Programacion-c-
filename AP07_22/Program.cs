using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_22
{
    class Program
    {
        static float DiferenciaEdad(List<float> edadList)
        {
            /**
             * Ordenando la List<T> mediante el método .Sort().
            */                        
            //edadList.Sort();
            
            /**
             * Utilizando un algoritmo de ordenación. 
             * Nota: Al tratarse de una List<T> de 2 elementos,
             * la repetitiva exterior no es necesaria.
             */
            float mayor;
            for (int j = 1; j <= edadList.Count; j++)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (edadList[i] > edadList[(i+1)])
                    {
                        mayor = edadList[i];
                        edadList[i] = edadList[(i+1)];
                        edadList[(i+1)] = mayor;
                    }
                }
            }

            return edadList[1]-edadList[0];
        }
         

        static void Main(string[] args)
        {
            int contador = 1;
            string anyoString;
            float anyos;
            bool valido;
            List<float> anyosList = new List<float>();

            do
            {
                Console.Write("Introduce la edad, en años, del hermano {0}: ", contador);
                anyoString = Console.ReadLine();
                valido = float.TryParse(anyoString, out anyos);
                if (valido && anyos >= 0)
                {
                    anyosList.Add(anyos);
                    contador++;
                }
                else
                {
                    Console.WriteLine("El valor introducido no es valido.");
                }
            } while (contador < 3);

            Console.WriteLine("La diferencia de edad entre los dos hermanos es de {0} años",
                DiferenciaEdad(anyosList));
            Console.ReadKey();

        }
    }
}
