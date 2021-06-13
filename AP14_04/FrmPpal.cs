using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP14_04
{
    public partial class FrmPpal : Form
    {
        //atributos
        private double lado1;
        private double lado2;

        //constructor
        public FrmPpal()
        {
            InitializeComponent();
        }

        //Métodos de implementación
        private void rdb2lados_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2lados.Checked)
            {
                txt2lados.Visible = true;
            }
            else
            {
                txt2lados.Visible = false;
            }
        }

        private void txt1lado_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txt1lado.Text, out lado1)) txt1lado.Text = "";
        }

        private void txt2lados_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txt2lados.Text, out lado2)) txt2lados.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cuadrilatero c1;

            if (rdb2lados.Checked == true)
            {
                c1 = new Cuadrilatero(lado1, lado2);
            }
            else
            {
                c1 = new Cuadrilatero(lado1);
            }

            txtArea.Text = c1.Area().ToString("N");

            txtPerimetro.Text = c1.Perimetro().ToString("N");
        }
    }
}
