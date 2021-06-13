using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdCongAgua:ProdCong
    {
        //atributos
        private double salinidad;

        //propiedades
        public double Salinidad { get { return salinidad; } set { salinidad = value; } }

        //constructores
        public ProdCongAgua(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto, double salinidad) : base(numLote, fechaCad, fechaEnv, paisOrigen, tempManto)
        {
            this.salinidad = salinidad;
        }

        //getters y setters
        public double getSalinidad() { return salinidad; }
        public void setSalinidad (double salinidad) { this.salinidad = salinidad; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine(" -salinidad agua: {0} gr_sal/litro_agua", salinidad);
        }

        //métodos implementación
    }
}
