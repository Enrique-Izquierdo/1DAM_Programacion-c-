using System;

namespace ReservaDeCitasMedicas
{
    class Cita
    {
        //Clasificacion de tipos de citas
        //Son públicas porque son constantes y no se pueden variar sus valores desde otras clases.
        //Se usarán para consultar el tipo de cita de una forma más lógica.
        public const int PRIMERA = 0;
        public const int CONSULTA = 1;
        public const int REVISION = 2;

        string sip;     // Identificación Sanitaria del paciente
        int tipo;       // Tipo de la cita


        // Constructor -Crea una cita de un tipo determinado para un paciente con SIP-
        public Cita(string identificacion, int tipoCita)
        {
            this.sip = identificacion;
            this.tipo = tipoCita;
        }

        // Constructor - Crea una cita pidiendo los datos por teclado
        public Cita()
        {
            Console.Write("\nSIP del paciente: ");
            sip = Console.ReadLine().ToUpper();
            Console.Write("Tipo de consulta -Primera ({0}) - Consulta ({1}) - Revisión ({2})-: ",
                    PRIMERA, CONSULTA, REVISION);
            tipo = int.Parse(Console.ReadLine());
        }
        

        // Devolución del SIP del paciente que tiene la cita.
        public string getSip() { 
            return sip; 
        }

        //  Devolución del tipo de la cita
        public int getTipo()
        {
            return tipo;
        }

        // Devolución de la información de la cita en formato: "sip -- tipo de cita".
        // Sobreescribimos el método ToString heredado de Object
        public override string ToString()
        {
            string resultado = this.sip;
            switch(this.tipo)
            {
                case PRIMERA:
                    resultado += " -- Primera Visita";
                    break;
                case CONSULTA:
                    resultado += " -- Consulta ordinaria";
                    break;
                case REVISION:
                    resultado += " -- Revisión";
                    break;
            }
            return resultado;
        }
    }
   
}
