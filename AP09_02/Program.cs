using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(30, 30, 30);
            Triangulo t2 = new Triangulo(30, 25, 30);
            Triangulo t3 = new Triangulo();

            List<Triangulo> listaTriangulos = new List<Triangulo>();
            
            listaTriangulos.Add(t1);
            listaTriangulos.Add(t2);
            listaTriangulos.Add(t3);

            foreach (Triangulo elemento in listaTriangulos)
            {
                Console.Write("\nEl triangulo de lados con longitud {0}, {1} y {2} " +
                    "es ", elemento.Lado1, elemento.Lado2, elemento.Lado3);
                if (elemento.EsEquilatero())
                {
                    Console.WriteLine("equilatero.");
                }
                else if (elemento.EsIsosceles())
                {
                    Console.WriteLine("isosceles.");
                }
                else if (elemento.EsEscaleno())
                {
                    Console.WriteLine("escaleno.");
                }
                else
                {
                    Console.WriteLine("¡¡Hay un error!!");
                }
            }

            Console.ReadLine();

        }
    }
}
