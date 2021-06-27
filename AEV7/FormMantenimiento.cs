using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class frmMantenimiento : Form
    {
        /*------------atributos-------------*/
        #region(atributos)
        private Empleado emp;
        #endregion

        /*-----------propiedades------------*/
        #region(propiedades)
        #endregion

        /*----------constructores-----------*/
        #region(constructores)
        public frmMantenimiento()
        {
            InitializeComponent();
        }
        #endregion

        /*--------getters y setters---------*/
        #region(getters y setters)
        #endregion

        /*----otros métodos de interface----*/
        #region(otros métodos de interface)
        #endregion


        /*-----manejadores de eventos (métodos de implementación)----*/
        #region(métodos de implementación - manejadores de eventos)

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            CargarRegistrosBDenDataGridView("empleados");
            CargarRegistrosBDenDataGridView("fichajes");

            //MostrarFichajesAbiertosQueExcedenHoras();

            int limiteHorasFichajeAbierto = 10;

            if (ListarFichajesAbiertosExcedenHoras(limiteHorasFichajeAbierto) != null)
            {
                string mensaje;
                mensaje = MostrarFichajesAbiertosExcedenHoras(ListarFichajesAbiertosExcedenHoras(limiteHorasFichajeAbierto),
                    limiteHorasFichajeAbierto);
                DialogResult retorno = MessageBox.Show(mensaje, "¡¡Atención!! Fichajes Abiertos por Tiempo Excesivo", 
                    MessageBoxButtons.YesNo);
                if (retorno== DialogResult.Yes)
                {
                    CerrarFichajesAbiertosExcedenHoras(ListarFichajesAbiertosExcedenHoras(limiteHorasFichajeAbierto));
                    CargarRegistrosBDenDataGridView("fichajes");
                }                
            } 
        }

  
        private void btnSalirApp_Click(object sender, EventArgs e)
        {
            //Asignamos "Yes" a la propiedad "DialogResult" del botón "btnSalirApp".
            //DialogResult es el resultado producido por el cuadro de diálogo al hacer
            //click en el botón de un formulario modal.
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(chbAdministrador.Checked.ToString());
            if (ValidarDatosAlta())
            {
                int resultado;
                try
                {
                    if (ConexionBDpST.Conexion != null)
                    {
                        ConexionBDpST.AbrirConexion();
                        emp = new Empleado();
                        emp.Nif = mtxbNif.Text;
                        emp.Nombre = txbNombre.Text;
                        emp.Apellidos = txbApellidos.Text;
                        emp.Administrador = chbAdministrador.Checked;
                        emp.Contrasenya = txbContrasenya.Text;

                        //MessageBox.Show(emp.Administrador.ToString());

                        resultado = emp.AgregarEmpleado(emp);

                        if (resultado > 0)   // Si se ha agregado o modificado limpiamos las cajas de texto
                        {
                            mtxbNif.Clear();
                            txbNombre.Clear();
                            txbApellidos.Clear();
                            chbAdministrador.Checked = false;
                            txbContrasenya.Clear();
                        }

                        // Cierro la conexión
                        ConexionBDpST.CerrarConexion();

                        // volvemos a cargar toda la lista de usuarios;
                        CargarRegistrosBDenDataGridView("empleados");
                        //CargarListaEmpleados();
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
            }
            mtxbNif.Focus();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(chbAdministrador.Checked.ToString());
            if (ValidarDatosBaja())
            {
                int resultado;
                try
                {
                    if (ConexionBDpST.Conexion != null)
                    {
                        ConexionBDpST.AbrirConexion();

                        resultado = Utilidades.EliminarRegistrosBD(ConexionBDpST.Conexion, "empleados", "nif", mtxbNif.Text);

                        if (resultado > 0)   // Si se ha agregado o modificado limpiamos las cajas de texto
                        {
                            mtxbNif.Clear();
                            txbNombre.Clear();
                            txbApellidos.Clear();
                            chbAdministrador.Checked = false;
                            txbContrasenya.Clear();
                        }

                        // Cierro la conexión
                        ConexionBDpST.CerrarConexion();

                        // volvemos a cargar toda la lista de usuarios;
                        CargarRegistrosBDenDataGridView("empleados");
                        //CargarListaEmpleados();
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
            }
            mtxbNif.Focus();
        }
        #endregion


        /*-----métodos de implementación auxililares----*/
        #region(metodos de implementación auxiliares)
        // Método para rellenar el datagrid con la lista y datos de todos los usuarios existentes en la BD.
        private void CargarRegistrosBDenDataGridView(string pTablaBD)
        {
            string consulta = String.Format("SELECT * FROM {0}", pTablaBD);
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    if (pTablaBD == "empleados")
                    {
                        dgvInfoEmpleados.DataSource = Empleado.BuscarEmpleado(ConexionBDpST.Conexion, consulta);
                    }
                    else
                    {
                        dgvInfoFichajes.DataSource = Fichaje.BuscarFichaje(ConexionBDpST.Conexion, consulta);
                    }                  

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
        }


        private bool ValidarDatosAlta()
        {
            bool valido = true;
            if (!Utilidades.ValidarNif(mtxbNif.Text))
            {
                errorProvider1.SetError(mtxbNif, "Ingrese un NIF válido.");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(mtxbNif, "");

                if (Utilidades.ExisteRegistrosBD("empleados", "nif", mtxbNif.Text))
                {
                    errorProvider1.SetError(mtxbNif, "Ya existe un empleado con este NIF.");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(mtxbNif, "");
                }
            }

            if (txbNombre.Text == "")
            {
                errorProvider1.SetError(txbNombre, "Ingrese el nombre.");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(txbNombre, "");
            }

            if (txbApellidos.Text == "")
            {
                errorProvider1.SetError(txbApellidos, "Ingrese los apellidos.");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(txbApellidos, "");
            }

            if (chbAdministrador.Checked)
            {
                if (txbContrasenya.Text == "")
                {
                    errorProvider1.SetError(txbContrasenya, "Ingrese la contraseña.");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(txbContrasenya, "");
                }
            }
            else
            {
                if (txbContrasenya.Text != "")
                {
                    errorProvider1.SetError(txbContrasenya, "La contraseña " +
                        "unicamente está permitida en el perfil administrador.\n " +
                        "Si el empleado es administrador, chequee el campo 'Administrador'.\n" +
                        "En caso contrario, elimine la contraseña.");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(txbContrasenya, "");
                }
            }

            return valido;
        }


        private bool ValidarDatosBaja()
        {
            bool valido = true;
            if (!Utilidades.ValidarNif(mtxbNif.Text))
            {
                errorProvider1.SetError(mtxbNif, "Ingrese un NIF válido.");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(mtxbNif, "");

                if (!Utilidades.ExisteRegistrosBD("empleados", "nif", mtxbNif.Text))
                {
                    errorProvider1.SetError(mtxbNif, "No existe ningún empleado con este NIF.");
                    valido = false;
                }
                else
                {
                    errorProvider1.SetError(mtxbNif, "");
                }
            }

            return valido;
        }

       
        private List<string[]> ListarFichajesAbiertosExcedenHoras(int pLimiteHorasFichajeAbierto)
        {
            List<string[]> lista = new List<string[]>();
            string consulta = "SELECT id, nif, fechaHora_Entrada FROM fichajes WHERE " +
                "estado_Entrada LIKE TRUE AND estado_Salida LIKE FALSE";
            int limiteHoras = pLimiteHorasFichajeAbierto;

            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    foreach (string fila in Utilidades.ListarRegistrosBD(ConexionBDpST.Conexion, consulta))
                    {                                                
                        string[] subs = fila.Split();

                        //MessageBox.Show(subs[2].ToString()+"\n"+subs[3].ToString());

                        DateTime fechaHora_Inicio = Convert.ToDateTime(subs[2].ToString() + " " + subs[3].ToString());
                        DateTime fechaHora_Fin = DateTime.Now;
                        TimeSpan diferenciaTiempo = fechaHora_Fin - fechaHora_Inicio;
                        //MessageBox.Show(diferenciaTiempo.TotalHours.ToString());

                        if (diferenciaTiempo.TotalHours > limiteHoras)
                        {
                            lista.Add(subs);
                        }
                    }
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

            if (lista.Count == 0)
            {
                lista = null;
            }

            return lista;
        }

        private string MostrarFichajesAbiertosExcedenHoras(List<string[]> pListadoFichajesExcedenHoras,
            int pLimiteHorasFichajeAbierto)
        {
            int contador = 1;
            string contenido = String.Format("Listado de empleados que mantienen abierto su fichaje" +
                " tras {0} horas:\n\n", pLimiteHorasFichajeAbierto);
            contenido += "  Nº          NIF          Fecha_Entrada   Hora_Entrada   Horas_Transcurridas";

            foreach (string[] subs in pListadoFichajesExcedenHoras)
            {   
                DateTime fechaHora_Inicio = Convert.ToDateTime(subs[2].ToString() + " " + subs[3].ToString());
                DateTime fechaHora_Fin = DateTime.Now;
                TimeSpan diferenciaTiempo = fechaHora_Fin - fechaHora_Inicio;
                //MessageBox.Show(diferenciaTiempo.TotalHours.ToString());

                contenido += "\n";

                for (var i = 0; i < 4 - contador.ToString().Length; i++)
                {
                    contenido += " ";
                }
                contenido += contador.ToString() + "     ";

                for (var i = 1; i < 4; i++)
                {
                    contenido += subs[i];
                    for (var j = 0; j < 18 - subs[i].Length; j++)
                    {
                        contenido += " ";
                    }
                }
                contenido += String.Format("    {0:0.00}", diferenciaTiempo.TotalHours);
                contador++;
            }
            contenido += "\n\n¿Cerrar los fichajes con la fecha y hora de salida por defecto" +
                " (fecha de salida: 0001-01-01, hora de salida: 00:00:00)?";
            return contenido;
        }

        private void CerrarFichajesAbiertosExcedenHoras(List<string[]> pListadoFichajesExcedenHoras)
        {
           
            try
            {                
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    int retorno = 1;
                    foreach (string[] subs in pListadoFichajesExcedenHoras)
                    {
                        retorno *= Utilidades.ActualizarRegistrosBD(ConexionBDpST.Conexion, "fichajes", "estado_Salida", true,
                            "id", Convert.ToInt16(subs[0]));
                        //MessageBox.Show(retorno.ToString());
                    }

                    if (retorno == 0)
                    {
                        MessageBox.Show("No se han cerrado todos los fichajes.", "¡¡ATENCIÓN!!");
                    }

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
        }

        #endregion
    }
}
