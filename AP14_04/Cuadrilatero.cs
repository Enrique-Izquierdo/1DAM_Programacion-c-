using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP14_04
{
    class Cuadrilatero
    {
        //atributos
        private double lado1;
        private double lado2 = 0;

        //propiedades
        //constructores
        public Cuadrilatero(double lado)
        {
            lado1 = lado;
        }

        public Cuadrilatero(double ladoA, double ladoB)
        {
            lado1 = ladoA;
            lado2 = ladoB;
        }

        //getters y setters
        //otros métodos de interface
        public double Area()
        {
            if (lado2 == 0)
            {
                return lado1 * lado1;
            }
            else
            {
                return lado1 * lado2;
            }            
        }

        public double Perimetro()
        {
            if (lado2 == 0)
            {
                return 4 * lado1;
            }
            else
            {
                return 2 * lado1 + 2 * lado2;
            }
        }


        //métodos de implementación

    }
}
