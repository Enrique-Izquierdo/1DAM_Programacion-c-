using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class Producto
    {
        //atributos
        protected int numLote;
        protected string fechaCad;
        protected string fechaEnv;
        protected string paisOrigen;

        //propiedades
        public int NumLote { get { return numLote; } set { numLote = value; } }
        public string FechaCad { get { return fechaCad; } set { fechaCad = value; } }
        public string FechaEnv { get { return fechaEnv; } set { fechaEnv = value; } }
        public string PaisOrigen { get { return paisOrigen; } set { paisOrigen = value; } }

        //constructores
        public Producto(int numLote, string fechaCad, string fechaEnv, string paisOrigen)
        {
            this.numLote = numLote;
            this.fechaCad = fechaCad;
            this.fechaEnv = fechaEnv;
            this.paisOrigen = paisOrigen;
        }

        //getters y setters
        public int getNumLote() { return numLote; }
        public string getFechaCad() { return fechaCad; }
        public string getFechaEnv() { return fechaEnv; }
        public string getPaisOrigen() { return paisOrigen; }

        public void setNumLote (int numLote) { this.numLote = numLote; }
        public void setFechaCad (string fechaCad) { this.FechaCad = fechaCad; }
        public void setFechaEnv (string fechaEnv) { this.fechaEnv = fechaEnv; }
        public void setPaisOrigen (string paisOrigen) { this.paisOrigen = paisOrigen; }

        //otros métodos interface
        public virtual void VerInfo()
        {
            Console.WriteLine("\n   Datos Producto:" +
                              "\n ===================");
            Console.WriteLine(" -número lote: {0}", numLote);
            Console.WriteLine(" -fecha caducidad: {0}", fechaCad);
            Console.WriteLine(" -fecha envasado: {0}", fechaEnv);
            Console.WriteLine(" -país origen: {0}", paisOrigen);
        }

        //métodos implementación
    }
}
