using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_23
{
    class Program
    {
        static int CalculaPuntos(Dictionary<string, int> partidos)
        {
            Dictionary<string, int> valorPartido = new Dictionary<string, int>();
            valorPartido["ganados"] = 3;
            valorPartido["perdidos"] = 0;
            valorPartido["empatados"] = 1;
                        
            int acumulaPuntos = 0;
            foreach (KeyValuePair<string, int> elemento in partidos)
            {
                switch (elemento.Key)
                {
                    case "ganados":
                        acumulaPuntos += partidos["ganados"]*valorPartido["ganados"];
                        break;
                    case "perdidos":
                        acumulaPuntos += partidos["perdidos"] * valorPartido["perdidos"];
                        break;
                    case "empatados":
                        acumulaPuntos += partidos["empatados"] * valorPartido["empatados"];
                        break;
                }                
            }
            return acumulaPuntos;
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> resultados = new Dictionary<string, int>();
            resultados.Add("ganados", 0);
            resultados.Add("perdidos", 0);
            resultados.Add("empatados", 0);

            string numString;
            int num, cont = 0;
            bool valido;
            int[] partGaPerEmp = new int[3];

            foreach (KeyValuePair<string, int> elemento in resultados)
            {
                do
                {
                    Console.Write("Introduce el número de partidos {0}: ", elemento.Key);
                    numString = Console.ReadLine();
                    valido = int.TryParse(numString, out num) && num>=0;
                    if (valido)
                    {
                        partGaPerEmp[cont] = num;
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("El valor introducido, no es valido");
                    }
                } while (!valido);           
            }

            resultados["ganados"] = partGaPerEmp[0];
            resultados["perdidos"] = partGaPerEmp[1];
            resultados["empatados"] = partGaPerEmp[2];

            Console.WriteLine("El equipo ha ganado {0} puntos en el torneo.", CalculaPuntos(resultados));
            Console.ReadLine();
        }
    }
}
