using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_27
{
    class Program
    {
        static double PrecioFinal(float precio, float descuento)
        {
            double iva = 0.16;
            float precioDesc = precio - precio*descuento/100;
            return precioDesc + precioDesc*iva;
        }

        static void Main(string[] args)
        {
            string preInicialString, descuString;
            float preInicial, descu;
            bool valido, correcto;
            
            do
            {
                Console.Write("Introduce el precio inicial del producto (0 finaliza el programa): ");
                preInicialString = Console.ReadLine();
                valido = float.TryParse(preInicialString, out preInicial) && preInicial >= 0;
                if (!valido)
                {
                    Console.WriteLine("El valor introducido NO es valido.");
                } 
                else if (preInicial != 0)
                {
                    do
                    {
                        Console.Write("Introduce el descuento a aplicar entre el 0% y el 20%: ");
                        descuString = Console.ReadLine();
                        correcto = float.TryParse(descuString, out descu) && descu >= 0 && descu <= 20;
                        if (!correcto)
                        {
                            Console.WriteLine("El valor introducido NO es valido.");
                        }
                        else
                        {
                            Console.WriteLine("El precio final, aplicando un descuento del {0}% y un IVA del 16%," +
                                     " es: {1:N} euros.", descu, PrecioFinal(preInicial, descu));
                        }
                    } while (!correcto);                    
                }
            } while (preInicialString != "0");
        }
    }
}
