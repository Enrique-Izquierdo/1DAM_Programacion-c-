using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_05
{
    class Publicacion
    {
        //atributos
        protected int codigo;
        protected string anyo;
        protected bool prestado;

        //propiedades
        public bool Prestado { get { return prestado; } }
       
        //constructores
        public Publicacion(int codigo, string anyo)
        {
            this.codigo = codigo;
            this.anyo = anyo;
            prestado = false;
        }
        //getters y setters
        public int getCodigo() { return codigo; }
        public string getAnyo() { return anyo; }


        //otros métodos interface
        public void Prestar()
        {
            if (prestado == true)
            {
                Console.WriteLine("\n -La publicación {0} no está disponible.", codigo);
            }
            else
            {
                prestado = true;
                Console.WriteLine("\n -Ha recibido la publicación {0}.", codigo);
            }            
        }

        public void Devolver()
        {
            if (prestado == false)
            {
                Console.WriteLine("\n -La publicación {0} no está prestada.", codigo);
            }
            else
            {
                prestado = false;
                Console.WriteLine("\n -Ha devuelto la publicación {0}.", codigo);
            }
        }

        public virtual void VerInfo()
        {
            Console.Write("\n Datos publicación -->");
            Console.Write("\t código publ.: {0},", codigo);
            Console.Write("\t año publ.: {0},", anyo);
            if (prestado == true)
            {
                Console.Write("\t prestado");
            }
            else
            {
                Console.Write("\t disponible");
            }
        }

        //métodos implementación
    }
}
