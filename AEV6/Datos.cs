using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV6
{
    class Datos
    {
        /*-----atributos-----*/
        /* Atributo estático que contiene los tipos de producto dispoibles y sus precios*/
        private static List<Producto> listaProductos = new List<Producto>();
        /* Atributo estático que contiene la información de cada uno de los pedidos*/
        private static List<Pedido> listaPedidos = new List<Pedido>();

        /*-----propiedades-----*/
        public static List<Producto> ListaProductos { get { return listaProductos; }
            set { listaProductos = value; } }

        public static List<Pedido> ListaPedidos { get { return listaPedidos; } 
            set { listaPedidos = value; } }

        /*-----constructores-----*/
        public Datos() { }

        /*-----getters y setters-----*/
        /*-----otros métodos de interface-----*/
        public static void GuardarResumen()
        {
            string ruta = "resumen.txt";            
            StreamWriter fichero = new StreamWriter(ruta);
            foreach(Pedido elemento in listaPedidos)
            {
                string registroLinea = elemento.NumPedido + ";" + elemento.NifCliente + ";" 
                    + elemento.FechaPedido.ToString("d");
                fichero.WriteLine(registroLinea);
            }
            fichero.Close();
        }

        /*-----métodos de implementación-----*/
    }
}
