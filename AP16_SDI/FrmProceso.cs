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
    public partial class FrmProceso : Form
    {
        //atributos
        private string info = "";

        //propiedades
        public string Info { get { return info; } }

        //constructores
        public FrmProceso()
        {
            InitializeComponent();
        }

        //métodos de implementación
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            info = txtComentario.Text;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
