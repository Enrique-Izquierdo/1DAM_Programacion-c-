using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_02
{
    class CuentaNomina:CuentaBancaria
    {
        //atributos
        private List<string> recibosPagados = new List<string>();

        //propiedades
        //constructores
        public CuentaNomina(string nombre)
            : base(nombre)
        {
        }
        
        //setters y getters
        //otros métodos de interface
        public void PagoRecibo(string conceptoRecibo, double cantidad)
        {
            if (saldo >= cantidad)
            {
                saldo -= cantidad;
                recibosPagados.Add(conceptoRecibo);
                Console.WriteLine("\n El importe de {0} euros correspondiente al recibo " +
                    "de {1},\n ha sido descontado de su cuenta.", cantidad, conceptoRecibo);
            }
            else
            {
                Console.WriteLine("\n No dispone de saldo suficiente para pagar\n el recibo" +
                    "de {0} con un importe de {1} euros.", conceptoRecibo, cantidad);
            }
        }

        public void VerRecibos()
        {
            Console.WriteLine("\n Listado de recibos pagados:");
            foreach(string concepto in recibosPagados)
            {
                Console.WriteLine(" - {0}",concepto);
            }
        }

        //métodos de implementación
    }
}
