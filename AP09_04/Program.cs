using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_04
{
    class Program
    {
        static int OpcionMenu()
        {
            Console.WriteLine("\n Movimientos permitidos" +
                  "\n ======================" +
                  "\n 1. Arriba." +
                  "\n 2. Abajo." +
                  "\n 3. Izquierda." +
                  "\n 4. Derecha." +
                  "\n 5. Salir / Acabar.");
            Console.Write(" Introduzca Opción (1..5): ");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Tablero tabla;
            Puntero ficha;            
                       
            tabla = new Tablero();
            tabla.VerTamayo();
            ficha = new Puntero();
            ficha.VerPosicion();
            
            Console.WriteLine("\nPresiona cualquier techa para iniciar el juego.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                switch (OpcionMenu())
                {
                    case 1:
                        ficha.MovArriba();                        
                        break;
                    case 2:
                        ficha.MovAbajo();
                        break;
                    case 3:
                        ficha.MovIzquierda();
                        break;
                    case 4:
                        ficha.MovDerecha();
                        break;
                    default:
                        Console.WriteLine(" NO existe la opción elegida");
                        break;
                }
                
                if (OpcionMenu()>=1 && OpcionMenu() <= 4)
                {
                    ficha.VerPosicion();
                }

                Console.WriteLine("\n Presione cualquier tecla para continuar");
                Console.Clear();

            } while (OpcionMenu()!=5);

            Console.WriteLine("\n Ha seleccionado salir del juego." +
                "\n Presione cualquier tecla para cerrar el programa.");

        }
    }
}
