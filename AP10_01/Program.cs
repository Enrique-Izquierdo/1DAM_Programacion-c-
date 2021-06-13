using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ccliente cliente1 = new Ccliente("Pepe", "Lopez", "34235792G");

            Ccuenta cuenta1 = new Ccuenta(254, 1000);
            Ccuenta cuenta2 = new Ccuenta(345, 750);

            cliente1.setArrayCuentas(254, cuenta1);
            cliente1.setArrayCuentas(345, cuenta2);

            Console.WriteLine("Saldo de la cuenta inicializada con 1000€: " +
                "{0}€", cliente1.getSaldo_CuentaDeArray(254));
            Console.WriteLine("Saldo de la cuenta inicializada con 750€: " +
                "{0}€", cliente1.getSaldo_CuentaDeArray(345));

            cliente1.IngresarSaldo_CuentaDeArray(254, 5000);
            cliente1.IngresarSaldo_CuentaDeArray(345, 2500);

            Console.WriteLine("Saldo de la cuenta inicializada con 1000€, " +
                "tras ingresar 5000€: {0}€", cliente1.getSaldo_CuentaDeArray(254));
            Console.WriteLine("Saldo de la cuenta inicializada con 750€, " +
                "tras ingresar 2500€: {0}€", cliente1.getSaldo_CuentaDeArray(345));

            Console.ReadKey();

        }
    }
}
