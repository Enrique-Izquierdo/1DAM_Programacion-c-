using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdCong:ProdTratFrio
    {
        //atributos
        //propiedades
        //constructores
        public ProdCong(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto) : base(numLote, fechaCad, fechaEnv, paisOrigen, tempManto)
        {          
        }
        //getters y setters
        //otros métodos interface
        //métodos implementación
    }
}
