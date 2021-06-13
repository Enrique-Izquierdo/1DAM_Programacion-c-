using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_04
{
    class CMaquina
    {
        //atributos
        private double ganancia;
        private int numBotellas;
        private static double precio = 1;

        //propiedades
        //constructores
        public CMaquina(int numBotellas)
        {
            ganancia = 0;
            this.numBotellas = numBotellas;
        }

        //getters y setters
        public int getNumBotellas()
        {
            return numBotellas;
        }

        public double getGanancias()
        {
            return ganancia;
        }

        public static void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        //otros métodos de interface
        public string Extraer(CTarjeta tarj)
        {
            if (getNumBotellas() <= 0)
            {
                return "Existencias agotadas";
            }
            else if (tarj.getSaldo() >= precio)
            {
                tarj.Descontar(precio);
                ganancia += precio;
                numBotellas--;
                return "Su botella. Gracias";
            }
            else
            {
                return "Saldo insuficiente";
            } 
        }

        public void VerInfo()
        {
            Console.WriteLine("\nDatos máquina expendedora agua:\nPrecio botella: {0} euro/ud.\nGanancia: {1} euros" +
                "\nStock botellas: {2} unidades.\n", precio, getGanancias(), getNumBotellas());
        }

        //métodos de implementación
    }
}
