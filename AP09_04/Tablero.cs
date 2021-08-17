using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_04
{
    class Tablero
    {
        //atributos (implementación)
        private int tamanyo_X ;
        private int tamanyo_Y;

        //constructores (interface)
        public Tablero(int maxDim_X, int maxDim_Y)
        {
            tamanyo_X = maxDim_X;
            this.tamanyo_Y = maxDim_Y;
        }

        public Tablero()
        {
            Console.WriteLine("\nIntroduzca dimensiones Tablero" +
                              "\n==============================");
            Console.Write("Dimension eje X: ");
            tamanyo_X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dimension eje Y: ");
            tamanyo_Y = Convert.ToInt32(Console.ReadLine());
        }

        //propiedades (interface)
        public int Tamanyo_X
        {
            get
            {
                return tamanyo_X;
            }
        }

        public int Tamanyo_Y
        {
            get
            {
                return tamanyo_Y;
            }
        }

        //métodos de acceso (interface)
        public void VerTamayo()
        {
            Console.WriteLine("Dimensionesiones tablero: {0} unidades en eje X," +
                " {1} unidades en eje Y", tamanyo_X, tamanyo_Y);
        }


        //métodos privados (implementación)
    }
}
