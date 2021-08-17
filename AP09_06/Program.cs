using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_06
{
    class Program
    {
        static Circulo CirculoMayor (Circulo[] array)
        {
            int posMayor = 0;
            
            for (int i=0; i<array.Length-1; i++)
            {
                if (array[i].Radio < array[i + 1].Radio)
                {
                    posMayor = i + 1;
                }
            }

            return array[posMayor];
        }
        
        
        static void Main(string[] args)
        {
            Circulo[] arrayCirculos = new Circulo[2];
            double[] vRadio = new double[] {5,12};

            //Console.WriteLine("{0}", arrayCirculos.Length);
            
            for (int i=0; i < arrayCirculos.Length; i++)
            {
                arrayCirculos[i] = new Circulo(vRadio[i]);
                //Circulo circ = new Circulo(vRadio[i]);
                //arrayCirculos[i] = circ;

            }

            foreach (Circulo elemento in arrayCirculos)
            {
                Console.WriteLine("\nEl circulo de radio {0} tiene un perímetro" +
                    " de {1:N} unidades y un área de {2:N} unidades al cuadrado."
                    , elemento.Radio, elemento.Perimetro(), elemento.Area());
            }


            Circulo circMayor = CirculoMayor(arrayCirculos);

            Console.WriteLine("\n{0:N} unidades de diametro tiene el circulo de" +
                " mayor tamaño.", circMayor.Radio * 2);

            Console.ReadLine();

        }
    }
}
