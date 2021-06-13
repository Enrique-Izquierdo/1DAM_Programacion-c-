using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_06
{
    class Program
    {
        static ClientePreferente CrearClientePref()
        {
            string nifCliente; int nCuenta, ctdadfondos; double saldoCuenta; bool valido;
            List<Fondo> carteraFondos = new List<Fondo>();

            Console.WriteLine("\n Introduzca datos nueva Cuenta Preferente" +
                              "\n==========================================");
            Console.Write(" - nif cliente: ");
            nifCliente = Console.ReadLine();
            Console.Write(" - cuenta número: ");
            nCuenta = int.Parse(Console.ReadLine());
            Console.Write(" - saldo cuenta: ");
            saldoCuenta = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("\n número de fondos a crear: ");
                valido = int.TryParse(Console.ReadLine(), out ctdadfondos) && ctdadfondos > 0;
                if(!valido) { Console.WriteLine("El valor introducido debe ser mayor o igual a 0."); }
            } while (!valido);

            for (int i=0; i<ctdadfondos; i++)
            {
                Console.Write("\n Fondo {0}º -", i + 1);
                carteraFondos.Add(new Fondo());
            }

            Console.WriteLine("\n Toma de datos finalizada.");

            return new ClientePreferente(nifCliente, nCuenta, saldoCuenta, carteraFondos);
          
        }

        static void Main(string[] args)
        {
            Cliente clien1 = new Cliente();
            clien1.VerInfo();
            Console.ReadKey();

            ClientePreferente pref1 = CrearClientePref();
            Console.ReadKey();

            pref1.VerInfo();
            Console.ReadKey();

            Console.WriteLine("\n El cliente tiene {0} fondos.",pref1.NumeroDeFondos());
            Console.ReadKey();

            Console.WriteLine("\n El cliente tiene {0} euros entre todos los fondos.", pref1.CantidadEnFondos());
            Console.ReadKey();

        }
    }
}
