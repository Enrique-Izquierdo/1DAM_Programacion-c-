using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP15
{
    class Empleado
    {
        //atributos
        private string nombre;
        private string primerApellido;
        private string puesto;
        private bool activo;
        private double salarioMensual;
        private DateTime fechaNacimiento;

        //propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string PrimerApellido { get { return primerApellido; } set { primerApellido = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public string Puesto { get { return puesto; } }
        public double SalarioMensual { get { return salarioMensual; } set { salarioMensual = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }

        //constructor
        public Empleado(string nom, string primerA, string pu, bool act, double salarioMensual,
            DateTime fechaNacimiento)
        {
            nombre = nom;
            primerApellido = primerA;
            puesto = pu;
            activo = act;
            this.salarioMensual = salarioMensual;
            this.fechaNacimiento = fechaNacimiento;
        }

        //getters y setters
        //otros métodos de interface
        public string MostrarDatos()
        {
            return ("Alta de último empleado:\n"+nombre+ " " + primerApellido);
        }

        public int CalcularEdad(string pFechaNac)
        {

            return DateTime.Today.Year - DateTime.Parse(pFechaNac).Year;
        }

        //métodos de implementación
    }
}
