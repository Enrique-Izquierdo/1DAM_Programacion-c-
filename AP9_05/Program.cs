using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP9_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> listaVeh = new List<Vehiculo>();

            int numVeh;
            int posMenor = 0;

            Console.Write("Indique el número de vehículos a considerar: ");
            numVeh = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numVeh; i++)
            {
                Console.WriteLine("");
                Vehiculo coche = new Vehiculo();
                listaVeh.Add(coche);
            }

            for (int i = 0; i < listaVeh.Count - 1; i++)
            {
                if (listaVeh[i].Precio > listaVeh[i + 1].Precio)
                {
                    posMenor = i + 1;
                }
            }

            Console.WriteLine("\nEl vehículo más barato es:");
            listaVeh[posMenor].VerInfo();

            Console.ReadKey();
        }
    }
}
