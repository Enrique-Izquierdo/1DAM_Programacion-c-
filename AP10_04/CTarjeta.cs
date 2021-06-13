using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_04
{
    class CTarjeta
    {
        //atributos
        private double saldo;

        //propiedades
        //constructores
        public CTarjeta(double saldo)
        {
            this.saldo = saldo;
        }

        //getters y setters
        public double getSaldo()
        {
            return saldo;
        }

        //otros métodos de interface
        public void Descontar(double dinero)
        {
            saldo -= dinero;
        }

        public void VerSaldo()
        {
            Console.WriteLine("La tarjeta dispone de un saldo de {0} euros.", getSaldo());
        }

        public void RecargarTarjeta(double cantidad)
        {
            saldo += cantidad;
        }

        //métodos de implementación

    }
}
