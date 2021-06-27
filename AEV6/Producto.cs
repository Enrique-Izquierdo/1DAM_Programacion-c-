using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV6
{
    class Producto
    {
        /*-----atributos-----*/
        private string descriProducto;
        private double precioProducto;

        /*-----propiedades-----*/
        public string DescriProducto { get { return descriProducto; } set { descriProducto = value; } }
        public double PrecioProducto { get { return precioProducto; } set { precioProducto = value; } }

        /*-----constructores-----*/
        public Producto(string descriProducto, double precioProducto)
        {
            this.descriProducto = descriProducto;
            this.precioProducto = precioProducto;
        }

        /*-----getters y setters-----*/
        /*-----otros métodos de interface-----*/
        /*-----métodos de implementación-----*/
    }
}
