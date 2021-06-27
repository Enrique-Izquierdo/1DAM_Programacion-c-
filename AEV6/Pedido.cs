using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV6
{
    class Pedido
    {
        /*-----atributos-----*/
        private static int numPedGlobal;
        private int numPedido;
        private string nifCliente;
        private string nombreCliente;
        private string direccion;
        private DateTime fechaPedido;
        private List<string> nombreProductos;
        private List<int> cantXProducto;
        private static int maxTipoProductos = 3;

        /*-----propiedades-----*/
        public static int NumPedGlobal { get{ return numPedGlobal; } set{ numPedGlobal = value; } }
        public int NumPedido { get { return numPedido; } set { numPedido = value; } }
        public string NifCliente { get { return nifCliente; } set { nifCliente = value; } }
        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public DateTime FechaPedido { get { return fechaPedido; } set { fechaPedido = value; } }
        public List<string> NombreProductos { get { return nombreProductos; } 
            set { nombreProductos = value; } } 
        public List<int> CantXProducto { get { return cantXProducto; } set { cantXProducto = value; } }
        public static int MaxTipoProductos { get { return maxTipoProductos; }
            set { maxTipoProductos = value; } }

        /*-----constructores-----*/
        public Pedido ()
        {            
            nombreProductos = new List<string>();
            cantXProducto = new List<int>();
        }

        /*-----getters y setters-----*/
        /*-----otros métodos de interface-----*/
        public double DeterminarPrecio(string nombre)
        {
            double precio = 0;
            for (int i=0; i < Datos.ListaProductos.Count; i++)
            {
                if (nombre == Datos.ListaProductos[i].DescriProducto)
                {
                    precio =  Datos.ListaProductos[i].PrecioProducto;
                    i = Datos.ListaProductos.Count;
                }
            }
            return precio;
        }

        public double CalcularImporte(string nombre, int cantidad)
        {
            return DeterminarPrecio(nombre) * cantidad;
        }

        /* Método que cálcula el importe total del conjunto de productos del pedido*/
        public double CalcularImporteTotal()
        {
            double importeTotal = 0;
            int i = 0;
            foreach(string elemento in nombreProductos)
            {
                importeTotal += CalcularImporte(elemento, cantXProducto[i]);
                i++;
            }
            return importeTotal;
        }

        /* Método que cálcula la cantidad total de productos que contiene el pedido*/
        public double calcularTotalProductos()
        {
            double totalProductos=0;
            for (int i=0; i<cantXProducto.Count; i++)
            {
                totalProductos += cantXProducto[i];
            }
            return totalProductos;
        }

        /*-----métodos de implementación-----*/
    }
}
