namespace AP14_01
{
    partial class FormPpal
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblnumSocios = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.radbMujer = new System.Windows.Forms.RadioButton();
            this.radbHombre = new System.Windows.Forms.RadioButton();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.trackbAltura = new System.Windows.Forms.TrackBar();
            this.nupdEdad = new System.Windows.Forms.NumericUpDown();
            this.lblCm = new System.Windows.Forms.Label();
            this.grbGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(61, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(86, 109);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(69, 25);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(86, 170);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(68, 25);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(78, 232);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(76, 25);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // lblnumSocios
            // 
            this.lblnumSocios.AutoSize = true;
            this.lblnumSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumSocios.Location = new System.Drawing.Point(23, 297);
            this.lblnumSocios.Name = "lblnumSocios";
            this.lblnumSocios.Size = new System.Drawing.Size(170, 24);
            this.lblnumSocios.TabIndex = 4;
            this.lblnumSocios.Text = "Número de socios:";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(602, 242);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(45, 24);
            this.lblNif.TabIndex = 5;
            this.lblNif.Text = "NIF:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(602, 289);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(93, 24);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "ESTADO:";
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.radbMujer);
            this.grbGenero.Controls.Add(this.radbHombre);
            this.grbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGenero.Location = new System.Drawing.Point(606, 49);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(168, 133);
            this.grbGenero.TabIndex = 7;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // radbMujer
            // 
            this.radbMujer.AutoSize = true;
            this.radbMujer.Checked = true;
            this.radbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbMujer.Location = new System.Drawing.Point(27, 89);
            this.radbMujer.Name = "radbMujer";
            this.radbMujer.Size = new System.Drawing.Size(87, 29);
            this.radbMujer.TabIndex = 5;
            this.radbMujer.TabStop = true;
            this.radbMujer.Text = "Mujer";
            this.radbMujer.UseVisualStyleBackColor = true;
            // 
            // radbHombre
            // 
            this.radbHombre.AutoSize = true;
            this.radbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbHombre.Location = new System.Drawing.Point(27, 43);
            this.radbHombre.Name = "radbHombre";
            this.radbHombre.Size = new System.Drawing.Size(108, 29);
            this.radbHombre.TabIndex = 4;
            this.radbHombre.TabStop = true;
            this.radbHombre.Text = "Hombre";
            this.radbHombre.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(970, 170);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(162, 42);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Text = "Alta de Socio";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(970, 224);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(162, 42);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info de Socio";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(970, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(162, 41);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(161, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(342, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(161, 167);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(74, 30);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.Text = "0";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // trackbAltura
            // 
            this.trackbAltura.Location = new System.Drawing.Point(161, 232);
            this.trackbAltura.Maximum = 210;
            this.trackbAltura.Minimum = 50;
            this.trackbAltura.Name = "trackbAltura";
            this.trackbAltura.Size = new System.Drawing.Size(314, 56);
            this.trackbAltura.TabIndex = 3;
            this.trackbAltura.Value = 50;
            this.trackbAltura.Scroll += new System.EventHandler(this.trackbAltura_Scroll);
            // 
            // nupdEdad
            // 
            this.nupdEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupdEdad.Location = new System.Drawing.Point(161, 107);
            this.nupdEdad.Name = "nupdEdad";
            this.nupdEdad.Size = new System.Drawing.Size(74, 30);
            this.nupdEdad.TabIndex = 1;
            this.nupdEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCm
            // 
            this.lblCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCm.Location = new System.Drawing.Point(481, 234);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(86, 24);
            this.lblCm.TabIndex = 15;
            this.lblCm.Text = " cm";
            // 
            // FormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 345);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.nupdEdad);
            this.Controls.Add(this.trackbAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblnumSocios);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormPpal";
            this.Text = "FormPpal";
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblnumSocios;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton radbHombre;
        private System.Windows.Forms.RadioButton radbMujer;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TrackBar trackbAltura;
        private System.Windows.Forms.NumericUpDown nupdEdad;
        private System.Windows.Forms.Label lblCm;
    }
}

