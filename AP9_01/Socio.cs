using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_01
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

        public Socio()
        {
            Console.WriteLine("Introducción datos del Socio");
            Console.WriteLine("============================");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine().ToUpper();
            Console.Write("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sexo (H/M): ");
            sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura (metros): ");
            altura = float.Parse(Console.ReadLine());
            nif = GeneraNIF();
        }

        //Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        //Métodos
        public string CalcularIMC()
        {
            if ((peso/Math.Pow(altura, 2)) >= 25)
            {
                return "alto";
            }
            else if ((peso / Math.Pow(altura, 2)) >= 18.5)
            {
                return "medio";
            }
            else
            {
                return "bajo";
            }
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        public void Informa()
        {
            Console.WriteLine("Nombre: {0}\tDNI: {1}", nombre, nif);
            Console.WriteLine("Edad: {0}\tSexo: {1}", edad, sexo);
            Console.WriteLine("Peso: {0}\tAltura: {1}", peso, altura);
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
