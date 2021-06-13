using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_06
{
    class Cliente
    {
        //atributos
        protected string nif;
        protected int numCuenta;
        protected double saldo;

        //propiedades
        public string Nif { get { return nif; } }
        public int NumCuenta { get { return numCuenta; } }
        public double Saldo { get { return saldo; } }

        //constructores
        public Cliente(string nif, int numCuenta, double saldo)
        {
            this.nif = nif;
            this.numCuenta = numCuenta;
            this.saldo = saldo;
        }

        public Cliente()
        {
            Console.WriteLine("\n Introduzca datos nueva Cuenta" +
                              "\n===============================");
            Console.Write(" - nif: ");
            nif = Console.ReadLine();
            Console.Write(" - número de cuenta: ");
            numCuenta = int.Parse(Console.ReadLine());
            Console.Write(" - saldo inicial: ");
            saldo = Convert.ToDouble(Console.ReadLine());
        }

        //getters y setters
        //otros métodos interface
        public virtual void VerInfo()
        {
            Console.WriteLine("\n Información cuenta" +
                              "\n====================");
            Console.WriteLine(" - nif: {0}", nif);
            Console.WriteLine(" - cuenta número: {0}", numCuenta);
            Console.WriteLine(" - saldo: {0}", saldo);
        }

        //métodos implementación
    }
}
