using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public class Utilidades
    {
        /*------------atributos-------------*/
        #region(atributos)
        #endregion

        /*-----------propiedades------------*/
        #region(propiedades)
        #endregion

        /*----------constructores-----------*/
        #region(constructores)
        #endregion

        /*--------getters y setters---------*/
        #region(getters y setters)
        #endregion

        /*----otros métodos de interface----*/
        #region(otros métodos de interface)
        public static bool ValidarNif(string pNif)
        {
            bool valido = true;

            if (pNif.Length == 10)
            {
                string numeroNif = pNif.Substring(0, 8);
                string letraNif = pNif.Substring(9, 1);

                if (numeroNif.Length == 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        valido = valido && (numeroNif[i] >= '0' && numeroNif[i] <= '9');
                    }

                    valido = valido && (letraNif == ObtenerLetraNif(numeroNif));
                }
                else
                {
                    valido = false;
                }
            }
            else
            {
                valido = false;
            }
            return valido;
        }

        /// <summary>
        /// Para una tabla, un campo y un valor (tipo string) dado, devuelve True si existe algún registro 
        /// en la base de datos, donde el campo de la tabla coincida con el valor (tipo string) dado.
        /// </summary>
        /// <param name="pTabla">Nombre de la tabla de la base de datos donde buscar el registro</param>
        /// <param name="pCampo">Nombre del campo de la tabla donde buscar el valor (tipo string) dado</param>
        /// <param name="pValorCampo">Valor (tipo string) a buscar en el campo de tabla</param>
        /// <returns>bool</returns>
        public static bool ExisteRegistrosBD(string pTabla, string pCampo, string pValorCampo)
        {
            bool existe = false;
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    string consulta = String.Format("SELECT * FROM {0} WHERE {1} LIKE '{2}'", pTabla, pCampo, pValorCampo);

                    //MessageBox.Show(consulta); //Se puede activar esta línea para testear la sintaxis de la consulta.

                    // Creo el objeto command al cual le paso la consulta y la conexión
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

                    // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)   // En caso de que se encuentren registros en el objeto reader
                    {
                        existe = true;
                    }
                    reader.Close();

                    ConexionBDpST.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBDpST.CerrarConexion();
            }
            return existe;
        }

        
        /// <summary>
        /// Para una tabla, dos campos y dos valores (tipo string) dados, devuelve True si existe algún
        /// registro en la base de datos, donde los campos de la tabla coincidan con los valores (string) dados.
        /// </summary>
        /// <param name="pTabla">Nombre de la tabla de la base de datos donde buscar el registro</param>
        /// <param name="pCampo1">Nombre del campo de la tabla donde buscar el valor1 (tipo string) dado</param>
        /// <param name="pValorCampo1">Valor (tipo string) a buscar en el campo1 de tabla</param>
        /// <param name="pCampo2">Nombre del campo de la tabla donde buscar el valor2 (tipo string) dado</param>
        /// <param name="pValorCampo2">Valor (tipo string) a buscar en el campo2 de tabla</param>
        /// <returns>bool</returns>
        public static bool ExisteRegistrosBD(string pTabla, string pCampo1, 
            string pValorCampo1, string pCampo2, string pValorCampo2)
        {
            bool existe = false;
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    string consulta = String.Format("SELECT * FROM {0} WHERE {1} LIKE '{2}' AND {3} LIKE '{4}'", 
                        pTabla, pCampo1, pValorCampo1, pCampo2, pValorCampo2);

                    //MessageBox.Show(consulta); //Se puede activar esta línea para testear la sintaxis de la consulta.

                    // Creo el objeto command al cual le paso la consulta y la conexión
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

                    // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)   // En caso de que se encuentren registros en el objeto reader
                    {
                        existe = true;
                    }
                    reader.Close();

                    ConexionBDpST.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBDpST.CerrarConexion();
            }
            return existe;
        }



        /// <summary>
        /// Para una tabla, dos campos y dos valores (el primero tipo string, y el segundo boolean) dados, 
        /// devuelve True si existe algún registro en la base de datos, donde los campos de la tabla
        /// coincidan con los valores (string y boolean) dados.
        /// </summary>
        /// <param name="pTabla">Nombre de la tabla de la base de datos donde buscar el registro</param>
        /// <param name="pCampo1">Nombre del campo de la tabla donde buscar el valor1 (tipo string) dado</param>
        /// <param name="pValorCampo1">Valor (tipo string) a buscar en el campo1 de tabla</param>
        /// <param name="pCampo2">Nombre del campo de la tabla donde buscar el valor2 (tipo boolean) dado</param>
        /// <param name="pValorCampo2">Valor (tipo boolean) a buscar en el campo2 de tabla</param>
        /// <returns>bool</returns> 
        public static bool ExisteRegistrosBD(string pTabla, string pCampo1,
            string pValorCampo1, string pCampo2, bool pValorCampo2)
        {
            bool existe = false;
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    string consulta = String.Format("SELECT * FROM {0} WHERE {1} LIKE '{2}' AND {3} LIKE {4}",
                        pTabla, pCampo1, pValorCampo1, pCampo2, pValorCampo2);

                    //MessageBox.Show(consulta); // Se puede activar esta línea para testear la sintaxis de la consulta.

                    // Creo el objeto command al cual le paso la consulta y la conexión
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

                    // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)   // En caso de que se encuentren registros en el objeto reader
                    {
                        existe = true;
                    }
                    reader.Close();

                    ConexionBDpST.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBDpST.CerrarConexion();
            }
            return existe;
        }



        /// <summary>
        /// Para una tabla, dos campos, dos valores (tipo string) y los operadores de relación 
        /// establecidos por parámetro, devuelve True si existe algún registro en la base de datos que,
        /// para ambos pares campo - valor, cumpla con la relación establecida por los operadores.
        /// </summary>
        /// <param name="pTabla">Nombre de la tabla de la base de datos donde buscar el registro</param>
        /// <param name="pCampo1">Nombre del campo de la tabla donde buscar el valor1 (tipo string) dado</param>
        /// <param name="pOperador1">Operador que establece la relación a cumplir por el valor1 respecto al campo1</param>
        /// <param name="pValorCampo1">Valor (tipo string) a buscar en el campo1 de tabla</param>
        /// <param name="pCampo2">Nombre del campo de la tabla donde buscar el valor2 (tipo string) dado</param>
        /// <param name="pOperador2">Operador que establece la relación a cumplir por el valor2 respecto al campo1</param>
        /// <param name="pValorCampo2">Valor (tipo string) a buscar en el campo2 de tabla</param>
        /// <returns></returns>

        public static bool ExisteRegistrosBD(string pTabla, string pCampo1, string pOperador1,string pValorCampo1,
            string pCampo2, string pOperador2, string pValorCampo2)
        {
            bool existe = false;
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    string consulta = String.Format("SELECT * FROM {0} WHERE {1} {2} '{3}' AND {4} {5} {6}",
                        pTabla, pCampo1, pOperador1 ,pValorCampo1, pCampo2, pOperador2, pValorCampo2);

                    //MessageBox.Show(consulta); //Se puede activar esta línea para testear la sintaxis de la consulta.

                    // Creo el objeto command al cual le paso la consulta y la conexión
                    MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

                    // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)   // En caso de que se encuentren registros en el objeto reader
                    {
                        existe = true;
                    }
                    reader.Close();

                    ConexionBDpST.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                ConexionBDpST.CerrarConexion();
            }
            return existe;
        }


        public static int EliminarRegistrosBD(MySqlConnection pConexion, string pTabla, string pCampo, string pValorCampo)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM {0} WHERE {1} = '{2}'", pTabla, pCampo, pValorCampo);
            // MessageBox.Show(consulta); //   Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Actualiza los registros de una tabla en una base de datos, para aquellas consultas en las que:
        /// 1º.Se conozca el nombre de la tabla.
        /// 2º.Se quiera actualizar los valores datetime y booleano de dos campos conocidos.
        /// 3º.Se conozca el valor a cumplir por otros dos campos para los registros a actualizar; siendo uno de los campos de tipo booleano y el otro string.
        /// </summary>
        /// <param name="pConexion"></param>
        /// <param name="pTabla">Nombre de la tabla</param>
        /// <param name="pCampoActualizar1">Nombre del campo (tipo string) a actualizar</param>
        /// <param name="pValorActualizar1">Nuevo valor para el campo (tipo string) a actualizar</param> 
        /// <param name="pCampoActualizar2">Nombre del campo booleano a actualizar</param>
        /// <param name="pValorActualizar2">Nuevo valor para el campo boolena a actualizar</param> 
        /// <param name="pCampo1">Nombre del campo (tipo string), cuyo valor conocemos para los registros a actualizar</param>
        /// <param name="pValorCampo1">Valor que debe tener el campo (tipo string), cuyo valor conocemos para los registros a actualizar</param>
        /// <param name="pCampo2">Nombre del campo booleano, cuyo valor conocemos para los registros a actualizar</param>
        /// <param name="pValorCampo2">Valor que debe tener el campo booleano, cuyo valor conocemos para los registros a actualizar</param>
        /// <returns></returns>
        public static int ActualizarRegistrosBD(MySqlConnection pConexion, string pTabla, string pCampoActualizar1,
            string pValorActualizar1, string pCampoActualizar2,bool pValorActualizar2, string pCampo1,
            string pValorCampo1, string pCampo2, bool pValorCampo2)
        {
            int retorno;
            string consulta = string.Format("UPDATE {0} SET {1} = '{2}', {3} = {4} WHERE {5} LIKE '{6}' AND {7} LIKE {8}", 
                pTabla, pCampoActualizar1, pValorActualizar1, pCampoActualizar2, pValorActualizar2, pCampo1,
                pValorCampo1, pCampo2, pValorCampo2);
            //MessageBox.Show(consulta); //Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Actualiza los registros de una tabla en una base de datos, para aquellas consultas en las que:
        /// 1º.Se conozca el nombre de la tabla.
        /// 2º.Se quiera actualizar el valor booleano de un campo conocido.
        /// 3º.Se conozca el valor a cumplir por un campo conocido de tipo int.
        /// </summary>
        /// <param name="pConexion"></param>
        /// <param name="pTabla">Nombre de la tabla</param>
        /// <param name="pCampoActualizar1">Nombre del campo booleano a actualizar</param>
        /// <param name="pValorActualizar1">Nuevo valor para el campo booleano a actualizar</param>  
        /// <param name="pCampo1">Nombre del campo (tipo int), cuyo valor conocemos para los registros a actualizar</param>
        /// <param name="pValorCampo1">Valor que debe tener el campo (tipo int), cuyo valor conocemos para los registros a actualizar</param>
        /// <returns></returns>
        public static int ActualizarRegistrosBD(MySqlConnection pConexion, string pTabla, string pCampoActualizar1,
            bool pValorActualizar1, string pCampo1, int pValorCampo1)
        {
            int retorno;
            string consulta = string.Format("UPDATE {0} SET {1} = {2} WHERE {3} LIKE {4}",
                pTabla, pCampoActualizar1, pValorActualizar1, pCampo1, pValorCampo1);
            //MessageBox.Show(consulta); //Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<string> ListarRegistrosBD(MySqlConnection pConexion, string consulta)
        {
            List<string> lista = new List<string>();
            
            // MessageBox.Show(consulta);   //Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creamos el objeto command al cual le pasamos la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            // Ejecutamos el comando y recibimos en un objeto DataReader la lista de registros seleccionados.
            // Recordemos que un objeto DataReader es una especie de tabla de datos virtual.
            MySqlDataReader reader = comando.ExecuteReader();
            
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de registro.
                while (reader.Read())
                {                    
                    string fila = reader[0].ToString() +" "+ reader[1].ToString() +" "
                        + reader[2].ToString();
                    //MessageBox.Show(fila);
                    lista.Add(fila);
                }                
            }            
            reader.Close();
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }

        //public static string AnyadirEspaciosDetras(string pCadena, int pNumeroMaximoCaracteres)
        //{
            
        //    for (var i = 0; i < pNumeroMaximoCaracteres - pCadena.ToString().Length; i++)
        //    {
        //        pCadena += " ";
        //    }

        //    return pCadena;
        //}


        #endregion


        /*-----métodos de implementación----*/
        #region(métodos de implementación)
        private static string ObtenerLetraNif(string pNumeroNif)
        {
            string[] letrasDni = new string[23] { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D",
                "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"};
            int numLetra = Convert.ToInt32(pNumeroNif) % 23;
            return letrasDni[numLetra];
        }
        #endregion
    }
}
