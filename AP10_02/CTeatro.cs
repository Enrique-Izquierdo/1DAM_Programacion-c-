using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP10_02
{
    class CTeatro
    {
        //atributos
        private string nombreTeatro;
        private string direccionTeatro;
        private CFuncion[] arrayFunciones;

        //propiedades
        //constructores
        public CTeatro (string pNombreTeatro, string pDireccionTeatro, 
            string[] pNombresFunciones, double[] pPreciosFunciones)
        {
            nombreTeatro = pNombreTeatro;
            direccionTeatro = pDireccionTeatro;
            arrayFunciones = new CFuncion[4];

            for (int i = 0; i < arrayFunciones.Length; i++)
            {
                arrayFunciones[i] = new CFuncion(pNombresFunciones[i], pPreciosFunciones[i]);                
            }
        }

        //getters y setters
        public string getNombreTeatro()
        {
            return nombreTeatro;
        }

        public string getDireccionTeatro()
        {
            return direccionTeatro;
        }

        public CFuncion[] getArraryFunciones()
        {
            return arrayFunciones;
        }

        public void setNombreFuncion_Teatro(int pNumeroFuncion, string pNombreFuncion)
        {
            arrayFunciones[pNumeroFuncion].setNombreFunc(pNombreFuncion);
        }

        public void setPrecioFuncion_Teatro(int pNumeroFuncion, double pPrecioFuncion)
        {
            arrayFunciones[pNumeroFuncion].setPrecioFunc(pPrecioFuncion);
        }

        public string getNombreFuncion_Teatro(int pNumeroFuncion)
        {
            return arrayFunciones[pNumeroFuncion].getNombreFunc();
        }

        public double getPrecioFuncion_Teatro(int pNumeroFuncion)
        {
            return arrayFunciones[pNumeroFuncion].getPrecioFunc();
        }

        //otros métodos interface
        public void BuscadorPorLetraDeFunciones_Teatro(char letra)
        {
            Console.Write("Funciones representadas en el teatro que empiezan por la letra {0}: ", letra);

            for (int i=0; i<arrayFunciones.Length; i++)
            {             
               if(arrayFunciones[i].getNombreFunc()[0] == letra)
               {
                    Console.Write("{0}, ", arrayFunciones[i].getNombreFunc());
               }
            }            
        }

        //métodos implementación

    }
}
