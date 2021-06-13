using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Deporte[] constr = new Deporte[3] {new Futbol("Futbol","goles"),
                new Baloncesto("Baloncesto","canastas"), new Rugby("Rugby","ensayos")};
            
            Deporte[] sports = new Deporte[10];

            Random rnd = new Random();


            for (int i=0; i<sports.Length; i++)
            {
                sports[i] = constr[rnd.Next(constr.Length)];
                sports[i].VerInfo();
            }

            Console.ReadKey();

        }
    }
}
