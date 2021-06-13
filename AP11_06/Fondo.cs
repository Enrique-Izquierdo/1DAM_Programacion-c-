using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_06
{
    class Fondo
    {
        //atributos
        private int numFondo;
        private double saldoMensual;

        //propiedades
        public int NumFondo { get { return numFondo; } }
        public double SaldoMensual { get { return saldoMensual; } }

        //constructores
        public Fondo()
        {
            bool valido;
            Console.WriteLine(" Introducción de Datos" +
                              "\n=================================");
            do
            {
                Console.Write(" - fondo número: ");
                valido = int.TryParse(Console.ReadLine(), out numFondo);
                if (!valido) { Console.WriteLine("  Número no válido."); }
            } while (!valido);

            do
            {
                Console.Write(" - saldo inicial: ");
                valido = double.TryParse(Console.ReadLine(), out saldoMensual);
                if (!valido) { Console.WriteLine("  saldo no válido."); }
            } while (!valido);

        }

        //getters y setters
        //otros métodos interface
        public void VerInfo()
        {
            Console.WriteLine("\n Información del fondo" +
                              "\n=======================");
            Console.WriteLine(" - fondo número: {0}", numFondo);
            Console.WriteLine(" - saldo mensual: {0}", saldoMensual);
        }
        //métodos implementación
    }
}
