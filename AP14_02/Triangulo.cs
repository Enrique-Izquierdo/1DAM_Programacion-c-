using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP14_02
{
    class Triangulo
    {
        //atributos
        private double lado1;
        private double lado2;
        private double lado3;

        //contructores
        public Triangulo(double cLado1, double cLado2, double cLado3)
        {
            lado1 = cLado1;
            lado2 = cLado2;
            lado3 = cLado3;
        }

        public Triangulo()
        {
            Console.Write("Introduce la longitud del lado 1: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("Introduce la longitud del lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la longitud del lado 3: ");
            lado3 = double.Parse(Console.ReadLine());
        }

        //propiedades
        public double Lado1
        {
            get
            {
                return lado1;
            }
        }

        public double Lado2
        {
            get
            {
                return lado2;
            }
        }

        public double Lado3
        {
            get
            {
                return lado3;
            }
        }
        
        //métodos

        public bool EsEscaleno()
        {
            return (lado1 != lado2 && lado2 != lado3 && lado1 != lado3);
        }

        public bool EsEquilatero()
        {
            return (lado1 == lado2 && lado2 == lado3);
        }

        public bool EsIsosceles()
        {
            return (!EsEscaleno() && !EsEquilatero());
        }

    }
}
