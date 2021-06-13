using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP13
{
    class Presupuesto
    {
        //atributos
        private string nombre;        
        private Control.ControlCollection tipoSeguro;
        private Control.ControlCollection equipamiento;
        private double valorVehiculo;
        const double segBasico = 500;
        const double segTerceros = 750;
        const double segTodoRiesgo = 1000;
        const double eqAireAc = 100;
        const double eqAudio = 120;

        //propiedades
        //constructores
        public Presupuesto(string nombre, Control.ControlCollection tipoSeg, Control.ControlCollection equip, double valorVeh)
        {
            this.nombre = nombre;            
            tipoSeguro = tipoSeg;
            equipamiento = equip;
            valorVehiculo = valorVeh;
        }

        //getters y setters
        //otros métodos interface
        public override string ToString()
        {
            string mensaje ="";

            mensaje += "Valor del Vehículo: " + valorVehiculo.ToString() 
                + " Euros.\r\nPresupuesto de seguro para " + nombre +".";

            foreach (RadioButton elem in tipoSeguro)
            {
                if (elem.Text == "Básico" &&  elem.Checked)
                {
                    mensaje += "\r\nSeguro " + elem.Text + ": " + segBasico.ToString() + " Euros.";
                }
                else if (elem.Text == "A Terceros" && elem.Checked)
                {
                    mensaje += "\r\nSeguro " + elem.Text + ": " + segTerceros.ToString() + " Euros.";
                }
                else if(elem.Text == "Todo Riesgo" && elem.Checked)
                {
                    mensaje += "\r\nSeguro a " + elem.Text + ": " + segTodoRiesgo.ToString() + " Euros.";
                }
            }
            

            foreach (CheckBox elem in equipamiento)
            {
                if (elem.Text == "Aire Acondicionado" && elem.Checked)
                {
                    mensaje += "\r\nSeguro (Incremento -- " + elem.Text + "): " + eqAireAc.ToString() + " Euros.";
                }
                else if (elem.Text == "Sistema de Audio" && elem.Checked)
                {
                    mensaje += "\r\nSeguro (Incremento -- " + elem.Text + "): " + eqAudio.ToString() + " Euros.";
                }
            }

            mensaje += "\r\nTotal Seguro: " + CalcularSeguro().ToString() + " Euros.";

            return mensaje;
        }

        //métodos implementación
        private double CalcularSeguro()
        {
            double coste = 0;

            foreach (RadioButton elem in tipoSeguro)
            {
                if (elem.Text == "Básico" && elem.Checked)
                {
                   coste = 500;
                }
                else if (elem.Text == "A Terceros" && elem.Checked)
                {
                    coste = 750;
                }
                else if (elem.Text == "Todo Riesgo" && elem.Checked)
                {
                    coste = 1000;
                }
            }


            foreach (CheckBox elem in equipamiento)
            {
                if (elem.Text == "Aire Acondicionado" && elem.Checked)
                {
                    coste += 100;
                }
                else if (elem.Text == "Sistema de Audio" && elem.Checked)
                {
                    coste += 120;
                }
            }

            return coste;
        }

    }
}
