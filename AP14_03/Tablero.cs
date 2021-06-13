using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP14_03
{
    class Tablero
    {
        private int posX;        
        private int posY;
        const int xMaxima = 10;
        const int xMinima = 0;
        const int yMaxima = 10;
        const int yMinima = 0;


        public Tablero()  // Constructor de la Clase.
        {
            posX = 5;
            posY = 5;

        }

        
        // métodos de acceso de lectura de las posiciones
        public int getPosX() 
        {
            return posX;
        }

        public int getPosY()
        {
            return posY;
        }


        public void MostrarPosicion()
        {
            Console.WriteLine("\nCoord.X = {0} -- Coord.Y = {1}", posX, posY);
            Console.WriteLine("<Pulsa tecla>");
        }

        // Métodos para modificar la posición.
        public void MoverArriba()
        {
            posY++;
            if (posY == yMaxima)
            {
                posY = yMaxima - 1;
            }
        }

        public void MoverAbajo()
        {
            posY--;
            if (posY==yMinima) // Si hemos llegado a la posición yMinima, la situamos en 1.
            {
                posY = yMinima + 1;
            }
        }

        public void MoverIzquierda()
        {
            posX--;
            if (posX==xMinima) // Si hemos llegado a la posición xMinima, la situamos en 1.
            {
                posX = xMinima + 1;
            }
        }

        public void MoverDerecha()
        {
            posX++;
            if (posX == xMaxima) // Si hemos llegado a la posición xMinima, la situamos en 1.
            {
                posX = xMaxima - 1;
            }
        }

    }



}
