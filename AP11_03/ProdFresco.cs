using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdFresco:Producto
    {
        //atributos
        //propiedades
        //constructores
        public ProdFresco(int numLote, string fechaCad, string fechaEnv, string paisOrigen)
            :base(numLote, fechaCad, fechaEnv, paisOrigen)
        {           
        }
        //getters y setters
        //otros métodos interface
        //métodos implementación
    }
}
