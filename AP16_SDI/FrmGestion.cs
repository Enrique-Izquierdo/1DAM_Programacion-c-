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
    public partial class FrmGestion : Form
    {
        //atributos
        private string informacion;
        private string observacion;

        //propiedades
        public string Informacion { set { informacion = value; } }
        public string Observacion { get { return observacion; } }

        //constructores        
        public FrmGestion(string mensaje1)
        {
            InitializeComponent();
            lblMensaje1.Text = mensaje1;
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            lblMensaje2.Text = informacion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            observacion = txtObservaciones.Text;
            /* método .Close(): cierra visualmente el formulario
             * pero no lo descarga (elimina) de memoria*/
            this.Close();
            /* método .Dispose(): cierra visualmente el formulario
             * y lo descarga (elimina) de memoria*/
            //this.Dispose();
        }

    }
}
