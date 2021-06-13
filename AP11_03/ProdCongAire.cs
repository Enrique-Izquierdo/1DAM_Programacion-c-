using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdCongAire:ProdCong
    {
        //atributos
        private double porNitro;
        private double porO2;
        private double porCo2;
        private double porVapor;

        //propiedades
        public double PorNitro { get { return porNitro; } set { porNitro = value; } }
        public double PorO2 { get { return porO2; } set { porO2 = value; } }
        public double PorCo2 { get { return porCo2; } set { porCo2 = value; } }
        public double PorVapor { get { return porVapor; } set { porVapor = value; } }

        //constructores
        public ProdCongAire(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto, double porNitro, double porO2, double porCo2, double porVapor)
            : base(numLote, fechaCad, fechaEnv, paisOrigen, tempManto)
        {
            this.porNitro = porNitro;
            this.porO2 = porO2;
            this.porCo2 = porCo2;
            this.porVapor = porVapor;
        }

        //getters y setters
        public double getPorNitro() { return porNitro; }
        public double getPorO2() { return porO2; }
        public double getPorCo2() { return porCo2; }
        public double getPorVapor() { return porVapor; }

        public void setPorNitro(double porNitro) { this.porNitro = porNitro; }
        public void setPorO2(double porO2) { this.porO2 = porO2; }
        public void setPorCo2(double porCo2) { this.porCo2 = porCo2; }
        public void setPorVapor(double porVapor) { this.porVapor = porVapor; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine(" -concentración nitrogeno en aire: {0}%", porNitro);
            Console.WriteLine(" -concentración oxigeno en aire: {0}%", porO2);
            Console.WriteLine(" -concentración dioxido de carbono en aire: {0}%", porCo2);
            Console.WriteLine(" -concentración vapor de agua en aire: {0}%", porVapor);
        }

        //métodos implementación
    }
}
