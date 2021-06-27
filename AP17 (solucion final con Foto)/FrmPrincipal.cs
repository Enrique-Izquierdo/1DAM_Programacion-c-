using AP17.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AP17
{
    public partial class frmUsuarios : Form
    {
        // Declaro un atributo a nivel de objeto para la conexion a la BD
        //  de esta forma puedo utilizarlo en todos los métodos del formulario
        ConexionBD bdatos = new ConexionBD();

        // Constructor
        public frmUsuarios()
        {
            InitializeComponent();
        }

        // Imagen con el botón salir para finalizar la aplicación
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // Al iniciarse la aplicación, carga toda la información disponible de usuarios (BD)
            // en el datagridview (dado que esta operación se realizará varias veces, se programa
            // en un método específico
            CargaListaUsuarios();
            btnSelFecha.Visible = false;
            dtpSelFecha.Visible = false;
            
        }

        // Método para rellenar el datagrid con la lista y datos de todos los usuarios existentes en la BD.
        private void CargaListaUsuarios()
        {
            string seleccion = "Select * from usuarios";
            if (bdatos.AbrirConexion()) {
                dgvUsuarios.DataSource = Usuario.BuscarUsuario(bdatos.Conexion,seleccion);
                bdatos.CerrarConexion();
            } else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Inserción de un usuario nuevo y/o Modificación de un usuario editado previamente
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if(bdatos.AbrirConexion())
                {
                    Usuario usu = new Usuario();
                    usu.Nombre = txtNombre.Text;
                    usu.Apellidos = txtApellidos.Text;
                    usu.Email = txtEmail.Text;
                    usu.Edad = Convert.ToInt32(txtEdad.Text);  //Si la edad no es convertible puede generar una excepción
                    usu.FechaNac = dtpFechaNac.Value;
                    usu.Cuota = Convert.ToDecimal(txtCuota.Text);
                    usu.Foto = pctfoto.Image;

                    if (String.IsNullOrEmpty(txtIdentidad.Text))  // Estoy agregando un usuario nuevo
                    {
                        if (usu.YaEsta(bdatos.Conexion,usu.Nombre,usu.Apellidos))  // Comprobamos si existe el usuario
                        {
                            MessageBox.Show("Este usuario no se puede dar de alta. Ya existe");
                        } else
                        {
                            resultado = usu.AgregarUsuario(bdatos.Conexion, usu);
                        }
                    } else // Estoy modificando un usuario editado
                    {
                        usu.IdUsuario = Convert.ToInt16(txtIdentidad.Text);
                        resultado = usu.ActualizaUsuario(bdatos.Conexion, usu);
                    }

                    if (resultado>0) // Si se ha agregado o modificado limpiamos las cajas de texto
                    {
                        LimpiarControles();
                    }

                    // Cierro la conexión
                    bdatos.CerrarConexion();
                    // volvemos a cargar toda la lista de usuarios;
                    CargaListaUsuarios();

                } else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);   
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                bdatos.CerrarConexion();
            }
        }

        // Busqueda de usuarios
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                dgvUsuarios.DataSource = Usuario.BuscarUsuario(bdatos.Conexion, 
                                        txtNombre.Text, txtApellidos.Text, txtEmail.Text);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Visualización de todos los datos de usuarios en el datagridview
        // Reseteo de las cajas de texto de información de un usuario
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // volvemos a cargar toda la lista de usuarios;
            CargaListaUsuarios();
            LimpiarControles();
        }

        // Edición de los datos de un usuario
        //Cuando el usuario selecciona un registro del datagrid debe llevar sus valores a las cajas de texto
        //para editarlo. Posteriormente puede cambiar sus datos y modificarlo haciendo clic nuevamente en 
        //el botón insertar
        // En el datagridview la propiedad MultiSelect=false y SelectionMode=FullRowSelect  
        private void btnEditar_Click(object sender, EventArgs e)
        {
                       
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 1) // Si hay una fila seleccionada en el datagridview
                { 
                    int idUsuario = (int) dgvUsuarios.CurrentRow.Cells[0].Value;  // Obtenemos el id de la fila seleccionada
                    // Extraigo de la BD la información (no del datagrid!) 
                    // por si estuviese actualizada en la BD por otro usuario y no estuviese refrescada en mi datagridview
                    if (bdatos.AbrirConexion())
                    {
                        Usuario usu = Usuario.ObtenerUsuario(bdatos.Conexion, idUsuario);
                        CargaCajasTexto(usu);
                    } else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                    // Cerramos la conexion
                    bdatos.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bdatos.CerrarConexion();
            }
        }

        // Elimina un usuario de la Base de Datos (con confirmación)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Para eliminar, el usuario selecciona un registro del datagrid. 
            // Posteriormente haremos clic en eliminar (nos pedirá confirmación)
            try
            {
                int resultado;

                if (dgvUsuarios.SelectedRows.Count == 1) // Si hay una fila seleccionada en el datagridview
                { 
                    int idUsuario = (int) dgvUsuarios.CurrentRow.Cells[0].Value; // Obtenemos el id de la fila seleccionada

                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?", 
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (bdatos.AbrirConexion())
                        {
                            resultado = Usuario.EliminaUsuario(bdatos.Conexion, idUsuario);
                        } else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        // Cierro la conexión
                        bdatos.CerrarConexion();
                        // volvemos a cargar toda la lista de usuarios;
                        CargaListaUsuarios();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reseteo de las cajas de texto de información de un usuario
        private void LimpiarControles()
        {
            txtIdentidad.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtEdad.Clear();
            dtpFechaNac.Value = DateTime.Now;
            txtCuota.Clear();
            pctfoto.Image = null;
        }

        // Visualización de información de usuarios mayores de edad (18 años) y cantidad de usuarios 
        private void mnuMayores18_Click(object sender, EventArgs e)
        {
            int cantidad = 0;

            if (bdatos.AbrirConexion())
            {
                dgvUsuarios.DataSource = Usuario.BusquedaDeEdad(bdatos.Conexion, 1, 18, ref cantidad);  // mayores de edad
                MessageBox.Show("Usuarios mayores de 18 años: " + cantidad);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
        
        // Visualización de información de usuarios menores de edad (18 años) y cantidad de usuarios
        private void mnuMenores18_Click(object sender, EventArgs e)
        {
            int cantidad = 0;

            if (bdatos.AbrirConexion())
            {
                dgvUsuarios.DataSource = Usuario.BusquedaDeEdad(bdatos.Conexion, 2, 18, ref cantidad);  // menores de edad
                MessageBox.Show("Usuarios menores de 18 años: " + cantidad);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Visualización del promedio de edad correspondiente a los usuarios
        private void mnuPromedioEdad_Click(object sender, EventArgs e)
        {
            double promedio = 0;

            if (bdatos.AbrirConexion())
            {
                promedio = Usuario.PromedioEdad(bdatos.Conexion);  // menores de edad
                MessageBox.Show("Edad promedio de usuarios: " + promedio.ToString("N"));
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
        
        // Visualización de información de usuarios nacidos en una fecha dada (activación de controles)
        private void mnuFechaNacimiento_Click(object sender, EventArgs e)
        {
            // Mostramos los controles para la selección de la fecha (de momento estaban no visibles)
            btnSelFecha.Visible = true;
            dtpSelFecha.Visible = true;
            dtpSelFecha.Focus();
        }

        // Visualización de información de usuarios nacidos en una fecha dada (proceso)
        private void btnSelFecha_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                dgvUsuarios.DataSource = Usuario.NacidosEnFecha(bdatos.Conexion, dtpSelFecha.Value.Date);
                MessageBox.Show("Usuarios nacidos el " + dtpSelFecha.Value.Date);
                btnSelFecha.Visible = false;
                dtpSelFecha.Visible = false;
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }


        // Visualización de información de usuario con cuota mínima. 
        private void mnuUsuCuotaMin_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                Usuario usu = Usuario.PorCuotas(bdatos.Conexion, "min");
                CargaCajasTexto(usu);
                // Cerramos la conexion
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Visualización de información de usuario con cuota máxima. 
        private void mnuUsuCuotaMax_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                Usuario usu = Usuario.PorCuotas(bdatos.Conexion, "max");
                CargaCajasTexto(usu);
                // Cerramos la conexion
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        // Relleno de las cajas de texto con la información de un usuario
        private void CargaCajasTexto (Usuario usu)
        {
                txtIdentidad.Text = usu.IdUsuario.ToString();
                txtNombre.Text = usu.Nombre;
                txtApellidos.Text = usu.Apellidos;
                txtEmail.Text = usu.Email;
                txtEdad.Text = usu.Edad.ToString();
                dtpFechaNac.Value = usu.FechaNac;
                txtCuota.Text = usu.Cuota.ToString();
                pctfoto.Image = usu.Foto;
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargaImagen = new OpenFileDialog();
            cargaImagen.InitialDirectory = "C:\\";
            cargaImagen.Filter = "JPG (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
            if(cargaImagen.ShowDialog() == DialogResult.OK)
            {
                pctfoto.ImageLocation = cargaImagen.FileName;
                MessageBox.Show(cargaImagen.FileName);
            } else
            {
                MessageBox.Show("No se ha seleccionado imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
