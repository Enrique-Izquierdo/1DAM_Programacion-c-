using System;
using System.Collections;
using System.Collections.Generic;

namespace AP7_16
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaTemp = new ArrayList();
            double temp, tempMax, tempMin;
            bool pedirValor = true;

            do
            {
                Console.Write("Introduce una temperatura: ");
                temp = Convert.ToDouble(Console.ReadLine());

                if (temp != 99)
                {
                    listaTemp.Add(temp);
                } 
                else
                {
                    pedirValor = false;
                }

            } while (pedirValor);

            tempMax = (double)listaTemp[0]; 
            tempMin = (double)listaTemp[0];

            
            for (int i = 0; i < listaTemp.Count; i++)
            {
                if ((double)listaTemp[i] < tempMin)
                {
                    tempMin = (double)listaTemp[i];
                } 
                
                if ((double) listaTemp[i] > tempMax)
                { 
                    tempMax = (double)listaTemp[i];
                }
            }
           
            Console.WriteLine("{0} de maxima y {1} de minima", tempMax, tempMin);
            Console.ReadKey();
        }
    }
}
