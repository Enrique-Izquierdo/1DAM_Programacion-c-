using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP16
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirGestion_Click(object sender, EventArgs e)
        {
            FrmGestion gestion1 = new FrmGestion(txtMensaje1.Text);
            gestion1.Informacion = txtMensaje2.Text;
            /* Apertura NO MODAL del formulario: 
             * permite interactuar con ambos formularios a la vez*/
            //gestion1.Show();
            /* Apertura MODAL del formulario:
             * no permite interactuar con el formulario principal
             * mientras esté abierto el secundario
             * Además detiene la lectura de las siguientes líneas
             * de código hasta que el formulario secundario es cerrado*/
            gestion1.ShowDialog();
            /* La siguiente forma de pasar información del
             * formulario secundario al principal solo funciona,
             * si se emplea el metodo .ShowDialog() para visualizar
             * el formulario secundario*/
            lblObservaciones.Text = gestion1.Observacion;
        }

        private void btnProceso_Click(object sender, EventArgs e)
        {
            FrmProceso proceso = new FrmProceso();
            DialogResult respuesta = proceso.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                lblObservaciones.Text = proceso.Info;
            }
            if (respuesta == DialogResult.Cancel)
            {
                MessageBox.Show("Has cancelado la operación");
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe ayuda = new FrmAcercaDe();
            ayuda.ShowDialog();
        }

        private void activadosToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtMensaje1.Enabled = MnuActivados.Checked;
            txtMensaje2.Enabled = MnuActivados.Checked;
        }

        private void cmnuAzul_Click(object sender, EventArgs e)
        {
            txtMensaje1.BackColor = Color.Blue;
        }

        private void cmnuAmarillo_Click(object sender, EventArgs e)
        {
            txtMensaje1.BackColor = Color.Yellow;
        }

        private void cmnuRestablecer_Click(object sender, EventArgs e)
        {
            txtMensaje1.BackColor = Color.White;
        }

        private void tstbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirTareas_Click(object sender, EventArgs e)
        {
            FrmTareas tarea1 = new FrmTareas();
            tarea1.ShowDialog();
        }
    }
}
