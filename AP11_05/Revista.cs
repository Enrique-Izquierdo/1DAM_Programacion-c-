using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_05
{
    class Revista:Publicacion
    {
        //atributos
        private int numero;

        //propiedades
        //constructores
        public Revista(int codigo, string anyo, int numero): base(codigo,anyo)
        {
            this.numero = numero;
        }

        //getters y setters
        public int getNumero() { return numero; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.Write(",\t núm. revista: {0}", numero);           
        }

        //métodos implementación
    }
}
