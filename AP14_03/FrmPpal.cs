using System;
using System.Windows.Forms;

namespace AP14_03
{
    public partial class FrmPpal : Form
    {
        //atributos
        Tablero t1;

        public FrmPpal()
        {
            InitializeComponent();            
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.Text = "Movimiento de un objeto en un Panel";
            t1 = new Tablero();
            lblCoordX.Text = "Coord.X = " + t1.getPosX().ToString();
            lblCoordY.Text = "Coord.Y = " + t1.getPosY().ToString();
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            t1.MoverArriba();
            lblCoordX.Text = "Coord.X = " + t1.getPosY().ToString();
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            t1.MoverAbajo();
            lblCoordX.Text = "Coord.X = " + t1.getPosY().ToString();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            t1.MoverIzquierda();
            lblCoordY.Text = "Coord.Y = " + t1.getPosX().ToString();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            t1.MoverDerecha();
            lblCoordY.Text = "Coord.Y = " + t1.getPosX().ToString();
        }

    }
}
