namespace AEV6
{
    partial class FrmRecibo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.grbDatosProducto = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbNombreDescripcion = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombreDescripcion = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dgvProductosPedido = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProductosPedido = new System.Windows.Forms.Label();
            this.btnAnyadirProducto = new System.Windows.Forms.Button();
            this.lblLeyendaProdPed = new System.Windows.Forms.Label();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.lblResumenPedidos = new System.Windows.Forms.Label();
            this.dgvResumenPedidos = new System.Windows.Forms.DataGridView();
            this.colNumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarResumenPed = new System.Windows.Forms.Button();
            this.lblPedidosRecibos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbDatosCliente.SuspendLayout();
            this.grbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.txtDireccion);
            this.grbDatosCliente.Controls.Add(this.txtNombre);
            this.grbDatosCliente.Controls.Add(this.txtNif);
            this.grbDatosCliente.Controls.Add(this.lblNombre);
            this.grbDatosCliente.Controls.Add(this.lblDireccion);
            this.grbDatosCliente.Controls.Add(this.lblNif);
            this.grbDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosCliente.Location = new System.Drawing.Point(29, 30);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(660, 120);
            this.grbDatosCliente.TabIndex = 0;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos de Cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(529, 26);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(345, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(68, 31);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(155, 26);
            this.txtNif.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(266, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(86, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(22, 34);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(40, 20);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF:";
            // 
            // grbDatosProducto
            // 
            this.grbDatosProducto.Controls.Add(this.nudCantidad);
            this.grbDatosProducto.Controls.Add(this.txtPrecio);
            this.grbDatosProducto.Controls.Add(this.cmbNombreDescripcion);
            this.grbDatosProducto.Controls.Add(this.lblCantidad);
            this.grbDatosProducto.Controls.Add(this.lblPrecio);
            this.grbDatosProducto.Controls.Add(this.lblNombreDescripcion);
            this.grbDatosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosProducto.Location = new System.Drawing.Point(29, 265);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Size = new System.Drawing.Size(660, 121);
            this.grbDatosProducto.TabIndex = 1;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Datos de Producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(496, 75);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 26);
            this.nudCantidad.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(308, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(95, 26);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbNombreDescripcion
            // 
            this.cmbNombreDescripcion.FormattingEnabled = true;
            this.cmbNombreDescripcion.Location = new System.Drawing.Point(26, 74);
            this.cmbNombreDescripcion.Name = "cmbNombreDescripcion";
            this.cmbNombreDescripcion.Size = new System.Drawing.Size(197, 28);
            this.cmbNombreDescripcion.TabIndex = 4;
            this.cmbNombreDescripcion.SelectedIndexChanged += new System.EventHandler(this.cmbNombreDescripcion_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(492, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(304, 41);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombreDescripcion
            // 
            this.lblNombreDescripcion.AutoSize = true;
            this.lblNombreDescripcion.Location = new System.Drawing.Point(22, 41);
            this.lblNombreDescripcion.Name = "lblNombreDescripcion";
            this.lblNombreDescripcion.Size = new System.Drawing.Size(168, 20);
            this.lblNombreDescripcion.TabIndex = 1;
            this.lblNombreDescripcion.Text = "Nombre/Descripción:";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(25, 194);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(129, 20);
            this.lblNumPedido.TabIndex = 2;
            this.lblNumPedido.Text = "Número Pedido:";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.Location = new System.Drawing.Point(353, 194);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(116, 20);
            this.lblFechaPedido.TabIndex = 3;
            this.lblFechaPedido.Text = "Fecha Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPedido.Location = new System.Drawing.Point(160, 191);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(92, 26);
            this.txtNumeroPedido.TabIndex = 5;
            this.txtNumeroPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPedido.Location = new System.Drawing.Point(475, 189);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(133, 26);
            this.dtpFechaPedido.TabIndex = 6;
            // 
            // dgvProductosPedido
            // 
            this.dgvProductosPedido.AllowUserToAddRows = false;
            this.dgvProductosPedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colNombre,
            this.ColPrecioUnit,
            this.ColImporte});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosPedido.Location = new System.Drawing.Point(29, 481);
            this.dgvProductosPedido.Name = "dgvProductosPedido";
            this.dgvProductosPedido.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosPedido.RowHeadersWidth = 51;
            this.dgvProductosPedido.RowTemplate.Height = 24;
            this.dgvProductosPedido.Size = new System.Drawing.Size(607, 165);
            this.dgvProductosPedido.TabIndex = 7;
            this.dgvProductosPedido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductosPedido_CellMouseDoubleClick);
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 90;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre/Descripción";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 225;
            // 
            // ColPrecioUnit
            // 
            this.ColPrecioUnit.HeaderText = "Precio Unitario";
            this.ColPrecioUnit.MinimumWidth = 6;
            this.ColPrecioUnit.Name = "ColPrecioUnit";
            this.ColPrecioUnit.ReadOnly = true;
            this.ColPrecioUnit.Width = 140;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "Importe";
            this.ColImporte.MinimumWidth = 6;
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 125;
            // 
            // lblProductosPedido
            // 
            this.lblProductosPedido.AutoSize = true;
            this.lblProductosPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosPedido.Location = new System.Drawing.Point(24, 445);
            this.lblProductosPedido.Name = "lblProductosPedido";
            this.lblProductosPedido.Size = new System.Drawing.Size(197, 25);
            this.lblProductosPedido.TabIndex = 8;
            this.lblProductosPedido.Text = "Productos del Pedido";
            // 
            // btnAnyadirProducto
            // 
            this.btnAnyadirProducto.AutoSize = true;
            this.btnAnyadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnyadirProducto.Location = new System.Drawing.Point(482, 440);
            this.btnAnyadirProducto.Name = "btnAnyadirProducto";
            this.btnAnyadirProducto.Size = new System.Drawing.Size(154, 30);
            this.btnAnyadirProducto.TabIndex = 9;
            this.btnAnyadirProducto.Text = "Añadir Producto";
            this.btnAnyadirProducto.UseVisualStyleBackColor = true;
            this.btnAnyadirProducto.Click += new System.EventHandler(this.btnAnyadirProducto_Click);
            // 
            // lblLeyendaProdPed
            // 
            this.lblLeyendaProdPed.AutoSize = true;
            this.lblLeyendaProdPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendaProdPed.Location = new System.Drawing.Point(25, 649);
            this.lblLeyendaProdPed.Name = "lblLeyendaProdPed";
            this.lblLeyendaProdPed.Size = new System.Drawing.Size(331, 15);
            this.lblLeyendaProdPed.TabIndex = 10;
            this.lblLeyendaProdPed.Text = "Realiza doble click sobre la línea para eliminar un producto";
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(424, 666);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(124, 24);
            this.lblImporteTotal.TabIndex = 10;
            this.lblImporteTotal.Text = "Importe Total:";
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.AutoSize = true;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.Location = new System.Drawing.Point(1211, 440);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(160, 30);
            this.btnRegistrarPedido.TabIndex = 13;
            this.btnRegistrarPedido.Text = "Registrar Pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = true;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // lblResumenPedidos
            // 
            this.lblResumenPedidos.AutoSize = true;
            this.lblResumenPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenPedidos.Location = new System.Drawing.Point(691, 445);
            this.lblResumenPedidos.Name = "lblResumenPedidos";
            this.lblResumenPedidos.Size = new System.Drawing.Size(198, 25);
            this.lblResumenPedidos.TabIndex = 12;
            this.lblResumenPedidos.Text = "Resumen de Pedidos";
            // 
            // dgvResumenPedidos
            // 
            this.dgvResumenPedidos.AllowUserToAddRows = false;
            this.dgvResumenPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumenPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResumenPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumenPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumPedido,
            this.ColNif,
            this.colFecha,
            this.colTotalProductos,
            this.colImporteTotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumenPedidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResumenPedidos.Location = new System.Drawing.Point(696, 481);
            this.dgvResumenPedidos.Name = "dgvResumenPedidos";
            this.dgvResumenPedidos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumenPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResumenPedidos.RowHeadersWidth = 51;
            this.dgvResumenPedidos.RowTemplate.Height = 24;
            this.dgvResumenPedidos.Size = new System.Drawing.Size(675, 165);
            this.dgvResumenPedidos.TabIndex = 11;
            // 
            // colNumPedido
            // 
            this.colNumPedido.HeaderText = "Nº Pedido";
            this.colNumPedido.MinimumWidth = 6;
            this.colNumPedido.Name = "colNumPedido";
            this.colNumPedido.ReadOnly = true;
            this.colNumPedido.Width = 110;
            // 
            // ColNif
            // 
            this.ColNif.HeaderText = "NIF_Cliente";
            this.ColNif.MinimumWidth = 6;
            this.ColNif.Name = "ColNif";
            this.ColNif.ReadOnly = true;
            this.ColNif.Width = 125;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 125;
            // 
            // colTotalProductos
            // 
            this.colTotalProductos.HeaderText = "Total Productos";
            this.colTotalProductos.MinimumWidth = 6;
            this.colTotalProductos.Name = "colTotalProductos";
            this.colTotalProductos.ReadOnly = true;
            this.colTotalProductos.Width = 140;
            // 
            // colImporteTotal
            // 
            this.colImporteTotal.HeaderText = "Importe Total";
            this.colImporteTotal.MinimumWidth = 6;
            this.colImporteTotal.Name = "colImporteTotal";
            this.colImporteTotal.ReadOnly = true;
            this.colImporteTotal.Width = 120;
            // 
            // btnGuardarResumenPed
            // 
            this.btnGuardarResumenPed.AutoSize = true;
            this.btnGuardarResumenPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarResumenPed.Location = new System.Drawing.Point(1101, 660);
            this.btnGuardarResumenPed.Name = "btnGuardarResumenPed";
            this.btnGuardarResumenPed.Size = new System.Drawing.Size(270, 30);
            this.btnGuardarResumenPed.TabIndex = 14;
            this.btnGuardarResumenPed.Text = "Guardar Resumen de Pedidos";
            this.btnGuardarResumenPed.UseVisualStyleBackColor = true;
            this.btnGuardarResumenPed.Click += new System.EventHandler(this.btnGuardarResumenPed_Click);
            // 
            // lblPedidosRecibos
            // 
            this.lblPedidosRecibos.AutoSize = true;
            this.lblPedidosRecibos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPedidosRecibos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidosRecibos.Location = new System.Drawing.Point(785, 42);
            this.lblPedidosRecibos.Name = "lblPedidosRecibos";
            this.lblPedidosRecibos.Size = new System.Drawing.Size(267, 32);
            this.lblPedidosRecibos.TabIndex = 15;
            this.lblPedidosRecibos.Text = "Pedidos y Recibos";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1149, 42);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 32);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = "Hora";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::AEV6.Properties.Resources.LogoFloridaGames;
            this.picLogo.Location = new System.Drawing.Point(754, 110);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(617, 276);
            this.picLogo.TabIndex = 17;
            this.picLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 717);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPedidosRecibos);
            this.Controls.Add(this.btnGuardarResumenPed);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.lblResumenPedidos);
            this.Controls.Add(this.dgvResumenPedidos);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.lblLeyendaProdPed);
            this.Controls.Add(this.btnAnyadirProducto);
            this.Controls.Add(this.lblProductosPedido);
            this.Controls.Add(this.dgvProductosPedido);
            this.Controls.Add(this.dtpFechaPedido);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.lblFechaPedido);
            this.Controls.Add(this.lblNumPedido);
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.grbDatosCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRecibo";
            this.Text = "Gestión de Pedidos";
            this.Load += new System.EventHandler(this.FrmRecibo_Load);
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.grbDatosProducto.ResumeLayout(false);
            this.grbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.GroupBox grbDatosProducto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.ComboBox cmbNombreDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreDescripcion;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvProductosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        private System.Windows.Forms.Label lblProductosPedido;
        private System.Windows.Forms.Button btnAnyadirProducto;
        private System.Windows.Forms.Label lblLeyendaProdPed;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Label lblResumenPedidos;
        private System.Windows.Forms.DataGridView dgvResumenPedidos;
        private System.Windows.Forms.Button btnGuardarResumenPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporteTotal;
        private System.Windows.Forms.Label lblPedidosRecibos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Timer timer1;
    }
}

