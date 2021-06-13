using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_01
{
    class CuentaBancariaRemunerada:CuentaBancaria
    {
        //atributos
        private double porcentaje;

        //propiedades
        //constructores
        public CuentaBancariaRemunerada(string nombre, double porcentaje)
            : base(nombre)
        {
            this.porcentaje = porcentaje;
        }

        //getters y setters
        //otros métodos de interface
        public override void IngresarDinero(double ingreso)
        {
            saldo += ingreso + ingreso * porcentaje;
            Console.WriteLine("\n Ha efectuado un ingreso de {0} euros.", ingreso);
        }

        //métodos de implementación
    }
}
