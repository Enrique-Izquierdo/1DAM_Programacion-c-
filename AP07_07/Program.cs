using System;

namespace AP7_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Solución A */

            //double[] sueldos = new double[5];
            //double sueldoTotal = 0, sueldoPromedio, mayor = 0;

            //for (int i=0; i<5; i++)
            //{
            //    Console.Write("Introduce el sueldo del trabajador {0}: ", i + 1);
            //    sueldos[i] = Convert.ToDouble(Console.ReadLine());
            //    sueldoTotal += sueldos[i];
            //}

            //sueldoPromedio = sueldoTotal / sueldos.Length;

            //Console.WriteLine($"El sueldo promedio es de {sueldoPromedio} euros.");
            //Console.ReadKey();

            //for (int i=0; i<sueldos.Length; i++)
            //{
            //    if (sueldos[i] > mayor)
            //    {
            //        mayor = sueldos[i];
            //    }
            //}

            //Console.WriteLine($"El sueldo mayor es de {mayor} euros.");
            //Console.ReadKey();


            /** Solución B */

            double sueldo, sueldoTotal = 0, sueldoPromedio, mayor = 0, numEmpleados = 5;

            for (int i = 1; i <= numEmpleados; i++)
            {
                Console.Write("Introduce el sueldo del trabajador {0}: ", i + 1);
                sueldo = Convert.ToDouble(Console.ReadLine());
                sueldoTotal += sueldo;

                if (sueldo > mayor)
                {
                    mayor = sueldo;
                }
            }

            sueldoPromedio = sueldoTotal / numEmpleados;

            Console.WriteLine($"El sueldo promedio es de {sueldoPromedio} euros.");
            Console.WriteLine($"El sueldo mayor es de {mayor} euros.");
            Console.ReadKey();
        }
    }
}
