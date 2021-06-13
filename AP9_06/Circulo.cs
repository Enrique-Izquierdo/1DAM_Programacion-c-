using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_06
{
    class Circulo
    {
        //atributos (implementación)
        private double radio;

        //constructores (interface)
        public Circulo(double cRadio)
        {
            radio = cRadio;
        }

        //propiedades (interface)
        public double Radio
        {
            get
            {
                return radio;
            }
        }

        //métodos de acceso (interface)
        public double getRadio()
        {
            return radio;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * radio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }


        //métodos privados (implementación)

    }
}
