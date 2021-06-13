using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string precioString, ivaString;
            float precio, iva;
            bool valido;

            do {

                do
                {
                    Console.Write("Introduce el precio (0 cierra el programa): ");
                    precioString = Console.ReadLine();
                    valido = float.TryParse(precioString, out precio) && precio >= 0;
                    if (!valido)
                    {
                        Console.WriteLine("El precio indicado no es valido.");
                    }
                } while (!valido);
                // Console.WriteLine("El precio indicado es valido.");

                if (precio != 0)
                {
                    do
                    {
                        Console.Write("Introduce el iva (entre 16 y 21): ");
                        ivaString = Console.ReadLine();
                        valido = float.TryParse(ivaString, out iva) && iva >= 16 && iva <= 21;
                        if (!valido)
                        {
                            Console.WriteLine("El iva indicado no es valido.");
                        }
                    } while (!valido);
                    // Console.WriteLine("El iva indicado es valido.");

                    Console.WriteLine("Precio sin IVA: {0}\nPrecio con el {1}% de IVA: {2:N}\n",
                        precio, iva, precio + precio * iva / 100);
                }
                else
                {
                    Console.WriteLine("Ha cerrado el programa al introducir el valor 0.");
                }

            } while (precio != 0);

            Console.ReadKey();
        }
    }
}
