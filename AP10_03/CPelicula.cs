using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_03
{
    class CPelicula
    {
        //atributos
        private string nombrePelicula;
        private int anyoEstreno;
        private List<CActor> reparto;

        //propiedades
        //constructores
        public CPelicula(string pNombrePeli, int pAnyoEstreno, List<CActor> pReparto)
        {
            nombrePelicula = pNombrePeli;
            anyoEstreno = pAnyoEstreno;
            reparto = pReparto;
        }

        //getters y setters
        public List<CActor> getActoresMenores18()
        {

            List<CActor> actoresMenores18 = new List<CActor>();
            foreach(CActor elem in reparto)
            {
                if (anyoEstreno - elem.getAnyoNacimiento() < 18)
                {
                    actoresMenores18.Add(elem);
                }
            }
            return actoresMenores18;
        }

        //otros métodos de interface
        public void VerDatosPeli()
        {
            Console.WriteLine("Título película: {0}\nAño de estreno: {1}\nReparto:");
            foreach(CActor elem in reparto)
            {
                elem.VerDatosActor(); 
            }
        }

        public void EdadActoresPeli()
        {
            int anyoActual = DateTime.Now.Year;
            Console.WriteLine("\nEdad actual de los actores de la pelicula:");

            foreach (CActor elem in reparto)
            {
                Console.WriteLine("{0}, {1} años", elem.getNombreActor(), 
                    anyoActual - elem.getAnyoNacimiento());
            }
        }

        //métodos de implementación
    }
}
