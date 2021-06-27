using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    class Fichaje
    {
        /*------------atributos-------------*/
        #region(atributos)
        private int idRegistro;
        private string nif;
        private DateTime entrada_FechaHora;
        private bool entrada_Estado;
        private DateTime salida_FechaHora;
        private bool salida_Estado;
        #endregion


        /*-----------propiedades------------*/
        #region(propiedades)
        public int IdRegistro { get { return idRegistro; } set { idRegistro = value; } }
        public string Nif { get { return nif; } set { nif = value; } }
        public DateTime Entrada_FechaHora { get { return entrada_FechaHora; } set { entrada_FechaHora = value; } }
        public bool Entrada_Estado { get { return entrada_Estado; } set { entrada_Estado = value; } }
        public DateTime Salida_FechaHora { get { return salida_FechaHora; } set { salida_FechaHora = value; } }
        public bool Salida_Estado { get { return salida_Estado; } set { salida_Estado = value; } }
        #endregion


        /*----------constructores-----------*/
        #region(constructores)
        public Fichaje() { }

        public Fichaje(int idRegistro, string nif, DateTime entrada_FechaHora, bool entrada_Estado, DateTime salida_FechaHora, bool salida_Estado)
        {
            this.idRegistro = idRegistro;
            this.nif = nif;
            this.entrada_FechaHora = entrada_FechaHora;
            this.entrada_Estado = entrada_Estado;
            this.salida_FechaHora = salida_FechaHora;
            this.salida_Estado = salida_Estado;
        }
        #endregion


        /*--------getters y setters---------*/
        #region(getters y setters)
        #endregion


        /*----otros métodos de interface----*/
        #region(otros métodos de interface)

        public int RegistrarEntrada(Fichaje pFich)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO fichajes (id, nif, fechaHora_Entrada, estado_Entrada," +
                "fechaHora_Salida, estado_Salida) VALUES ('{0}','{1}','{2}',{3},'{4}',{5})", pFich.idRegistro,
                pFich.nif, pFich.entrada_FechaHora.ToString("yyyy-MM-dd HH:mm:ss"), pFich.entrada_Estado, 
                pFich.salida_FechaHora.ToString("yyyy-MM-dd HH:mm:ss"), pFich.salida_Estado);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        public static List<Fichaje> BuscarFichaje(MySqlConnection pConexion, string consulta)
        {
            List<Fichaje> lista = new List<Fichaje>();
            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creamos el objeto command al cual le pasamos la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            // Ejecutamos el comando y recibimos en un objeto DataReader la lista de registros seleccionados.
            // Recordemos que un objeto DataReader es una especie de tabla de datos virtual.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetString(0));
                    Fichaje fich = new Fichaje(reader.GetInt16(0),reader.GetString(1), reader.GetDateTime(2),
                        reader.GetBoolean(3), reader.GetDateTime(4), reader.GetBoolean(5));
                    lista.Add(fich);
                }
            }
            reader.Close();
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }


        #endregion


        /*-----métodos de implementación----*/
        #region(métodos de implementación)


        #endregion
    }
}
