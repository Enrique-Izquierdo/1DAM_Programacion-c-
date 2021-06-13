using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdCongNitro:ProdCong
    {
        //atributos
        private string metodoCong;
        private int tiempoExpNitro;

        //propiedades
        public string MetodoCong { get { return metodoCong; } set { metodoCong = value; } }
        public int TiempoExpNitro { get { return tiempoExpNitro; } set { tiempoExpNitro = value; } }

        //constructores
        public ProdCongNitro(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto, string metodoCong, int tiempoExpNitro)
            : base(numLote, fechaCad, fechaEnv, paisOrigen, tempManto)
        {
            this.metodoCong = metodoCong;
            this.tiempoExpNitro = tiempoExpNitro;
        }

        //getters y setters
        public string getMetodoCong() { return metodoCong; }
        public int getTiempoExpNitro() { return tiempoExpNitro; }

        public void setMetodoCong(string metodoCong) { this.metodoCong = metodoCong; }
        public void setTiempoExpNitro(int tiempoExpNitro) { this.tiempoExpNitro = tiempoExpNitro; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine(" -método congelación: {0}", metodoCong);
            Console.WriteLine(" -tiempo exposición a nitrogeno: {0}sg", tiempoExpNitro);
        }

        //métodos implementación
    }
}
