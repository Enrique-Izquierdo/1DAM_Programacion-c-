using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_02
{
    class CuentaBancaria
    {
        //atributos
        protected string titular;
        protected static int numeroCuenta = 1000;
        protected int numero;
        protected double saldo;

        //propiedades
        public string Titular { get { return titular; } set { titular = value.ToUpper(); } }
        public int Numero { get { return numero; } set { numero = value; } }
        public double Saldo { get { return saldo; } }

        //constructor
        public CuentaBancaria(string nombre)
        {
            titular = nombre.ToUpper();
            numeroCuenta += 1;
            numero = numeroCuenta;
            saldo = 0;
        }

        //otros métodos interface
        public virtual void IngresarDinero(double ingreso)
        {
            saldo += ingreso;
            Console.WriteLine("\n Ha efectuado un ingreso de {0} euros.", ingreso);
        }

        public void RetirarDinero(double importe)
        {
            if (importe <= saldo)
            {
                saldo -= importe;
                Console.WriteLine("\n Ha retirado {0} euros.", importe);
            }
            else
            {
                Console.WriteLine("\n La operación ha sido cancelada por falta de fondos.");
            }
        }

        public void ConsultarCuenta()
        {
            Console.WriteLine("\n Información cuenta:\n -Número de cuenta: {0}" +
                "\n -Titular de la cuenta: {1}\n -Saldo de la cuenta: {2} euros",
                numero, titular, saldo);
        }
    }
}
