using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_32
{
    class Program
    {
        static void CargArray(int[] vector1, double[] vector2)
        {
            Random aleatorio = new Random();
            int num = vector1.Length;
            for (int i=0; i<num; i++)
            {
                vector1[i] = aleatorio.Next(20);
                vector2[i] = aleatorio.NextDouble()*20;
            }
        }

        static double[] SumArray(int[] vector1, double[] vector2)
        {
            int num = vector1.Length;
            double[] vector3 = new double[num];
            for (int i=0; i<num; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
            return vector3;
        }

        static void MuestrArrays(int[] vector1, double[] vector2, double[] vector3)
        {
            for (int i=0; i<vector3.Length; i++)
            {
                Console.WriteLine("{0,5} + {1,5:N} = {2,5:N}", vector1[i], vector2[i], vector3[i]);
            }
        }

        static void Main(string[] args)
        {
            int elementos = 10;
            int[] array1 = new int[elementos];
            double[] array2 = new double[elementos];
            double[] array3;

            //Función que entrega los datos mediante un paso de parametros por referencia.
            CargArray(array1, array2);

            //Función que devuelve los datos mediante un return (paso de parametros por valor).
            array3 = SumArray(array1, array2);

            //Función que visualiza los datos en consola.
            MuestrArrays(array1, array2, array3);

            Console.ReadKey();
        }
    }
}
