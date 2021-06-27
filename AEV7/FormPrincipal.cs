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
    public partial class frmPpal : Form
    {
        /*------------atributos-------------*/
        #region(atributos)
        private string contrasenya = null;
        private Fichaje fich;
        #endregion

        /*-----------propiedades------------*/
        #region(propiedades)
        #endregion

        /*----------constructores-----------*/
        #region(constructores)
        public frmPpal()
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

        private void frmPpal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("T");
            lblFecha.Text = DateTime.Now.ToString("D");
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (ConfirmarNif())
            {
                if (EsAdministrador())
                {                
                    //Para utilizar el método InputBox, es necesario agregar la referencia de Visual Basic en el proyecto.
                    contrasenya = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña:\n\nNOTA: " +
                        "El sistema no admite contraseñas vacias y, no distingue mayúsculas de minúsculas.",
                        "Validación de Acceso a Mantenimiento", "", 500, 300);

                    if (contrasenya != "")
                    {
                        if (ValidarContrasenya())
                        {
                            frmMantenimiento fManto = new frmMantenimiento();
                            DialogResult salir = fManto.ShowDialog();
                            if (salir == DialogResult.Yes)
                            {
                                this.Dispose();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "Acceso Denegado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO tiene permiso de administrador", "Acceso Denegado");
                }
                mtxbNif.Clear();
            }            
            mtxbNif.Focus();
        }

        //Registrar entrada en base de datos
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (ConfirmarNif())
            {
                if (DentroEmpresa())
                {
                    //MessageBox.Show("No puede registrarse su fichaje de entrada, ya que registro su entrada previamente");
                    lblPanelInformativo.Text = "\n\n\n                                                    ¡¡ATENCIÓN!!\n" +
                        "\n                           No ha podido registrarse su fichaje de entrada," +
                        "\n                               porque ya registró su entrada previamente.";
                }   
                else
                { 
                    int resultado;
                    try
                    {
                        if (ConexionBDpST.Conexion != null)
                        {
                            ConexionBDpST.AbrirConexion();
                            fich = new Fichaje();
                            fich.Nif = mtxbNif.Text;
                            fich.Entrada_FechaHora = DateTime.Now;
                            fich.Entrada_Estado = true;
                            fich.Salida_FechaHora = DateTime.MinValue;
                            fich.Salida_Estado = false;
                            //MessageBox.Show(emp.Administrador.ToString());
                            resultado = fich.RegistrarEntrada(fich);

                            if (resultado > 0)   // Si se ha agregado o modificado limpiamos las cajas de texto
                            {
                                lblPanelInformativo.Text = "\n\n\n\n                                " +
                                    " Fichaje de entrada correctamente registrado.";

                            }
                            // Cierro la conexión
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
                mtxbNif.Clear();
            }            
            mtxbNif.Focus();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (ConfirmarNif())
            {
                if (DentroEmpresa())
                {                    
                    int resultado;
                    try
                    {
                        if (ConexionBDpST.Conexion != null)
                        {
                            ConexionBDpST.AbrirConexion();

                            //En la tabla fichajes de la BD, actualizamos a TRUE el campo "estado_Salida" del registro
                            //coincidente con el nif ingresado y en el que, además, el campo "esta_Salida" es FALSE. 
                            resultado = Utilidades.ActualizarRegistrosBD(ConexionBDpST.Conexion, "fichajes", 
                                "fechaHora_Salida", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "estado_Salida", true,
                                "nif", mtxbNif.Text, "estado_Salida", false);

                            if (resultado > 0)   // Si se ha agregado o modificado limpiamos las cajas de texto
                            {
                                lblPanelInformativo.Text = "\n\n\n\n                                " +
                                    " Fichaje de salida correctamente registrado.";
                            }
                            // Cierro la conexión
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
                else
                {
                    //MessageBox.Show("No puede registrarse su fichaje de salida, ya que registro su salida previamente.");
                    lblPanelInformativo.Text = "\n\n\n                                                    ¡¡ATENCIÓN!!\n" +
                        "\n                           No ha podido registrarse su fichaje de salida," +
                        "\n                               porque ya registró su salida previamente.";
                }
                mtxbNif.Clear();
            }            
            mtxbNif.Focus();
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            MostrarEmpleadosPresentes();
            mtxbNif.Focus();
        }


        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            if (ConfirmarNif())
            {
                if (ValidarFechasConsulta())
                {
                    MostrarFichajesCerrados();
                    mtxbNif.Clear();
                    dtpFechaInicial.Value = DateTime.Now;
                    dtpFechaFinal.Value = DateTime.Now;
                }                
            }            
            mtxbNif.Focus();
        }


        private void btnBorrarPanel_Click(object sender, EventArgs e)
        {
            lblPanelInformativo.Text = "";
        }



        #endregion


        /*-----métodos de implementación auxililares----*/
        #region(metodos de implementación auxiliares)


        private bool ConfirmarNif()
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
            mtxbNif.Focus();
            return valido;
        }


        private bool ValidarContrasenya()
        {
            bool valido = false;
            if (Utilidades.ExisteRegistrosBD("empleados", "nif", mtxbNif.Text, "contrasenya", contrasenya))
            {
                valido = true;
            }

            return valido;
        }

        private bool ValidarFechasConsulta()
        {
            bool valido = true;
            if(dtpFechaFinal.Value.Date < dtpFechaInicial.Value.Date)
            {
                errorProvider1.SetError(dtpFechaInicial, "La fecha inicial debe ser anterior a la fecha final.");
                valido = false;
            }
            else
            {
                errorProvider1.SetError(dtpFechaInicial, "");                
            }

            return valido;
        }

        private bool EsAdministrador()
        {
            bool valido = false;
            if (Utilidades.ExisteRegistrosBD("empleados", "nif", mtxbNif.Text, "contrasenya", "_%"))
            {
                valido = true;
            }

            return valido;
        }

        private bool DentroEmpresa()
        {
            bool dentroEmpresa = false;
            if (Utilidades.ExisteRegistrosBD("fichajes", "nif", mtxbNif.Text, "estado_Salida", false))
            {
                dentroEmpresa = true;
            }
            return dentroEmpresa;
        }

        private void MostrarEmpleadosPresentes()
        {
            string consulta = string.Format("SELECT e.nombre, e.apellidos, f.fechaHora_Entrada FROM " +
                "empleados e INNER JOIN fichajes f ON e.nif = f.nif WHERE f.estado_Salida IS FALSE");
            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    int contador = 1;
                    string contenido = "Los siguientes empleados están presentes en la empresa desde la fecha y " +
                        "hora indicadas:\n\n";
                    contenido += "  Nº         Nombre         Apellidos          Fecha_Entrada           Hora_Entrada";

                    foreach (string fila in Utilidades.ListarRegistrosBD(ConexionBDpST.Conexion, consulta))
                    {
                        string[] subs = fila.Split();
                        contenido += "\n";

                        for (var i=0; i<3-contador.ToString().Length; i++)
                        {
                            contenido += "  ";
                        }
                        contenido += contador.ToString()+"     ";

                        for (var i=0; i<subs.Length; i++)
                        {
                            contenido += subs[i];
                            for (var j = 0; j < 15 - subs[i].Length; j++)
                            {
                                contenido += "  ";
                            }
                        }                       
                        contador++;                                                   
                    }                                       
                    lblPanelInformativo.Text = contenido;
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

        private void MostrarFichajesCerrados()
        {
            string fechaInicial = dtpFechaInicial.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string fechaFinal = dtpFechaFinal.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            //MessageBox.Show(fechaInicial + "\n" + fechaFinal);
            
            string consulta = string.Format("SELECT nif,fechaHora_Entrada,fechaHora_Salida FROM fichajes WHERE " +
                "nif LIKE '{0}' AND estado_Entrada LIKE TRUE AND estado_Salida LIKE TRUE AND fechaHora_Entrada >=" +
                " '{1}' AND fechaHora_Salida <= '{2}' AND fechaHora_Salida NOT LIKE '{3}'", mtxbNif.Text, fechaInicial,
                fechaFinal, DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss"));
            //MessageBox.Show(consulta);

            try
            {
                if (ConexionBDpST.Conexion != null)
                {
                    ConexionBDpST.AbrirConexion();

                    TimeSpan acumulaTiempo = DateTime.Now - DateTime.Now;
                    //MessageBox.Show(acumulaTiempo.ToString());
                    int contador = 1;
                    string contenido = String.Format("Listado de fichajes completos del empleado con NIF {0} " +
                        "desde las 00:00:00 horas del {1} hasta las 23:59:59 horas del {2}:\n\n", mtxbNif.Text,
                        dtpFechaInicial.Value.ToShortDateString(), dtpFechaFinal.Value.ToShortDateString());
                    contenido += "  Nº    Fecha_Entrada    Hora_Entrada    Fecha_Salida    Hora_Salida         Duración";

                    foreach (string fila in Utilidades.ListarRegistrosBD(ConexionBDpST.Conexion, consulta))
                    {
                        string[] subs = fila.Split();

                        DateTime fechaHora_Inicio = Convert.ToDateTime(subs[1].ToString() + " " + subs[2].ToString());
                        DateTime fechaHora_Fin = Convert.ToDateTime(subs[3].ToString() + " " + subs[4].ToString());
                        TimeSpan diferenciaTiempo = fechaHora_Fin - fechaHora_Inicio;
                        //MessageBox.Show(diferenciaTiempo.ToString());
                        acumulaTiempo += diferenciaTiempo;
                        //MessageBox.Show(acumulaTiempo.ToString());
                        contenido += "\n";
                        
                        for (var i = 0; i < 5 - contador.ToString().Length; i++)
                        {
                            contenido += " ";
                        }
                        contenido += contador.ToString() + "       ";

                        for (var i = 0; i < subs.Length; i++)
                        {
                            if (i != 0)
                            {
                                contenido += subs[i];
                                for (var j = 0; j < 20 - subs[i].Length; j++)
                                {
                                    contenido += " ";
                                }                                                                
                            }      
                        }
                        contenido += diferenciaTiempo.ToString();
                        contador++;                                               
                    }
                    contenido += string.Format("\n\n Tiempo total trabajado (dias.horas:minutos:segundos): {0}", acumulaTiempo);
                    lblPanelInformativo.Text = contenido;
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
