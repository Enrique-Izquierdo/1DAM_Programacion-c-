using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP13
{
    public partial class FrmPrincipal : Form
    {
        //atributos "extra"
        private double valorVehic = 0;

        //constructor

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtValorVehiculo_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtValorVehiculo.Text, out double valor))
            {
                valorVehic = valor;
            }
            else
            {
                txtValorVehiculo.Text = "";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResumen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Presupuesto oferta = new Presupuesto(txtNombre.Text, grbSeguros.Controls,
                grbEquipamiento.Controls, valorVehic);

            txtResumen.Text = oferta.ToString();
        }
    }
}
