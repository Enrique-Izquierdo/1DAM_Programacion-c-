using System;

namespace ReservaDeCitasMedicas
{
    class ReservaCitas
    {
        static int MAXCITAS = 15;   // Máximo número de citas.
        static int INTERVALO = 20;  // Duración en minutos de una cita.

        DateTime diaCitas;      // Dia de las citas.
        TimeSpan horaInicio;    // Hora de inicio de las citas de un día.
        Cita[] citas;           // Array con las citas del día (sip y tipo de cita por cada elemento).
        int numCitas;           // Número de citas realizadas en el día.
        int numPrimeraCita = 0; // Número de citas que son de tipo PRIMERA cita.

        // int numPrimeras  // falta por comentar.

        // Propiedad de acceso a MAXCITAS (Solo de lectura)
        public int MaxCitas { get { return MAXCITAS; } }


        // Las citas comienzan a las 15:00 horas por defecto.
        // Se hace uso de la Clase TimeSpan (que gestiona instantes de tiempo -HH:MM:SS-
        public ReservaCitas()
        {
            diaCitas = DateTime.Today;              // Día de citas --> el actual.
            horaInicio = new TimeSpan(15, 00, 00);  // Inicio de las citas: a las 15:00 horas.
            citas = new Cita[MAXCITAS];             // Se dimensiona el array de citas al máximo permitido.
            numCitas = 0;                           // Cantidad de citas iniciales es 0.            
        }

        // Devolución de la hora de inicio de las citas.
        public TimeSpan getHoraInicio()
        {
            return horaInicio;
        }

        // Devolución del número de citas existentes
        public int getNumCitas() {
            return numCitas;
        }

        // Dado el número de orden de una cita, calcula el instante (hora y minuto en que se produce)
        public string horaCita(int orden)
        {
            int minutos = orden * INTERVALO;
            TimeSpan hora = new TimeSpan(0,minutos,0);
            return horaInicio.Add(hora).ToString();
        }


        /*Explicación funcionalidad DarCitaPosElegida():
         *==============================================
         * a. Invocando la funcionalidad BuscarLibre() (codificado por el anterior técnico), 
         *    comprueba si quedan huecos disponibles para mantener una de las la funcionalidades
         *    del método DarCita().
         * b. Si la lista de reservas está llena, muestra el mensaje "No quedan huecos" y
         *    finaliza el proceso, asignando a la variable "situacion" el string "salir".
         * c. Si quedan posiciones libres, solicita el ingreso por teclado del número de
         *    posición o, de la letra "S" para poder salir del proceso. De esta forma permitimos 
         *    que el usuario pueda salir del proceso, en caso de que las posiciones solicitadas
         *    estén ocupadas.             
         * d. Validamos la respuesta mediante el método de implementación ValidarRespuesta(), 
         *    al que se le pasa por parámetro la respuesta (string) ingresada por el usuario, 
         *    y los datos con los que debe comparar la respuesta (el string de salida "S", 
         *    y los valores mínimo y máximo permitidos); comportandose de la siguiente manera:
         *  1º. Comprueba si se ha introducido la letra "S" y, en caso afirmativo, informa que
         *      el usuario ha salido del proceso sin registrar la cita y devuelve el string 
         *      "pedirValores".
         *  2º. Comprueba, en caso de que no se haya introducido la letra "S", que la posición
         *      ingresada se encuentra dentro del rango permitido de posiciones y, devuelve 
         *      el string "correcto".
         *  3º. Y, si la posición no está dentro del rango permitido, informa de que el valor
         *      introducido no es válido y devuelve el string "pedirValores.
         *            
         * e. Comprueba que la posición seleccionada está libre.
         * f. Si la posición está libre, carga la cita en el array de citas; y mantiene el resto 
         *    de comportamientos de la funcionalidad DarCita().
         * g. Si la posición está ocupada, informa de que la posición no esta libre y vuelve al 
         *    apartado "a" para que el usuario pueda solicitar otro turno, sin tener que
         *    introducir nuevamente el "sip" y el "tipo de consulta".
         * */


        public void DarCitaPosElegida(Cita c)
        {
            bool valido;
            string resp;            
            
            if (BuscarLibre() == -1) //a
            {
                    Console.WriteLine("\nNo quedan huecos"); //b                    
            }
            else
            {
                do
                { 
                    do
                    {
                        Console.Write("Indique en que turno (posición) -del 0 al {0}- desea ser " + //c
                              "atendido o,\n teclee S para salir del proceso: ", citas.Length - 1);
                        resp = Console.ReadLine();
                        valido = ValidarRespuesta(resp, "S", 0, MAXCITAS); //d
                    } while (!valido);

                    if (int.TryParse(resp, out int pos))
                    {
                        if (citas[pos] == null) //e
                        {
                            citas[pos] = c; //f
                            numCitas++;
                            if (c.getTipo() == Cita.PRIMERA) numPrimeraCita++;  // Las citas de tipo PRIMERA tienen valor 0.
                            Console.WriteLine("\nReserva realizada: {0}, {1}, {2}",
                            c.getSip(), c.getTipo(), horaCita(pos));
                            valido = true;
                        }
                        else
                        {
                            Console.WriteLine("\nLa posición (turno) {0} no está disponible.", pos); //g
                            valido = false;
                        }
                    }
                } while (!valido);
            } 
        }


        /* Listado de todas las citas, linea a linea, con el formato
         * "pos: (hh:mm): Libre" si está libre.
         * "pos: (hh:mm): Ocupada, sip, tipo de visita" si está ocupada.
         */
        public void  Listar()
        {
            Console.WriteLine("\nInformación actual de citas médicas del día: {0:d}", diaCitas);
            Console.WriteLine("=======================================================\n");
            for (int i = 0; i < citas.Length; i++)
            {
                Console.Write("{0}: {1}: ", i, horaCita(i));
                if (citas[i] == null)
                {
                    Console.WriteLine("Libre.");
                } else
                {
                    Console.WriteLine("Ocupada, SIP: {0}, Tipo: {1}",citas[i].getSip().ToUpper(), citas[i].getTipo());
                }
            }
            Console.WriteLine("\n<Pulsa una tecla>");
        }

        /* Devuelve el número de la primera cita libre.
         * Si no hay libres se devuelve -1
         * Las citas están numeradas desde 0 en adelante.
         */
        public int BuscarLibre()
        {
            for (int i = 0; i < citas.Length; i++)
            {
                if (citas[i] == null) return i; //Importante: se cambio el operador de comparaciónde != a == 
            }                                   //para que devuelva la primera posición libre. Además se
            return -1;                          //comprueba que dicho cambio no afecta a otras partes del
        }                                       //código, ya que este método no es invocado.

        /* Dado el sip de un paciente, devuelve el número de la dira reservada por el paciente.
         * Si no hay reserva con el sip indicado devuelve -1.
         */
        public int buscarCita(string sip)
        {
            for (int i = 0; i < citas.Length; i++)
            {
                if (citas[i] != null && citas[i].getSip() == sip.ToUpper()) return i;
            }
            return -1;
        }

        /* Reserva la Cita c en el primer horario libre y escribe en consola la confirmación 
         * con el siguiente formato: "Reserva realizada; sip, tipo de visita, hh:mm".
         * Si no quedan huecos disponibles, la reserva no se realiza y se 
         * escribe en consola el mensaje "No quedan huecos".
         */
        public void DarCita(Cita c)
        {
            int pos = 0;
            bool encontrado = false;
            while (pos <= citas.Length && !encontrado)
            {
                if(citas[pos] == null) // Si la cita de esa posición está vacia la ocupamos.
                {
                    citas[pos] = c;
                    numCitas++;
                    if (c.getTipo() == Cita.PRIMERA) numPrimeraCita++;  // Las citas de tipo PRIMERA tienen valor 0.
                    encontrado = true;
                    Console.WriteLine("Reserva realizada: {0}, {1}, {2}", 
                        c.getSip(), c.getTipo(), horaCita(pos));
                }
                pos++;
            }
            if (!encontrado)
                Console.WriteLine("No quedan huecos");
        }


        /*Cancela la cita de un paciente especificado por su sip
         * Si el paciente existe cancelado la cita e informa de ello.
         * Si no existe avisa de la no existencia del paciente.
         */
        public void CancelarCita(string sip)
        {
            int pos = buscarCita(sip);
            if (pos==-1)
            {
                Console.WriteLine("No existe cita para el paciente con SIP {0}", sip);
            } else
            {
                if (citas[pos].getTipo() == Cita.PRIMERA) numPrimeraCita--; // Las citas de tipo PRIMERA tienen valor 0.
                citas[pos] = null;
                numCitas--;
                Console.WriteLine("Cancelada la cita {0} del paciente con SIP {1}", pos, sip.ToUpper());
            }
        }

        /* Obtiene las citas reservadas que corresponden a una primera visita.
         * Devuelve un array de string, del tamaño justo y necesario 
         * con los códigos de los pacientes (sip) que han reservado
         * cita por primera vez. Si no hay ninguno, devuelve el array vacio
         */
        public string[] PacientesPrimeraCita()
        {
            string[] pacPrimera = new string[numPrimeraCita];
            int pos = 0;
            for (int i = 0; i < citas.Length; i++)
            {
                if(citas[i] != null && citas[i].getTipo() == Cita.PRIMERA) // Las citas de tipo PRIMERA tienen valor 0.
                {
                    pacPrimera[pos] = citas[i].getSip();
                }
                pos++;
            }
            return pacPrimera;
        }


        //métodos de implementación

        private bool ValidarRespuesta(string respuesta, string caracterSalida, int min, int max)
        {
            if (respuesta.ToUpper() == caracterSalida) 
            {
                Console.WriteLine("\nHa seleccionado salir del proceso. " +
                    "Su cita no ha sido registrada.");
                return true;
            }
            else if (int.TryParse(respuesta, out int pos) && pos >= min && pos < max)
            {
                return true;
            }
            else
            {
                Console.WriteLine("\nLos valores introducidos no son válidos.");
                return false;
            }
        }
    }
}
