using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrilatero c1 = new Cuadrilatero(3, 5);
            Cuadrilatero c2 = new Cuadrilatero(3);

            ArrayList vectorCuad = new ArrayList();
            vectorCuad.Add(c1);
            vectorCuad.Add(c2);

            foreach (Cuadrilatero elemento in vectorCuad)
            {
                Console.WriteLine("\nEl cuadrilatero de {0} por {1} tiene una superficie " +
                    "de {2} unidades al cuadrado y un perimetro de {3} unidades."
                    , elemento.LadoA, elemento.LadoB, elemento.Superficie(), elemento.Perimetro());
            }

            Console.ReadLine();

        }
    }
}
