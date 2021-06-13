using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_05
{
    class Libro:Publicacion
    {
        //atributos
        private string autor;
        //propiedades
        //constructores
        public Libro (int codigo, string anyo, string autor) : base(codigo, anyo)
        {
            this.autor = autor;
        }

        //getters y setters
        public string getAutor() { return autor; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.Write(",\t autor libro: {0}", autor);
        }

        //métodos implementación
    }
}
