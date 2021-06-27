using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AP17.Clases
{
    class Usuario
    {
        // es necesario mapear los campos de la tabla USUARIOS creada en la Base de Datos (BDUsuarios)
        // Definición de los atributos del usuario de forma privada.
        private int idUsuario;
        private string nombre;
        private string apellidos;
        private string email;
        private int edad;
        private DateTime fechaNac;
        private Decimal cuota;
        private Image foto;

        // Definición de las propiedades de acceso a atributos (lectura y escritura)
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }  
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public DateTime FechaNac { get {return fechaNac; } set { fechaNac = value; } }
        public Decimal Cuota { get { return cuota; } set { cuota = value; } }
        public Image Foto { get { return foto; } set { foto = value; } }


        // Primer Constructor que recibe todos los datos del usuario por parámetro.
        public Usuario(int id, string nom, string ape, string mail, int ed, DateTime fe, Decimal cu, Image fot)
        {
            idUsuario = id;
            nombre = nom;
            apellidos = ape;
            email = mail;
            edad = ed;
            fechaNac = fe;
            cuota = cu;
            foto = fot;
        }

        // Segundo Constructor básico definido para instanciar objetos usuario sin parámetros
        public Usuario()
        {
        }

        // Método para guardar/insertar un usuario en la Base de Datos.
        // Recibe un objeto conexion y los datos del usuario a insertar/guardar
        // Devuelve el resultado de la transacción realizada (número de registros afectados)
        public int AgregarUsuario(MySqlConnection conexion, Usuario usu)
        {
            int retorno;

            // Preparación de la imagen
            MemoryStream ms = new MemoryStream();
            usu.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();
            

            // Imp: se puede cambiar la configuración regional del ordenador para que el signo
            // decimal sea el . y el signo de millares la , (MySQL está en formato USA)
            // o se añade en program.cs la siguiente linea:
            string consulta = String.Format("INSERT INTO usuarios (id,nombre,apellidos,email,edad,fechanac,cuota,imagen) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}',@imagen)", usu.idUsuario, usu.nombre, usu.apellidos, usu.email,
                usu.edad, usu.fechaNac.ToString("yyyy/MM/dd"), usu.cuota.ToString("0.00",CultureInfo.InvariantCulture));

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();

            return retorno;

            /*
            Ejemplo de código para agregar utilizando parámetros en la consulta 
            string consulta = String.Format("INSERT INTO usuarios (id,nombre,apellidos,email,edad,fechanac,cuota,imagen) VALUES " +
                "(@id,@nom,@ape,@email,@edad,@fecha,@cuota,@imagen)");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("id", usu.idUsuario);
            comando.Parameters.AddWithValue("nom", usu.nombre);
            comando.Parameters.AddWithValue("ape", usu.apellidos);
            comando.Parameters.AddWithValue("email", usu.email);
            comando.Parameters.AddWithValue("edad", usu.edad);
            comando.Parameters.AddWithValue("fecha", usu.fechaNac);
            comando.Parameters.AddWithValue("cuota", usu.cuota);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();
            return retorno;
            */
        }






        // Método para actualizar los datos de un usuario en la Base de Datos.
        // Recibe un objeto conexion y los datos del usuario a modificar
        // Devuelve el resultado de la transacción (número de registros afectados)
        public int ActualizaUsuario(MySqlConnection conexion, Usuario usu) 
        {

            // Imp: se puede cambiar la configuración regional del ordenador para que el signo
            // decimal sea el . y el signo de millares la , (MySQL está en formato USA)
            // o se añade en program.cs la siguiente linea:
            // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int retorno;

            // Preparación de la imagen
            MemoryStream ms = new MemoryStream();
            usu.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] imgArr = ms.ToArray();

            string consulta = string.Format("UPDATE usuarios SET nombre='{0}',apellidos='{1}',email='{2}',edad={3}," +
                "fechanac='{4}',cuota={5},imagen=@imagen WHERE id={6}", usu.nombre, usu.apellidos, usu.email, usu.edad, usu.fechaNac.ToString("yyyy/MM/dd"),
                usu.cuota.ToString("0.00",CultureInfo.InvariantCulture), usu.idUsuario);

            MessageBox.Show(consulta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", imgArr);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        // Método para eliminar un usuario en la Base de Datos.
        // Recibe un objeto conexion y la identificación (id) del usuario a eliminar. 
        // Devuelve el resultado de la transacción (registros afectados)
        public static int EliminaUsuario(MySqlConnection conexion, int identidad) 
        {
            int retorno;
            string consulta = string.Format("DELETE FROM usuarios WHERE id={0}", identidad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        // Primer método para buscar usuarios en la Base de Datos.
        // Recibe la conexión y la consulta de búsqueda.
        // Devuelve una lista de usuarios que coinciden con la búsqueda realizada. 
        public static List<Usuario> BuscarUsuario(MySqlConnection conexion, string consulta)
        {
            List<Usuario> lista = new List<Usuario>();
            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creamos el objeto command al cual le pasamos la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecutamos el comando y recibimos en un objeto DataReader la lista de registros seleccionados.
            // Recordemos que un objeto DataReader es una especie de tabla de datos virtual.
            MySqlDataReader reader = comando.ExecuteReader();
            
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    // MessageBox.Show(reader.GetFieldType(7).ToString());
                    byte[] img = (byte[]) reader["imagen"];
                    MemoryStream ms = new MemoryStream(img) ;
                    Image foto = Image.FromStream(ms);
                             
                    Usuario user = new Usuario(reader.GetInt16(0),reader.GetString(1), reader.GetString(2),
                        reader.GetString(3),reader.GetInt16(4), Convert.ToDateTime(reader.GetDateTime(5)), reader.GetDecimal(6),
                        foto);
                    lista.Add(user);
                }
            }
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }


        // Segundo método para buscar un usuario (este método estará por tanto sobrecargado).
        // Recibe la conexión y el nombre, apellido o email a buscar.
        // Devuelve una lista de usuarios que coinciden con la búsqueda realizada.
        public static List<Usuario> BuscarUsuario(MySqlConnection conexion, string nom, string ape, string mail)
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = String.Format("SELECT * FROM usuarios WHERE nombre LIKE ('{0}') OR " +
                            "apellidos LIKE ('{1}') OR email LIKE ('{2}')", nom, ape, mail);

            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creo el objeto command al cual le paso la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Usuario user = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetInt16(4), reader.GetDateTime(5), reader.GetDecimal(6),null);
                    lista.Add(user);
                }
            }

            // devolvemos la lista cargada con los usuarios.
            return lista;
        }

        // Método que obtiene los datos de un usuario de la Base de Datos.
        // Recibe un objeto conexion y la identificación (id) del usuario del cual se desean obtener los datos. 
        // Devuelve el objeto usuario con los datos.
        public static Usuario ObtenerUsuario(MySqlConnection conexion, int identificacion) 
        {
            Usuario usu = new Usuario(); 
            string consulta = string.Format("SELECT * FROM usuarios WHERE id={0}", identificacion);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while(reader.Read())
            {
                usu.idUsuario = reader.GetInt16(0);
                usu.nombre = reader.GetString(1);
                usu.apellidos = reader.GetString(2);
                usu.email = reader.GetString(3);
                usu.Edad = reader.GetInt16(4);
                usu.FechaNac = reader.GetDateTime(5);
                usu.Cuota = reader.GetDecimal(6);

                byte[] img = (byte[])reader["imagen"];
                MemoryStream ms = new MemoryStream(img);
                usu.Foto = Image.FromStream(ms);
                
            }
            return usu;
        }

        /// <summary>
        /// Comprueba si un usuario está dado de alta o no previamente a su agregación
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nom">nombre del usuario</param>
        /// <param name="ape">apellido del usuario</param>
        /// <returns>true si está y false si no está</returns>

        public bool YaEsta(MySqlConnection conexion, string nom, string ape)
        {
            string consulta = string.Format("SELECT * FROM usuarios" +
            " WHERE nombre='{0}' AND apellidos='{1}'", nom, ape);

            MessageBox.Show(consulta);   // Se puede activar esta línea para testear la sintaxis de la consulta.

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            { // si existen registros en la devolución de la consulta
                reader.Close();   // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return true;
            }
            else
            {
                reader.Close();  // Cierro el reader para utilizar la misma conexión en AgregarUsuario
                return false;
            }
            
        }
        
        /// <summary>
        /// Realiza la búsqueda de usuarios mayores o menores de una edad determinada
        /// </summary>
        /// <param name="conexion">Conexión a la Base de Datos</param>
        /// <param name="opcion">1 -Mayores de Edad. 2-Menores de Edad</param>
        /// <param name="edad">Edad límite</param>
        /// <returns>Lista de usuarios</returns>
        public static List<Usuario> BusquedaDeEdad(MySqlConnection conexion, int opcion, int edad, ref int cant)  
        {
           string consulta;
           List<Usuario> lista = new List<Usuario>();
           if (opcion == 1) // mayores de edad
           { 
                consulta = String.Format("SELECT * FROM usuarios WHERE edad>={0}", edad);
           }
           else   // menores de edad
           {
                consulta = String.Format("SELECT * FROM usuarios WHERE edad<{0}", edad);
            }

            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creo el objeto command al cual le paso la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            // Ejecuto el comando y recibo en un DataReader la lista de registros seleccionados.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    Usuario user = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetInt16(4), reader.GetDateTime(5), reader.GetDecimal(6),null);
                    cant++;
                    lista.Add(user);
                }
            }
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }

        // Método que calcula el promedio de edad de todos los usuarios.
        // Recibe un objeto conexion
        // Devuelve el promedio de edad
        public static double PromedioEdad(MySqlConnection conexion)
        {
            double acumulador = 0;
            int numusu = 0;
            string consulta = "SELECT edad FROM usuarios";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    numusu++;   // incremento el número de usuarios.
                    acumulador += reader.GetDouble(0);
                }
                return acumulador / numusu;
            } else
            {
                return 0;
            }

        }

        // Método para obtener los usuarios que han nacido en una fecha determinada
        // Recibe un objeto conexion y la fecha de filtrado
        // Devuelve la lista de usuarios nacidos en dicha fecha
        public static List<Usuario> NacidosEnFecha(MySqlConnection conexion, DateTime fecha)
        {
            List<Usuario> lista = new List<Usuario>();
            string consulta = String.Format("SELECT * FROM usuarios WHERE fechanac='{0}'", fecha.ToString("yyyy/MM/dd"));
            
            MessageBox.Show(consulta);   // Se puede activar esta línea para testear la sintaxis de la consulta.

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                while (reader.Read())
                {
                    Usuario user = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetInt16(4), reader.GetDateTime(5), reader.GetDecimal(6),null);
                    lista.Add(user);
                }
            }
            return lista;
        }

        // Método para calcular el usuario con cuota máxima o usuario con cuota mínima.
        // Recibe un objeto conexion y el tipo de cuota a considerar (maxima o mínima)
        // Devuelve el usuario correspondiente.
        public static Usuario PorCuotas(MySqlConnection conexion, string tipoCuota)
        {
            Usuario usuMin = null, usuMax = null;
            decimal cuotaMinima, cuotaMaxima; 
            string consulta = String.Format("SELECT * FROM usuarios");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Leemos el primer usuario y lo consideramos el primer con cuota mínima y máxima.
                reader.Read();
                cuotaMinima = reader.GetDecimal(6);
                cuotaMaxima = reader.GetDecimal(6);
                // Recorremos la lista de usuarios
                while (reader.Read())
                {
                    Usuario user = new Usuario(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(3), reader.GetInt16(4), reader.GetDateTime(5), reader.GetDecimal(6), null);
                    
                    if (reader.GetDecimal(6)>cuotaMaxima)
                    {
                        cuotaMaxima = reader.GetDecimal(6);
                        usuMax = user;
                    }

                    if (reader.GetDecimal(6)<cuotaMinima)
                    {
                        cuotaMinima= reader.GetDecimal(6);
                        usuMin = user;
                    }
                }
            }

            // Retornamos el usuario con cuota mínima o máxima (según el demandado por el parámetro tipoCuota)
            if(tipoCuota=="min")
            {
                return usuMin;
            } else
            {
                return usuMax;
            }

        }
    }
}
