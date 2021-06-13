using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_04
{
    class Puntero
    {
        //atributos (implementación)
        private int posX;
        private int posY;
        private Tablero tableroJuego;

        //constructores (interface)
        public Puntero(int inicio_X, int inicio_Y)
        {
            posX = Control_X_inicial(inicio_X);                     
            posY = Control_Y_inicial(inicio_Y);            
            
            if (posX != inicio_X || posY != inicio_Y)
            {
                Console.WriteLine("!!Atención¡¡");
            }
            
            if (posX != inicio_X)
            {
                Console.WriteLine(" - La posición inicial del puntero, selecionada para el eje X," +
                    " excede los limites del tablero.\nUbicación alternativa establecida por el" +
                    " sistema en el centro del eje (coordenada X): {0}", posX);   
            }

            if (posY != inicio_Y)
            {
                Console.WriteLine(" - La posición inicial del puntero, selecionada para el eje Y," +
                    " excede los limites del tablero.\nUbicación alternativa establecida por el" +
                    " sistema en el centro del eje (coordenada Y): {0}", posY);   
            }
        }

        public Puntero()
        {
            Console.WriteLine("\nIntroduzca posición inicial Puntero" +
                              "\n===================================");
            Console.Write("Posición en eje X: ");
            int inicio_X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Posición en eje Y: ");
            int inicio_Y = Convert.ToInt32(Console.ReadLine());

            posX = Control_X_inicial(inicio_X);
            posY = Control_Y_inicial(inicio_Y);

            if (posX != inicio_X || posY != inicio_Y)
            {
                Console.WriteLine("!!Atención¡¡");
            }

            if (posX != inicio_X)
            {
                Console.WriteLine(" - La posición inicial del puntero, selecionada para el eje X," +
                    " excede los limites del tablero.\nUbicación alternativa establecida por el" +
                    " sistema en el centro del eje (coordenada X): {0}", posX);
            }

            if (posY != inicio_Y)
            {
                Console.WriteLine(" - La posición inicial del puntero, selecionada para el eje Y," +
                    " excede los limites del tablero.\nUbicación alternativa establecida por el" +
                    " sistema en el centro del eje (coordenada Y): {0}", posY);
            }
        }

        //propiedades (interface)
        

        //métodos de acceso (interface)
        public void setTablero (Tablero tabla)
        {
            tableroJuego = tabla;
        }


        public void VerPosicion()
        {
            Console.WriteLine("Coord.X = {0} -- Coord.Y = {1}", posX, posY);
        }

        public void MovArriba()
        {
            if (posX < tableroJuego.Tamanyo_X)
            {
                posX += 1;
            }
        }

        public void MovAbajo()
        {
            if (posX > tableroJuego.Tamanyo_X)
            {
                posX -= 1;
            }
        }

        public void MovIzquierda()
        {
            if (posY > tableroJuego.Tamanyo_Y)
            {
                posY -= 1;
            }
        }

        public void MovDerecha()
        {
            if (posY < tableroJuego.Tamanyo_Y)
            {
                posY += 1;
            }
        }


        //métodos privados (implementación)

        private int Control_X_inicial(int x)
        {        
            if (x <= tableroJuego.Tamanyo_X)
            {
                return x;
            }
            else
            {
                return tableroJuego.Tamanyo_X / 2;
            }
        }

        private int Control_Y_inicial(int y)
        {

            if (y <= tableroJuego.Tamanyo_Y)
            {
                return y;
            }
            else
            {
                return tableroJuego.Tamanyo_Y / 2;
            }
        }
    }
}
