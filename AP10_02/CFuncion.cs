using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_02
{
    class CFuncion
    {
        //atributos
        private string nombreFunc;
        private double precioFunc;

        //propiedades
        //constructores
        public CFuncion(string pNombre, double pPrecio)
        {
            nombreFunc = pNombre;
            precioFunc = pPrecio;
        }

        //getter y setters
        public string getNombreFunc()
        {
            return nombreFunc;
        }

        public double getPrecioFunc()
        {
            return precioFunc;
        }

        public void setNombreFunc(string pNombre)
        {
            nombreFunc = pNombre;
        }

        public void setPrecioFunc(double pPrecio)
        {
            precioFunc = pPrecio;
        }

        //otros métodos de interface
        //métodos de implementación
    }
}
