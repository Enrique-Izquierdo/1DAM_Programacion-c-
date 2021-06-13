using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_03
{
    class CActor
    {
        //atributos
        private string nombreActor;
        private int anyoNac;

        //propiedades
        //constructores
        public CActor(string pNombreActor, int pAnyoNac)
        {
            nombreActor = pNombreActor;
            anyoNac = pAnyoNac;
        }

        //getters y setters
        public string getNombreActor()
        {
            return nombreActor;
        }
        
        public int getAnyoNacimiento()
        {
            return anyoNac;
        }

        //otros métodos interface
        public void VerDatosActor()
        {
            Console.WriteLine("{0} nació en {1}", nombreActor, anyoNac);
        }
        
        //métodos implementación
    }
}
