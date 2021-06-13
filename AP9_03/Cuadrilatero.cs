using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_03
{
    class Cuadrilatero
    {
        //atributos
        private double lado1;
        private double lado2;

        //constructores
        public Cuadrilatero(double cLado1, double lado2)
        {
            lado1 = cLado1;
            this.lado2 = lado2;
        }

        public Cuadrilatero(double lado1)
        {
            this.lado1 = lado1;
            lado2 = lado1;
        }

        //propiedades
        public double LadoA
        {
            get
            {
                return this.lado1;
            }
        }

        public double LadoB
        {
            get
            {
                return lado2;
            }
        }

        //métodos
        public double Superficie()
        {
            return lado1 * lado2;
        }

        public double Perimetro()
        {
            return 2 * lado1 + 2 * lado2;
        }

    }
}
