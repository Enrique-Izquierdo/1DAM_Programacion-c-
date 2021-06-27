using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    class Empleado
    {
        /*------------atributos-------------*/
        #region(atributos)
        private string nif;
        private string nombre;
        private string apellidos;
        private bool administrador;
        private string contrasenya;
        #endregion


        /*-----------propiedades------------*/
        #region(propiedades)
        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } set { administrador = value; } }
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }
        #endregion


        /*----------constructores-----------*/
        #region(constructores)
        public Empleado() { }

        public Empleado(string pNif, string pNombre, string pApellidos, bool pAdministrador, string pContrasenya)
        {
            nif = pNif;
            this.nombre = pNombre;
            apellidos = pApellidos;
            administrador = pAdministrador;
            contrasenya = pContrasenya;
        }
        #endregion


        /*--------getters y setters---------*/
        #region(getters y setters)
        #endregion


        /*----otros métodos de interface----*/
        #region(otros métodos de interface)

        // Primer método para buscar usuarios en la Base de Datos.
        // Recibe la conexión y la consulta de búsqueda.
        // Devuelve una lista de usuarios que coinciden con la búsqueda realizada. 
        public static List<Empleado> BuscarEmpleado(MySqlConnection pConexion, string consulta)
        {
            List<Empleado> lista = new List<Empleado>();
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
                    Empleado emp = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetBoolean(3), reader.GetString(4));
                    lista.Add(emp);
                }
            }
            reader.Close();
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }

        

        public int AgregarEmpleado(Empleado pEmple)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO empleados (nif,nombre,apellidos,administrador,contrasenya)" +
                " VALUES ('{0}','{1}','{2}',{3},'{4}')", pEmple.nif, pEmple.nombre, pEmple.apellidos, 
                pEmple.administrador, pEmple.contrasenya);

            MySqlCommand comando = new MySqlCommand(consulta, ConexionBDpST.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }
        #endregion


        /*-----métodos de implementación----*/
        #region(métodos de implementación)
        #endregion
    }
}
