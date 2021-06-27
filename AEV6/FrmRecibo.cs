using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV6
{
    public partial class FrmRecibo : Form
    {
        /*-----atributos-----*/
        Pedido ped1;
        int contadorTipoProductos = 0;
        //double importeTotal;

        /*-----propiedades-----*/
        /*-----constructor-----*/
        public FrmRecibo()
        {
            InitializeComponent();
        }

        /*-----getters y setters-----*/
        /*-----otros métodos de interface-----*/
        /*-----métodos de implementación-----*/
        private void FrmRecibo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;     
            
            Pedido.NumPedGlobal = 1;
            txtNumeroPedido.Text = Pedido.NumPedGlobal.ToString("D4");

            ped1 = new Pedido();

            Producto prod1 = new Producto("PS4 y 2 mandos DS4", 2000);
            Producto prod2 = new Producto("PS4 y 1 mando DS4", 1800);
            Producto prod3 = new Producto("PS3", 1350);
            Producto prod4 = new Producto("mando PS4 DS4", 250);
            Producto prod5 = new Producto("mando PS3 DS4", 175);
            Datos.ListaProductos.Add(prod1);
            Datos.ListaProductos.Add(prod2);
            Datos.ListaProductos.Add(prod3);
            Datos.ListaProductos.Add(prod4);
            Datos.ListaProductos.Add(prod5);
            cmbNombreDescripcion.Items.Add(Datos.ListaProductos[0].DescriProducto);
            cmbNombreDescripcion.Items.Add(Datos.ListaProductos[1].DescriProducto);
            cmbNombreDescripcion.Items.Add(Datos.ListaProductos[2].DescriProducto);
            cmbNombreDescripcion.Items.Add(Datos.ListaProductos[3].DescriProducto);
            cmbNombreDescripcion.Items.Add(Datos.ListaProductos[4].DescriProducto);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cmbNombreDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cmbNombreDescripcion.SelectedIndex;
            txtPrecio.Text = Datos.ListaProductos[indice].PrecioProducto.ToString();
        }

        private void btnAnyadirProducto_Click(object sender, EventArgs e)
        {  
            bool yaAnyadido = false;
            int indice;
            //double importe;

            /* Busqueda del producto a añadir al pedido, en la lista fuertemente tipada
             * (NombreProductos del objeto ped1) que contiene los productos ya añadidos
             * al pedido. Y, en caso de ya existir el producto en la lista, actualización
             * de las cantidades indicadas en el dataGridView, y en la lista fuertemente
             * tipada (CantXProducto del objeto ped1) que contiene las cantidades que,
             * de cada producto, se indican en el pedido.
             */
            for (int i = 0; i < ped1.NombreProductos.Count; i++)
            {
                if (cmbNombreDescripcion.SelectedItem.ToString() == ped1.NombreProductos[i])
                {                    
                    indice = i;
                    //importe = ped1.CalcularImporte(ped1.NombreProductos[indice], (int)nudCantidad.Value); 
                    ped1.CantXProducto[indice] += (int)nudCantidad.Value;
                    

                    dgvProductosPedido.Rows[indice].Cells[0].Value = ped1.CantXProducto[indice];
                    dgvProductosPedido.Rows[indice].Cells[3].Value =
                        ped1.CalcularImporte(ped1.NombreProductos[indice], ped1.CantXProducto[indice]);
                    
                    yaAnyadido = true;

                    //importeTotal += importe;
                }
            }

            /* En caso de no existir el producto en la lista fuertemente tipada
             * (NombreProductos del objeto ped1) que contiene los productos añadidos
             * al pedido y existir menos de 3 tipos de productos en la misma lista,
             * añade el producto y la cantidad indicada a las listas fuertemente tipadas
             * NombreProductos y CantXProducto del objeto ped1, y al dataGridView 
             * en una nueva línea.
             */
            if (!yaAnyadido && contadorTipoProductos < Pedido.MaxTipoProductos)
            {
                indice = contadorTipoProductos;

                ped1.NombreProductos.Add(cmbNombreDescripcion.SelectedItem.ToString());
                ped1.CantXProducto.Add((int)nudCantidad.Value);
                //importe = ped1.CalcularImporte(ped1.NombreProductos[indice], ped1.CantXProducto[indice]);

                dgvProductosPedido.Rows.Add(ped1.CantXProducto[indice], ped1.NombreProductos[indice],
                    ped1.DeterminarPrecio(ped1.NombreProductos[indice]),
                    ped1.CalcularImporte(ped1.NombreProductos[indice], ped1.CantXProducto[indice]));

                contadorTipoProductos += 1;

                //importeTotal += importe;
            }

            lblImporteTotal.Text = "Importe Total:  ";
            lblImporteTotal.Text += ped1.CalcularImporteTotal().ToString();
            //lblImporteTotal.Text += importeTotal.ToString();
        }

        private void dgvProductosPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?", "Eliminación",
                MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                int indice = e.RowIndex;
                ped1.NombreProductos.RemoveAt(indice);
                ped1.CantXProducto.RemoveAt(indice);
                dgvProductosPedido.Rows.Clear();
                //importeTotal = 0;
                for (int i=0; i<ped1.NombreProductos.Count; i++)
                {
                    dgvProductosPedido.Rows.Add(ped1.CantXProducto[i], ped1.NombreProductos[i],
                        ped1.DeterminarPrecio(ped1.NombreProductos[i]),
                        ped1.CalcularImporte(ped1.NombreProductos[i], ped1.CantXProducto[i]));
                    //importeTotal += ped1.CalcularImporte(ped1.NombreProductos[i], ped1.CantXProducto[i]);
                }

                lblImporteTotal.Text = "Importe total:  ";
                lblImporteTotal.Text += ped1.CalcularImporteTotal().ToString();
                //lblImporteTotal.Text += importeTotal.ToString();
                contadorTipoProductos--;
            }
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            dgvResumenPedidos.Rows.Add(Pedido.NumPedGlobal, txtNif.Text,
                dtpFechaPedido.Value.Date.ToString("d"), 
                ped1.calcularTotalProductos(), ped1.CalcularImporteTotal());

            ped1.NifCliente = txtNif.Text;
            ped1.NombreCliente = txtNombre.Text;
            ped1.Direccion = txtDireccion.Text;
            ped1.NumPedido = Pedido.NumPedGlobal;
            ped1.FechaPedido = dtpFechaPedido.Value;
            Datos.ListaPedidos.Add(ped1);
            ped1 = new Pedido();

            txtNif.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            dtpFechaPedido.Text = "";
            cmbNombreDescripcion.Text = "";            
            txtPrecio.Text = "";
            lblImporteTotal.Text = "Importe Total:";
            nudCantidad.Value = 0;                        
            dgvProductosPedido.Rows.Clear();
            contadorTipoProductos = 0;
            
            Pedido.NumPedGlobal++;
            txtNumeroPedido.Text = Pedido.NumPedGlobal.ToString("D4");
        }

        private void btnGuardarResumenPed_Click(object sender, EventArgs e)
        {
            Datos.GuardarResumen();
        }
    }
}
