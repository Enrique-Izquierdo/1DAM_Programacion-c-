using System;


namespace ReservaDeCitasMedicas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaro objeto pra gestionar las citas del día
            // Inicialmente todas las citas estarán vacias.
            ReservaCitas reserva = new ReservaCitas();
            reserva.Listar();
            Console.ReadKey();

            int opcion;

            do
            {
                opcion = visualizaMenuPrincipal();
                switch (opcion)
                {
                    case 1:
                        reserva.Listar();
                        break;
                    case 2:
                        Cita c1 = new Cita();
                        reserva.DarCita(c1);
                        break;
                    case 3:
                        Cita c2 = new Cita();
                        reserva.DarCitaPosElegida(c2);
                        break;
                    case 4:
                        Console.Write("SIP del paciente: ");
                        string sip = Console.ReadLine();
                        reserva.CancelarCita(sip);
                        break;
                    case 5:
                        Console.WriteLine("Finaliza la aplicación");
                        break;
                }
                Console.ReadKey();

            } while (opcion != 5);




        }

        static int visualizaMenuPrincipal()
        {
            int respuesta;

            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ DE OPCIONES:");
                Console.WriteLine("=================\n");
                Console.WriteLine("1. Listar citas del día");
                Console.WriteLine("2. Dar cita automática a un paciente.");
                Console.WriteLine("3. Dar cita a un paciente en un orden dado.");
                Console.WriteLine("4. Cancelar una cita.");
                Console.WriteLine("5. Finalizar.");
                Console.Write("\nElige opción (1..5): ");
                respuesta = int.Parse(Console.ReadLine());
                if (respuesta < 1 || respuesta > 5)
                {
                    Console.WriteLine("Opción incorrecta. <pulsa tecla>");
                    Console.ReadKey();
                }
            } while (respuesta < 1 || respuesta > 5);

            return respuesta;
        }
    }
}
