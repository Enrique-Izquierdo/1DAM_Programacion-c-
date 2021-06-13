using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_01
{
    class Ccliente
    {
        //atributos
        private string nombreCliente;
        private string apellidoCliente;
        private string nifCliente;
        private Ccuenta[] arrayCuentas;

        //propiedades
        
        //constructores
        public Ccliente(string pNombre, string pApellido, string pNif)
        {
            nombreCliente = pNombre;
            apellidoCliente = pApellido;
            nifCliente = pNif;
            arrayCuentas = new Ccuenta[400];
        }

        //getters y setters
        public double getSaldo_CuentaDeArray(int pNumeroCuenta) // = ConsultarSaldodelaCuentaXdelArray()
        {
            return arrayCuentas[pNumeroCuenta].getSaldo();
        }

        public void setArrayCuentas(int pNumeroCuenta, Ccuenta pCuenta) // = AgregarCuentaaArray();
        {
            arrayCuentas[pNumeroCuenta] = pCuenta;
        }

        //otros métodos interface
        public void IngresarSaldo_CuentaDeArray(int pNumeroCuenta, int pSaldo)
        {
            arrayCuentas[pNumeroCuenta].IngresarSaldo(pSaldo);
        }

        public void RetirarSaldo_CuentaDeArray(int pNumeroCuenta, int pSaldo)
        {
            arrayCuentas[pNumeroCuenta].RetirarSaldo(pSaldo);
        }

        //métodos implementación

    }
}
