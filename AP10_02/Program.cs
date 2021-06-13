using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombresFunciones = new string[4] { "Azul", "Violetas", "Tierra", "Mariposas" };
            double[] preciosFunciones = new double[4] { 8, 10, 5, 7 };

            CTeatro teatroMaravillas = new CTeatro("Maravillas", "calle Poveda", 
                nombresFunciones, preciosFunciones);

            Console.WriteLine("Funciones en el teatro {0}, " +
                "{1}:", teatroMaravillas.getNombreTeatro(), teatroMaravillas.getDireccionTeatro());
            for (int i=0; i<teatroMaravillas.getArraryFunciones().Length; i++)
            {
                Console.WriteLine("{0}, {1} euros", teatroMaravillas.getNombreFuncion_Teatro(i), 
                    teatroMaravillas.getPrecioFuncion_Teatro(i));
            }

            Console.Write("\nIndique la primera letra de la función: ");
            teatroMaravillas.BuscadorPorLetraDeFunciones_Teatro(char.Parse(Console.ReadLine().ToUpper()));

            Console.ReadKey();
        }
    }
}
