
namespace AEV7
{
    partial class frmMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbCrearEmpleado = new System.Windows.Forms.GroupBox();
            this.mtxbNif = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.chbAdministrador = new System.Windows.Forms.CheckBox();
            this.txbContrasenya = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnSalirApp = new System.Windows.Forms.Button();
            this.dgvInfoEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvInfoFichajes = new System.Windows.Forms.DataGridView();
            this.lblInfoEmpleados = new System.Windows.Forms.Label();
            this.lblInfoFichajes = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbCrearEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoFichajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCrearEmpleado
            // 
            this.grbCrearEmpleado.Controls.Add(this.mtxbNif);
            this.grbCrearEmpleado.Controls.Add(this.btnEliminarEmpleado);
            this.grbCrearEmpleado.Controls.Add(this.btnAgregarEmpleado);
            this.grbCrearEmpleado.Controls.Add(this.chbAdministrador);
            this.grbCrearEmpleado.Controls.Add(this.txbContrasenya);
            this.grbCrearEmpleado.Controls.Add(this.txbApellidos);
            this.grbCrearEmpleado.Controls.Add(this.txbNombre);
            this.grbCrearEmpleado.Controls.Add(this.lblApellidos);
            this.grbCrearEmpleado.Controls.Add(this.lblContrasenya);
            this.grbCrearEmpleado.Controls.Add(this.lblNombre);
            this.grbCrearEmpleado.Controls.Add(this.lblNif);
            this.grbCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrearEmpleado.Location = new System.Drawing.Point(1189, 69);
            this.grbCrearEmpleado.Name = "grbCrearEmpleado";
            this.grbCrearEmpleado.Size = new System.Drawing.Size(632, 536);
            this.grbCrearEmpleado.TabIndex = 0;
            this.grbCrearEmpleado.TabStop = false;
            this.grbCrearEmpleado.Text = "Ingrese datos nuevo empleado:";
            // 
            // mtxbNif
            // 
            this.mtxbNif.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtxbNif.Location = new System.Drawing.Point(184, 86);
            this.mtxbNif.Mask = "00000000->L";
            this.mtxbNif.Name = "mtxbNif";
            this.mtxbNif.Size = new System.Drawing.Size(174, 38);
            this.mtxbNif.TabIndex = 0;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.AutoSize = true;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(464, 457);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(121, 41);
            this.btnEliminarEmpleado.TabIndex = 6;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.AutoSize = true;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(300, 457);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(120, 41);
            this.btnAgregarEmpleado.TabIndex = 5;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // chbAdministrador
            // 
            this.chbAdministrador.AutoSize = true;
            this.chbAdministrador.Location = new System.Drawing.Point(194, 293);
            this.chbAdministrador.Name = "chbAdministrador";
            this.chbAdministrador.Size = new System.Drawing.Size(226, 35);
            this.chbAdministrador.TabIndex = 3;
            this.chbAdministrador.Text = "Administrador/a";
            this.chbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txbContrasenya
            // 
            this.txbContrasenya.Location = new System.Drawing.Point(184, 355);
            this.txbContrasenya.Name = "txbContrasenya";
            this.txbContrasenya.Size = new System.Drawing.Size(227, 38);
            this.txbContrasenya.TabIndex = 4;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(184, 200);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(389, 38);
            this.txbApellidos.TabIndex = 2;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(184, 143);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(389, 38);
            this.txbNombre.TabIndex = 1;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(36, 203);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(132, 31);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Location = new System.Drawing.Point(16, 358);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(163, 31);
            this.lblContrasenya.TabIndex = 3;
            this.lblContrasenya.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 31);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(99, 89);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(67, 31);
            this.lblNif.TabIndex = 0;
            this.lblNif.Text = "NIF:";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.AutoSize = true;
            this.btnCerrarVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarVentana.Location = new System.Drawing.Point(1284, 732);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(233, 72);
            this.btnCerrarVentana.TabIndex = 7;
            this.btnCerrarVentana.Text = "Volver a \r\nPantalla Principal";
            this.btnCerrarVentana.UseVisualStyleBackColor = true;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btnSalirApp
            // 
            this.btnSalirApp.AutoSize = true;
            this.btnSalirApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalirApp.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirApp.Location = new System.Drawing.Point(1569, 751);
            this.btnSalirApp.Name = "btnSalirApp";
            this.btnSalirApp.Size = new System.Drawing.Size(223, 39);
            this.btnSalirApp.TabIndex = 8;
            this.btnSalirApp.Text = "Salir de Aplicación";
            this.btnSalirApp.UseVisualStyleBackColor = false;
            this.btnSalirApp.Click += new System.EventHandler(this.btnSalirApp_Click);
            // 
            // dgvInfoEmpleados
            // 
            this.dgvInfoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoEmpleados.Location = new System.Drawing.Point(58, 87);
            this.dgvInfoEmpleados.MultiSelect = false;
            this.dgvInfoEmpleados.Name = "dgvInfoEmpleados";
            this.dgvInfoEmpleados.ReadOnly = true;
            this.dgvInfoEmpleados.RowHeadersWidth = 51;
            this.dgvInfoEmpleados.RowTemplate.Height = 24;
            this.dgvInfoEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoEmpleados.Size = new System.Drawing.Size(1048, 330);
            this.dgvInfoEmpleados.TabIndex = 9;
            // 
            // dgvInfoFichajes
            // 
            this.dgvInfoFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoFichajes.Location = new System.Drawing.Point(57, 488);
            this.dgvInfoFichajes.Name = "dgvInfoFichajes";
            this.dgvInfoFichajes.ReadOnly = true;
            this.dgvInfoFichajes.RowHeadersWidth = 51;
            this.dgvInfoFichajes.RowTemplate.Height = 24;
            this.dgvInfoFichajes.Size = new System.Drawing.Size(1048, 330);
            this.dgvInfoFichajes.TabIndex = 10;
            // 
            // lblInfoEmpleados
            // 
            this.lblInfoEmpleados.AutoSize = true;
            this.lblInfoEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleados.Location = new System.Drawing.Point(52, 53);
            this.lblInfoEmpleados.Name = "lblInfoEmpleados";
            this.lblInfoEmpleados.Size = new System.Drawing.Size(357, 29);
            this.lblInfoEmpleados.TabIndex = 16;
            this.lblInfoEmpleados.Text = "Información de EMPLEADOS:";
            // 
            // lblInfoFichajes
            // 
            this.lblInfoFichajes.AutoSize = true;
            this.lblInfoFichajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFichajes.Location = new System.Drawing.Point(52, 456);
            this.lblInfoFichajes.Name = "lblInfoFichajes";
            this.lblInfoFichajes.Size = new System.Drawing.Size(322, 29);
            this.lblInfoFichajes.TabIndex = 17;
            this.lblInfoFichajes.Text = "Información de FICHAJES:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 853);
            this.Controls.Add(this.lblInfoFichajes);
            this.Controls.Add(this.lblInfoEmpleados);
            this.Controls.Add(this.dgvInfoFichajes);
            this.Controls.Add(this.dgvInfoEmpleados);
            this.Controls.Add(this.btnSalirApp);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.grbCrearEmpleado);
            this.Name = "frmMantenimiento";
            this.Text = "Pantalla Mantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMantenimiento_Load);
            this.grbCrearEmpleado.ResumeLayout(false);
            this.grbCrearEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoFichajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCrearEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.CheckBox chbAdministrador;
        private System.Windows.Forms.TextBox txbContrasenya;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Button btnSalirApp;
        private System.Windows.Forms.DataGridView dgvInfoEmpleados;
        private System.Windows.Forms.DataGridView dgvInfoFichajes;
        private System.Windows.Forms.Label lblInfoEmpleados;
        private System.Windows.Forms.Label lblInfoFichajes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mtxbNif;
    }
}