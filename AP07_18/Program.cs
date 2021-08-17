using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, anyoString, contiString;
            bool valido, continuar;
            uint anyos;

            do
            {
                Console.Write("Introduzca el nombre del empleado: ");
                nombre = Console.ReadLine();
                do
                {
                    Console.Write("Introduzca los años de antiguedad: ");
                    anyoString = Console.ReadLine();

                    valido = uint.TryParse(anyoString, out anyos);

                    if (!valido)
                    {
                        Console.WriteLine("El valor introducido no es valido.");
                    }

                } while (!valido);

                if (anyos > 15)
                {
                    Console.WriteLine("A {0} con {1} años de antiguedad, le corresponden {2} euros" +
                        " de gratificación.", nombre, anyos, anyos * 130);
                }
                else if (anyos >= 10)
                {
                    Console.WriteLine("A {0} con {1} años de antiguedad, le corresponden {2} euros" +
                        " de gratificación.", nombre, anyos, anyos * 115);
                }
                else if (anyos > 3)
                {
                    Console.WriteLine("A {0} con {1} años de antiguedad, le corresponden {2} euros" +
                        " de gratificación.", nombre, anyos, anyos * 100);
                }
                else
                {
                    Console.WriteLine("Al personal con 3 o menos años de antiguedad," +
                        " no le corresponde gratificación");
                }

                Console.WriteLine("¿Deseas calcular la gratificación de otro empleado (S/N)?: ");
                contiString = Console.ReadLine();
                if (contiString.ToUpper() == "S")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }

            } while (continuar);

        }
    }
}
