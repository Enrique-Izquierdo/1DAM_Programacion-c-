using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_01
{
    class Ccuenta
    {
        //atributos
        private int numeroCuenta;
        private double saldoCuenta;

        //propiedades
        public double SaldoCuenta
        {
            get
            {
                return saldoCuenta;
            }
        }
        
        //constructores
        public Ccuenta(int pNumCuenta, double pSaldoCuenta)
        {
            numeroCuenta = pNumCuenta;
            saldoCuenta = pSaldoCuenta;
        }

        //getters y setters
        public double getSaldo()  // = ConsultarSaldo()
        {
            return saldoCuenta;
        }


        //otros métodos interface
        public void IngresarSaldo(double pSaldo) // ¿setSaldo?
        {
            saldoCuenta += pSaldo;
        }

        public void RetirarSaldo(double pSaldo) // ¿setSaldo? ¿Puede haber 2 setSaldos? 
        {                                       // ¿Como diferenciarlos?
            saldoCuenta -= pSaldo;
        }

        
        //métodos implementación
    }
}
