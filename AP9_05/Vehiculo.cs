using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_05
{
    class Vehiculo
    {
        //atributos
        private string marca;
        private string modelo;
        private double potencia;
        private double precio;

        //constructores
        public Vehiculo()
        {
            Console.WriteLine("Introduce los datos del vehículo");
            Console.WriteLine("================================");
            Console.Write("Indique la marca: ");
            marca = Console.ReadLine();
            Console.Write("Indique el modelo: ");
            this.modelo = Console.ReadLine();
            Console.Write("Indique la potencia: ");
            potencia = double.Parse(Console.ReadLine());
            Console.Write("Indique el precio: ");
            precio = Convert.ToDouble(Console.ReadLine());
        }

        //propiedades
        public double Precio
        {
            get
            {
                return precio;
            }
        }

        //métodos
        public void VerInfo()
        {
            Console.WriteLine("marca: {0}", marca);
            Console.WriteLine("modelo: {0}", modelo);
            Console.WriteLine("potencia: {0}", this.potencia);
            Console.WriteLine("precio: {0}", precio);
        }
    }
}
