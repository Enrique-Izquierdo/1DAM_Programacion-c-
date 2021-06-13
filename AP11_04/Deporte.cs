using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_04
{
    class Deporte
    {
        //atributos
        protected string nombre;
        protected string tipoPuntuacion;

        //propiedades
        //constructores
        public Deporte(string nombre, string tipoPuntacion)
        {
            this.nombre = nombre;
            this.tipoPuntuacion = tipoPuntacion;
        }

        //gettes y setters
        //otros métodos interface
        public void VerInfo()
        {
            Console.WriteLine("\n {0} puntua con {1}.", nombre, tipoPuntuacion);
        }

        //métodos implementación
    }
}
