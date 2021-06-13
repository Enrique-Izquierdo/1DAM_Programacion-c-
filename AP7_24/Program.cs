using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP7_24
{
    class Program
    {
        static string TipoCaracter(string tecla)
        {
            char c;
            byte num;
            if (char.TryParse(tecla, out c))
            {
                if (byte.TryParse(tecla, out num))
                {
                    return "numérico";
                }
                else if (char.IsLetter(c))
                {
                    return "alfabético";
                }
                else
                {
                    return "no alfabético, ni numérico";
                }
            }
            else
            {
                return "indeterminado, porque ha tecleado mas de un caracter";
            }
        }

        static void Main(string[] args)
        {
            string caracString;
            do
            {               
                Console.Write("Teclea un caracter (el caracter \".\" finaliza la ejecución del programa): ");
                caracString = Console.ReadLine();
                Console.WriteLine("Ha ingresado por teclado un caracter de tipo: {0}.", TipoCaracter(caracString));
            } while (caracString != ".");            
            
            Console.ReadKey();
        }
    }
}
