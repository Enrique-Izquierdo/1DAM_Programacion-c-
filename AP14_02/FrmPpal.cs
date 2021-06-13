using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP14_02
{
    public partial class FrmPpal : Form
    {
        //atributos
        double lado1;
        double lado2;
        double lado3;

        //Constructor

        public FrmPpal()
        {
            InitializeComponent();
            this.Text = "Comprobación de Triangulos";
        }

        //Métodos implementación
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            //txtLado1.Text = "";
            //txtLado2.Text = "";
            //txtLado3.Text = "";
            pcbTriangulo.Image = null;
            txtLado1.Focus();
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLado1.Text, out lado1)) txtLado1.Text = "";
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLado2.Text, out lado2)) txtLado2.Text = "";
        }

        private void txtLado3_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLado3.Text, out lado3)) txtLado3.Text = "";
        }


        private void btnComprobar_Click(object sender, EventArgs e)
        {
            Triangulo t1 = new Triangulo(lado1, lado2, lado3);
            if (t1.EsEquilatero())
            {
                pcbTriangulo.Image = AP14_02.Properties.Resources.equilatero;
            }
            else if (t1.EsIsosceles())
            {
                pcbTriangulo.Image = AP14_02.Properties.Resources.isosceles;
            }
            else
            {
                pcbTriangulo.Image = AP14_02.Properties.Resources.escaleno;
            }
            
        }

    }
}
