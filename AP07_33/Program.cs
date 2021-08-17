using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_33
{
    class Program
    {

        static void CargArray(int[] vector)
        {
            string numString;
            int contador = 0, num, longVector = vector.Length;
            bool valido;
            do
            {
                Console.Write("Introduce un número entero (ocupará la posición {0} del array): ", contador);
                numString = Console.ReadLine();
                valido = int.TryParse(numString, out num);
                if (valido)
                {
                    vector[contador] = num;
                    contador++;
                }
                else
                {
                    Console.WriteLine("El valor introducido NO es un número entero.");
                }
            } while (contador < longVector);
        }

        static void MuestrArray(int[] vector)
        {
            Console.Write("Ha creado el siguiente vector: ");
            foreach (int elemento in vector)
            {
                Console.Write("{0,5},", elemento);
            }
            Console.WriteLine("");
        }

        static bool VerifiCapicua(int[] vector)
        {
            bool capicua = true;

            if (vector.Length % 2 != 0)
            {
                for (int i = 0; i < (vector.Length - 1) / 2; i++)
                {
                    if (vector[i] != vector[vector.Length - 1 - i])
                    {
                        capicua = false;
                    }
                }
            }
            else // Parte necesaria si cambiaramos la longitud del array a un número par.
            {
                for (int i = 0; i < vector.Length / 2; i++)
                {
                    if (vector[i] != vector[vector.Length - 1 - i])
                    {
                        capicua = false;
                    }
                }
            }
            return capicua;
        }


        static void Main(string[] args)
        {
            int longArray = 5;
            int[] entArray = new int[longArray];            
                        
            CargArray(entArray); //La función CargArraya() pasa los parametros calculados por referencia.
            
            MuestrArray(entArray); //La función MuestrArray() visualiza en consola los valores calculados.

            //La función VerifiCapicua devuelve (return) los valores calculados;
            //realiza un paso de parametros por valor: bool nombreVariable = VerifiCapicua(entArray)
            if (VerifiCapicua(entArray))
            {                            
                Console.WriteLine("El vector es capicúa");
            }
            else
            {
                Console.WriteLine("El vector NO es capicúa");
            }

            Console.ReadKey();
        }
    }
}
