using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdTratFrio:Producto
    {
        //atributos
        protected double tempManto;

        //propiedades
        public double TempManto { get { return tempManto; } set { tempManto = value; } }
        //constructores
        public ProdTratFrio(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto) : base(numLote, fechaCad, fechaEnv, paisOrigen)
        {
            this.tempManto = tempManto;
        }

        //getters y setters
        public double getTempManto() { return tempManto; }
        public void setTempManto(double tempManto) { this.tempManto = tempManto; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine(" -temperatura mantenimiento: {0}ºC", tempManto);
        }

        //métodos implementación
    }
}
