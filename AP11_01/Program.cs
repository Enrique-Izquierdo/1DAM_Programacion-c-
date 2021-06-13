using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_01
{
    class Program
    {
        static void Main(string[] args)
        {            
            CuentaBancaria cuenta1 = new CuentaBancaria("Pepe");
            Console.WriteLine("\n\n Ejemplo cuenta bancaria");
            cuenta1.ConsultarCuenta();
            cuenta1.IngresarDinero(10500.59);
            cuenta1.ConsultarCuenta();
            cuenta1.RetirarDinero(500);
            cuenta1.ConsultarCuenta();
            Console.ReadKey();

            CuentaBancariaRemunerada cuenta2 = new CuentaBancariaRemunerada("Tomas", 1.15);
            Console.WriteLine("\n\n Ejemplo cuenta bancaria remunerada");
            cuenta2.ConsultarCuenta();
            cuenta2.IngresarDinero(10000);
            cuenta2.ConsultarCuenta();
            cuenta2.RetirarDinero(100);
            cuenta2.ConsultarCuenta();
            Console.ReadKey();

        }
    }
}
