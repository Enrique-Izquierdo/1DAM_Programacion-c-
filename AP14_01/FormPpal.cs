using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP14_01
{
    public partial class FormPpal : Form
    {
        //atributos
        private Socio s1;
        private List<Socio> lista = new List<Socio>();
        
       //constructor
        public FormPpal()
        {
            InitializeComponent();
            this.Text = "Gestión de Socios";
        }

        //método implementación
        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out double peso))
            {
                txtPeso.Text = " ";
            }
        }

        private void trackbAltura_Scroll(object sender, EventArgs e)
        {
            lblCm.Text = trackbAltura.Value.ToString() + " cm";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            int edad = (int)nupdEdad.Value;
            char sexo;
            if (radbHombre.Checked)
            {
                sexo = 'H';
            }
            else
            {
                sexo = 'M';
            }


            s1 = new Socio(txtNombre.Text, edad, sexo, Convert.ToDouble(txtPeso.Text), trackbAltura.Value);
            lblNif.Text = "Nif: "+ s1.Nif;
            lblEstado.Text = "Estado: " + s1.CalcularIMC();
            lista.Add(s1);
            lblnumSocios.Text = "Número de socios: " + lista.Count.ToString();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.ToString(), "Información del Socio", MessageBoxButtons.OK);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
