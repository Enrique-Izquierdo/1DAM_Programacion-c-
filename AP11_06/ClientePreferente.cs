using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_06
{
    class ClientePreferente:Cliente
    {
        //atributos
        private List<Fondo> cartera;

        //propiedades
        public List<Fondo> Cartera { get { return cartera; } }

        //constructores
        public ClientePreferente(string nif, int numCuenta, double saldo, List<Fondo> cartera)
            : base (nif, numCuenta, saldo)
        {

            this.cartera = cartera;
        }

        public ClientePreferente()
        {

        }

        //getters y setters
        //otros métodos interface

        public int NumeroDeFondos()
        {
            return cartera.Count;
        }

        public double CantidadEnFondos()
        {
            double total = 0;
            for(int i=0; i< cartera.Count; i++)
            {
                total += cartera[i].SaldoMensual;
            }
            return total;
        }

        public override void VerInfo()
        {
            base.VerInfo();
            foreach(Fondo elem in cartera)
            {
                elem.VerInfo();
            }            
        }

        //métodos implementación
    }
}
