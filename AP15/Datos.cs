using System;
using System.IO;
using System.Collections.Generic;

namespace AP15
{
    static class Datos
    {
        //atributos
        private static List<Empleado> plant = new List<Empleado>();

        //propiedades
        public static List<Empleado> Plant { get { return plant; } }

        //constructor
        //getters y setters
        //otros métodos de interface
        public static void AgregarEmpleado(Empleado a)
        {
            plant.Add(a);
        }

        public static int NumEmpleados()
        {
            return plant.Count;
        }

        public static string EstadisticasPlantilla(DateTime fecha)
        {
            int numero = 0;
            double porcentaje = 0;
            /* Mediante la palabra "ref", pasamos las variables de tipo int y double
             * por referencia. No utilizamos "ref" con la variable de tipo DateTime,
             * porque los objetos siempre pasan por referencia.*/ 
            EstadisticaNacimiento(fecha, ref numero, ref porcentaje);

            string mensaje = " - Salario promedio: " + SalarioPromedio().ToString("n") +
                             "\n - Coste mensual empleados: " + TotalSalarios().ToString() +
                             "\n - Número y porcentaje de empleados nacidos antes de " +
                             fecha.ToShortDateString() + ":\n   " + numero.ToString() +
                             " empleados, el " + porcentaje.ToString("p") + " de la plantilla";

            return mensaje;
        }


        public static void CargarArchivoEnLista()
        {
            string ruta = "datosEmpleados.txt";
            StreamReader fichero = new StreamReader(ruta);

            string linea;
            while ((linea = fichero.ReadLine()) != null)
            {
                string[] datos = linea.Split(';');

                Empleado emp = new Empleado(datos[0], datos[1], datos[2], bool.Parse(datos[3]),
                    Convert.ToDouble(datos[4]), DateTime.Parse(datos[5]));

                plant.Add(emp);
            }

            fichero.Close();
        }



        public static void GuardarListaEnArchivo()
        {

            string ruta = "datosEmpleados.txt";
            StreamWriter fichero = new StreamWriter(ruta);

            foreach (Empleado elemento in Plant)
            {
                string registroLinea = elemento.Nombre + ";" + elemento.PrimerApellido +
                    ";" + elemento.Puesto + ";" + elemento.Activo.ToString() + ";" + 
                    elemento.SalarioMensual.ToString() +";" + elemento.FechaNacimiento.ToString();
                
                fichero.WriteLine(registroLinea);
            }

            fichero.Close();
        }

        //métodos de implementación

        private static double SalarioPromedio()
        {
            return TotalSalarios() / plant.Count;
        }

        private static double TotalSalarios()
        {
            double totalSalarios = 0;
            for (int i = 0; i < plant.Count; i++)
            {
                totalSalarios += plant[i].SalarioMensual;
            }
            return totalSalarios;
        }

        /* Mediante la palabra "ref", pasamos las variables de tipo int y double por referencia.
         * No utilizamos "ref" con la variable de tipo DateTime,
         * porque los objetos siempre pasan por referencia.*/
        private static void EstadisticaNacimiento(DateTime fecha, ref int ctdadEmpleados, ref double porcEmpleados)
        {
            ctdadEmpleados = 0;
            for (int i = 0; i < plant.Count; i++)
            {
                if(plant[i].FechaNacimiento.Date < fecha)
                {
                    ctdadEmpleados += 1;
                }
            }
            porcEmpleados = ctdadEmpleados / (double)plant.Count;
            /* Hacemos un casting para evitar que se pierdan los decimales,
             * transformando plant.Count de int a double*/
        }
    }
}
