using System;
using System.Windows.Forms;

namespace AP15
{
    public partial class frmPrincipal : Form
    {
        //atributos
        Empleado emp; //variable emp de tipo Empleado declarada a nivel de objeto.

        //propiedades
        //constructor
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //getters y setters
        //otros métodos de interface
        //métodos de implementación
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea recuperar los datos de los trabajadores?",
                "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                Datos.CargarArchivoEnLista();
                RestaurarContenidoDtgv();
            }

            lblMensaje.Text = "";
            lblNumero.Text = Convert.ToString(Datos.NumEmpleados());
        }

        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingresa nombre");
                //errorProvNombre.SetError(txtNombre, "Ingresa nombre"); //Esta forma tb es correcta
            } else
            {
                errorProvider1.SetError(txtNombre, "");
                //errorProvNombre.Clear(); // Esta forma tambien es correcta
            }

            if (txtPrimerApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPrimerApellido, "Ingresa Apellido");
                //errorProvApellido.SetError(txtPrimerApellido, "Ingresa Apellido");
            } else
            {
                errorProvider1.SetError(txtPrimerApellido, "");
                //errorProvApellido.Clear();
            }

            if (cmbPuestos.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbPuestos, "Ingresa Puesto");
                //errorProvPuesto.SetError(cmbPuestos, "Ingresa Puesto");
            } else
            {
                errorProvider1.SetError(cmbPuestos, "");
                //errorProvPuesto.Clear();
            }

            if (txtSalarioM.Text == "" || !double.TryParse(txtSalarioM.Text, out double salMes) ||
                salMes < 1000 || salMes > 2000)
            {
                ok = false;
                errorProvider1.SetError(txtSalarioM, "Ingresa salario valido");
                //errorProvSalarioM.SetError(txtSalarioM, "Ingresa salario valido");
            }
            else
            {
                errorProvider1.SetError(txtSalarioM, "");
                //errorProvSalarioM.Clear();
            }

            if (dtpFechaNac.Value >= DateTime.Today)
            {
                ok = false;
                errorProvider1.SetError(dtpFechaNac, "Selecciona Fecha de Naciminto");
                //errorProvFechaN.SetError(dtpFechaNac, "Selecciona Fecha de Nacimiento");
            }
            else
            {
                errorProvider1.SetError(dtpFechaNac, "");
                //errorProvFechaN.Clear();
            }

            return ok;
        }
        
        private bool ValidarDatos(TextBox objetoaValidar)
        {
            bool ok = true;

            if (objetoaValidar.Text == "")
            {
                ok = false;
                errorProvider1.SetError(objetoaValidar, "Ingresa texto");
                //errorProvNombre.SetError(objetoaValidar, "Ingresa texto");
            }
            else
            {
                errorProvider1.SetError(objetoaValidar, "");
                //errorProvNombre.Clear();
            }

            return ok;
        }

        private void RestaurarContenidoDtgv()
        {
            dtgVistaEmpleados.Rows.Clear();
            for (int i = 0; i < Datos.Plant.Count; i++)
            {
                dtgVistaEmpleados.Rows.Add(Datos.Plant[i].Nombre, Datos.Plant[i].PrimerApellido,
                    Datos.Plant[i].Puesto, Datos.Plant[i].Activo, Datos.Plant[i].SalarioMensual.ToString(),
                    Datos.Plant[i].FechaNacimiento.ToShortDateString());
            }
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                string nombre = txtNombre.Text;
                string primerApellido = txtPrimerApellido.Text;
                string puesto = cmbPuestos.Text;
                bool activo = chkActivo.Checked;
                double salarioMes = Convert.ToDouble(txtSalarioM.Text);
                DateTime fNacimiento = dtpFechaNac.Value;

                emp = new Empleado(nombre, primerApellido, puesto, activo, 
                    salarioMes, fNacimiento);
                Datos.AgregarEmpleado(emp);

                lblMensaje.Text = emp.MostrarDatos();
                lblNumero.Text = Convert.ToString(Datos.Plant.Count);

                dtgVistaEmpleados.Rows.Clear();
                for (int i = 0; i < Datos.Plant.Count; i++)
                {
                    dtgVistaEmpleados.Rows.Add(Datos.Plant[i].Nombre,
                        Datos.Plant[i].PrimerApellido, Datos.Plant[i].Puesto,Datos.Plant[i].Activo,
                        Datos.Plant[i].SalarioMensual.ToString(),
                        Datos.Plant[i].FechaNacimiento.ToShortDateString());
                    // Otra forma de rellenar el datagridview
                    //dtgVistaEmpleados.Rows.Add();
                    //dtgVistaEmpleados[0,i].Value = Datos.Plant[i].Nombre;
                    //dtgVistaEmpleados[1,i].Value = Datos.Plant[i].PrimerApellido;
                    //dtgVistaEmpleados[2, i].Value = Datos.Plant[i].Puesto;
                    //dtgVistaEmpleados[3, i].Value = Datos.Plant[i].Activo;
                }

                txtNombre.Text = "";
                txtPrimerApellido.Text = "";
                cmbPuestos.Text = "";
                txtSalarioM.Text = "";
                dtpFechaNac.Value = DateTime.Now;
                chkActivo.Checked = false;
                txtNombre.Focus();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea guardar los datos de los trabajadores?",
                "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (respuesta == DialogResult.Yes)
            {
                Datos.GuardarListaEnArchivo();
            }

            this.Dispose();
        }
                
        private void cmdAyuda_Click(object sender, EventArgs e)
        {
            // Ejemplo de uso completo de MessageBox
            DialogResult resultado = MessageBox.Show("¿Deseas ayuda de la aplicación?",
                "Ayuda", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Accediendo a la ayuda");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(txtAcciones))
            {
                dtgVistaEmpleados.Rows.Clear();
                for (int i = 0; i < Datos.Plant.Count; i++)
                {
                    if (txtAcciones.Text == Datos.Plant[i].Nombre || txtAcciones.Text == Datos.Plant[i].PrimerApellido)
                    {
                        dtgVistaEmpleados.Rows.Add(Datos.Plant[i].Nombre, Datos.Plant[i].PrimerApellido,
                            Datos.Plant[i].Puesto, Datos.Plant[i].Activo, Datos.Plant[i].SalarioMensual.ToString(),
                            Datos.Plant[i].FechaNacimiento.ToShortDateString());
                    }
                }

                if (dtgVistaEmpleados.Rows.Count == 0)
                {
                    MessageBox.Show("No existe ningún empleado: " + txtAcciones.Text, "¡Atención!");
                    RestaurarContenidoDtgv();
                }

                txtAcciones.Text = "";
                txtNombre.Focus();
            }                        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(txtAcciones))
            {
                bool testigo = true;

                dtgVistaEmpleados.Rows.Clear();
                for (int i = 0; i < Datos.Plant.Count; i++)
                {
                    if (Datos.Plant[i].Nombre == txtAcciones.Text && testigo)
                    {
                        Datos.Plant.RemoveAt(i);
                        testigo = false;
                        RestaurarContenidoDtgv();
                    }
                }
                
                if (testigo)
                {
                    MessageBox.Show("No existe ningún empleado: " + txtAcciones.Text +
                        "que pueda eliminarse", "¡Atención!");
                    RestaurarContenidoDtgv();
                }

                txtAcciones.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos(txtAcciones))
            {
                dtgVistaEmpleados.Rows.Clear();
                for (int i = 0; i < Datos.Plant.Count; i++)
                {
                    if (txtAcciones.Text == Datos.Plant[i].Puesto)
                    {
                        dtgVistaEmpleados.Rows.Add(Datos.Plant[i].Nombre, Datos.Plant[i].PrimerApellido,
                            Datos.Plant[i].Puesto, Datos.Plant[i].Activo, Datos.Plant[i].SalarioMensual.ToString(),
                            Datos.Plant[i].FechaNacimiento.ToShortDateString());
                    }
                }

                if (dtgVistaEmpleados.Rows.Count == 0)
                {
                    MessageBox.Show("No existe ningún empleado con puesto: " + txtAcciones.Text, "¡Atención!");
                    RestaurarContenidoDtgv();
                }

                txtAcciones.Text = "";
                txtNombre.Focus();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarContenidoDtgv();
        }

        private void btnDatosEst_Click(object sender, EventArgs e)
        {
            if (Datos.Plant.Count > 0)
            {
                MessageBox.Show(Datos.EstadisticasPlantilla(DateTime.Parse("01/01/2000")),
                "Datos Estadísticos de la plantilla");
            }
            else
            {
                MessageBox.Show("No hay datos en la lista de empleados.", "¡Atención!");      
            }            
        }

        private void dtgVistaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                /* Mediante un casting transformamos a string, el contenido de la celda 5
                 * (atributo de tipo objeto, pertenecinete al objeto dtgVistaEmpleados 
                 * -clase dataGridView-) que es devuelto por la propiedad "Value" del
                 * objeto dtgVistaEmpleados*/
                string fechaNacimiento = (string)dtgVistaEmpleados.Rows[e.RowIndex].Cells[5].Value;
                
                MessageBox.Show("Edad del empleado: " + emp.CalcularEdad(fechaNacimiento).ToString());                    
            }            
        }
    }    
}
