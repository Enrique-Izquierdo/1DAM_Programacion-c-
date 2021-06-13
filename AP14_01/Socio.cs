using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP14_01
{
    class Socio
    {
        //atributos
        private string nombre;
        private int edad;
        private string nif;
        private char sexo;
        private double peso;
        private float altura;

        //constructores
        public Socio(string nom, int ed, char sex, double pes, float alt)
        {
            nombre = nom.ToUpper();
            edad = ed;
            sexo = sex;
            peso = pes;
            altura = alt;
            nif = GeneraNIF();
        }
                
        //Propiedades
        public string Nombre { get { return nombre; } }
        public string Nif { get { return nif; } }

        //Métodos
        public string CalcularIMC()
        {
            if ((peso/Math.Pow(altura/100, 2)) >= 25)
            {
                return "Tienes sobrepeso";
            }
            else if ((peso / Math.Pow(altura/100, 2)) >= 18.5)
            {
                return "Tu peso es ideal";
            }
            else
            {
                return "Tienes un peso bajo";
            }
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        public override string ToString()
        {
            string mensaje = "Nombre: " + nombre + "\tNif: " + GeneraNIF()
                + "\nEdad: " + edad.ToString() + "\t\tSexo: " + sexo.ToString()
                + "\nPeso: " + peso.ToString() + "kg\tAltura: " + altura.ToString()
                + "cm\nEstado: " + CalcularIMC();

            return mensaje;
        }

        private string GeneraNIF()
        {
            Random rnd = new Random();
            int dni = rnd.Next(10000000, 100000000);
            char[] letras = new char[]{'T','R','W','A','G','M','Y','F','P',
                'D','X','B','N','J','Z','S','Q','V','H','L','C','K','E'};
            char letra = letras[dni % 23];
            return Convert.ToString(dni) + Convert.ToString(letra);
        } 
        
    }
}
