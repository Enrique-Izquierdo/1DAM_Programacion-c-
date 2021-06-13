using System;

namespace AP6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, cantidad, importe, descuento, total;
            
            Console.Write("Ingrese el precio del producto: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el número de unidades: ");
            cantidad = double.Parse(Console.ReadLine());

            importe = precio * cantidad;
            descuento = importe * 11 / 100;
            total = importe - descuento;

            Console.WriteLine("Importe total: " + importe.ToString("0.00"));
            Console.WriteLine("Descuento: " + descuento.ToString("0.00"));
            Console.WriteLine("Total a pagar: " + total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
