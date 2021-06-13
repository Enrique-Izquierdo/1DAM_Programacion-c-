namespace AP15
{
    partial class frmPrincipal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgVistaEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto_Trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salarioMensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.lblNumeroEmpleados = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.errorProvNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.cmdAyuda = new System.Windows.Forms.Button();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.txtAcciones = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSalarioM = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtSalarioM = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnDatosEst = new System.Windows.Forms.Button();
            this.errorProvApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvPuesto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvSalarioM = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvFechaN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvNombre)).BeginInit();
            this.grbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvSalarioM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFechaN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(416, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(349, 66);
            this.lblApellido1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(158, 22);
            this.lblApellido1.TabIndex = 1;
            this.lblApellido1.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(516, 26);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(516, 65);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(263, 26);
            this.txtPrimerApellido.TabIndex = 2;
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAltaEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(634, 325);
            this.btnAltaEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(145, 44);
            this.btnAltaEmpleado.TabIndex = 7;
            this.btnAltaEmpleado.Text = "Alta";
            this.btnAltaEmpleado.UseVisualStyleBackColor = false;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(61, 314);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(64, 25);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "label1";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(550, 681);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 44);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgVistaEmpleados
            // 
            this.dtgVistaEmpleados.AllowUserToAddRows = false;
            this.dtgVistaEmpleados.AllowUserToDeleteRows = false;
            this.dtgVistaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVistaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Primer_Apellido,
            this.Puesto_Trabajo,
            this.Activo,
            this.salarioMensual,
            this.fechaNacimiento});
            this.dtgVistaEmpleados.Location = new System.Drawing.Point(37, 390);
            this.dtgVistaEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dtgVistaEmpleados.Name = "dtgVistaEmpleados";
            this.dtgVistaEmpleados.ReadOnly = true;
            this.dtgVistaEmpleados.RowHeadersWidth = 51;
            this.dtgVistaEmpleados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVistaEmpleados.Size = new System.Drawing.Size(760, 224);
            this.dtgVistaEmpleados.TabIndex = 13;
            this.dtgVistaEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVistaEmpleados_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 75;
            // 
            // Primer_Apellido
            // 
            this.Primer_Apellido.HeaderText = "Primer_Apellido";
            this.Primer_Apellido.MinimumWidth = 6;
            this.Primer_Apellido.Name = "Primer_Apellido";
            this.Primer_Apellido.ReadOnly = true;
            this.Primer_Apellido.Width = 125;
            // 
            // Puesto_Trabajo
            // 
            this.Puesto_Trabajo.HeaderText = "Puesto_Trabajo";
            this.Puesto_Trabajo.MinimumWidth = 6;
            this.Puesto_Trabajo.Name = "Puesto_Trabajo";
            this.Puesto_Trabajo.ReadOnly = true;
            this.Puesto_Trabajo.Width = 125;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 40;
            // 
            // salarioMensual
            // 
            this.salarioMensual.HeaderText = "Salario_Mensual";
            this.salarioMensual.MinimumWidth = 6;
            this.salarioMensual.Name = "salarioMensual";
            this.salarioMensual.ReadOnly = true;
            this.salarioMensual.Width = 125;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha_Nacimiento";
            this.fechaNacimiento.MinimumWidth = 6;
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 125;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(424, 107);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(82, 22);
            this.lblPuesto.TabIndex = 9;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Items.AddRange(new object[] {
            "Administrativo",
            "Conductor",
            "Electricista",
            "Gerente",
            "Mecánico"});
            this.cmbPuestos.Location = new System.Drawing.Point(516, 109);
            this.cmbPuestos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(263, 24);
            this.cmbPuestos.Sorted = true;
            this.cmbPuestos.TabIndex = 3;
            // 
            // lblNumeroEmpleados
            // 
            this.lblNumeroEmpleados.AutoSize = true;
            this.lblNumeroEmpleados.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEmpleados.Location = new System.Drawing.Point(43, 628);
            this.lblNumeroEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEmpleados.Name = "lblNumeroEmpleados";
            this.lblNumeroEmpleados.Size = new System.Drawing.Size(170, 22);
            this.lblNumeroEmpleados.TabIndex = 11;
            this.lblNumeroEmpleados.Text = "Total empleados:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(210, 628);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 22);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "Numero";
            // 
            // errorProvNombre
            // 
            this.errorProvNombre.ContainerControl = this;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(660, 240);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkActivo.Size = new System.Drawing.Size(119, 26);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "En Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // cmdAyuda
            // 
            this.cmdAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmdAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAyuda.ForeColor = System.Drawing.Color.Black;
            this.cmdAyuda.Location = new System.Drawing.Point(47, 681);
            this.cmdAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAyuda.Name = "cmdAyuda";
            this.cmdAyuda.Size = new System.Drawing.Size(145, 44);
            this.cmdAyuda.TabIndex = 15;
            this.cmdAyuda.Text = "&Ayuda";
            this.cmdAyuda.UseVisualStyleBackColor = false;
            this.cmdAyuda.Click += new System.EventHandler(this.cmdAyuda_Click);
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.txtAcciones);
            this.grbAcciones.Controls.Add(this.btnRestaurar);
            this.grbAcciones.Controls.Add(this.btnFiltrar);
            this.grbAcciones.Controls.Add(this.btnEliminar);
            this.grbAcciones.Controls.Add(this.btnBuscar);
            this.grbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAcciones.Location = new System.Drawing.Point(56, 15);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Size = new System.Drawing.Size(199, 267);
            this.grbAcciones.TabIndex = 16;
            this.grbAcciones.TabStop = false;
            this.grbAcciones.Text = "Acciones";
            // 
            // txtAcciones
            // 
            this.txtAcciones.Location = new System.Drawing.Point(22, 223);
            this.txtAcciones.Name = "txtAcciones";
            this.txtAcciones.Size = new System.Drawing.Size(155, 28);
            this.txtAcciones.TabIndex = 8;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(47, 164);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(111, 36);
            this.btnRestaurar.TabIndex = 12;
            this.btnRestaurar.Text = "&Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(47, 122);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 36);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(47, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(47, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 37);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSalarioM
            // 
            this.lblSalarioM.AutoSize = true;
            this.lblSalarioM.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioM.Location = new System.Drawing.Point(340, 151);
            this.lblSalarioM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioM.Name = "lblSalarioM";
            this.lblSalarioM.Size = new System.Drawing.Size(166, 22);
            this.lblSalarioM.TabIndex = 17;
            this.lblSalarioM.Text = "Salario Mensual:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(296, 199);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(210, 22);
            this.lblFechaNac.TabIndex = 18;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // txtSalarioM
            // 
            this.txtSalarioM.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioM.Location = new System.Drawing.Point(516, 150);
            this.txtSalarioM.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioM.Name = "txtSalarioM";
            this.txtSalarioM.Size = new System.Drawing.Size(263, 26);
            this.txtSalarioM.TabIndex = 4;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(516, 194);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(263, 28);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // btnDatosEst
            // 
            this.btnDatosEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosEst.Location = new System.Drawing.Point(446, 305);
            this.btnDatosEst.Name = "btnDatosEst";
            this.btnDatosEst.Size = new System.Drawing.Size(127, 61);
            this.btnDatosEst.TabIndex = 19;
            this.btnDatosEst.Text = "&Datos Estadísticos";
            this.btnDatosEst.UseVisualStyleBackColor = true;
            this.btnDatosEst.Click += new System.EventHandler(this.btnDatosEst_Click);
            // 
            // errorProvApellido
            // 
            this.errorProvApellido.ContainerControl = this;
            // 
            // errorProvPuesto
            // 
            this.errorProvPuesto.ContainerControl = this;
            // 
            // errorProvSalarioM
            // 
            this.errorProvSalarioM.ContainerControl = this;
            // 
            // errorProvFechaN
            // 
            this.errorProvFechaN.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 743);
            this.Controls.Add(this.btnDatosEst);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtSalarioM);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblSalarioM);
            this.Controls.Add(this.grbAcciones);
            this.Controls.Add(this.cmdAyuda);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNumeroEmpleados);
            this.Controls.Add(this.cmbPuestos);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.dtgVistaEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAltaEmpleado);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Empleados";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvNombre)).EndInit();
            this.grbAcciones.ResumeLayout(false);
            this.grbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvSalarioM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFechaN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgVistaEmpleados;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.Label lblNumeroEmpleados;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ErrorProvider errorProvNombre;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button cmdAyuda;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto_Trabajo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioMensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.TextBox txtSalarioM;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSalarioM;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnDatosEst;
        private System.Windows.Forms.ErrorProvider errorProvApellido;
        private System.Windows.Forms.ErrorProvider errorProvPuesto;
        private System.Windows.Forms.ErrorProvider errorProvSalarioM;
        private System.Windows.Forms.ErrorProvider errorProvFechaN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

