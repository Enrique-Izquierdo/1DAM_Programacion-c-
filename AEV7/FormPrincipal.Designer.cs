
namespace AEV7
{
    partial class frmPpal
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
            this.grbNif = new System.Windows.Forms.GroupBox();
            this.mtxbNif = new System.Windows.Forms.MaskedTextBox();
            this.grbPermanencia = new System.Windows.Forms.GroupBox();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPanelInformativo = new System.Windows.Forms.Label();
            this.btnBorrarPanel = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grbNif.SuspendLayout();
            this.grbPermanencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNif
            // 
            this.grbNif.Controls.Add(this.mtxbNif);
            this.grbNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNif.Location = new System.Drawing.Point(72, 74);
            this.grbNif.Name = "grbNif";
            this.grbNif.Size = new System.Drawing.Size(464, 176);
            this.grbNif.TabIndex = 0;
            this.grbNif.TabStop = false;
            this.grbNif.Text = "Introduzca su NIF:";
            // 
            // mtxbNif
            // 
            this.mtxbNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxbNif.Location = new System.Drawing.Point(32, 66);
            this.mtxbNif.Mask = "00000000->L";
            this.mtxbNif.Name = "mtxbNif";
            this.mtxbNif.Size = new System.Drawing.Size(405, 83);
            this.mtxbNif.TabIndex = 1;
            this.mtxbNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbPermanencia
            // 
            this.grbPermanencia.Controls.Add(this.lblFechaFinal);
            this.grbPermanencia.Controls.Add(this.lblFechaInicial);
            this.grbPermanencia.Controls.Add(this.dtpFechaFinal);
            this.grbPermanencia.Controls.Add(this.dtpFechaInicial);
            this.grbPermanencia.Controls.Add(this.btnPermanencia);
            this.grbPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPermanencia.Location = new System.Drawing.Point(72, 423);
            this.grbPermanencia.Name = "grbPermanencia";
            this.grbPermanencia.Size = new System.Drawing.Size(464, 257);
            this.grbPermanencia.TabIndex = 4;
            this.grbPermanencia.TabStop = false;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(26, 111);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(179, 32);
            this.lblFechaFinal.TabIndex = 8;
            this.lblFechaFinal.Text = "Fecha Final: ";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(26, 36);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(190, 32);
            this.lblFechaInicial.TabIndex = 7;
            this.lblFechaInicial.Text = "Fecha Inicial: ";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(237, 105);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 38);
            this.dtpFechaFinal.TabIndex = 6;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(237, 30);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 38);
            this.dtpFechaInicial.TabIndex = 5;
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.AutoSize = true;
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(115, 184);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(228, 49);
            this.btnPermanencia.TabIndex = 7;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = true;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.AutoSize = true;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMantenimiento.Location = new System.Drawing.Point(1502, 793);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(250, 49);
            this.btnMantenimiento.TabIndex = 9;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.AutoSize = true;
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(210, 722);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(179, 49);
            this.btnPresencia.TabIndex = 8;
            this.btnPresencia.Text = "Presencia";
            this.btnPresencia.UseVisualStyleBackColor = true;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.AutoSize = true;
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnSalida.Location = new System.Drawing.Point(333, 295);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(176, 58);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "Salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.AutoSize = true;
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnEntrada.Location = new System.Drawing.Point(95, 295);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(176, 58);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(645, 66);
            this.lblHora.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(387, 98);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPanelInformativo
            // 
            this.lblPanelInformativo.BackColor = System.Drawing.Color.White;
            this.lblPanelInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelInformativo.Location = new System.Drawing.Point(645, 164);
            this.lblPanelInformativo.Margin = new System.Windows.Forms.Padding(0);
            this.lblPanelInformativo.Name = "lblPanelInformativo";
            this.lblPanelInformativo.Size = new System.Drawing.Size(1124, 601);
            this.lblPanelInformativo.TabIndex = 12;
            // 
            // btnBorrarPanel
            // 
            this.btnBorrarPanel.AutoSize = true;
            this.btnBorrarPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBorrarPanel.Location = new System.Drawing.Point(652, 793);
            this.btnBorrarPanel.Name = "btnBorrarPanel";
            this.btnBorrarPanel.Size = new System.Drawing.Size(395, 49);
            this.btnBorrarPanel.TabIndex = 10;
            this.btnBorrarPanel.Text = "Borrar Panel Informativo";
            this.btnBorrarPanel.UseVisualStyleBackColor = true;
            this.btnBorrarPanel.Click += new System.EventHandler(this.btnBorrarPanel_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1032, 66);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(737, 98);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 875);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnBorrarPanel);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.lblPanelInformativo);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.grbPermanencia);
            this.Controls.Add(this.grbNif);
            this.Name = "frmPpal";
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPpal_Load);
            this.grbNif.ResumeLayout(false);
            this.grbNif.PerformLayout();
            this.grbPermanencia.ResumeLayout(false);
            this.grbPermanencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNif;
        private System.Windows.Forms.GroupBox grbPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MaskedTextBox mtxbNif;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPanelInformativo;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Button btnBorrarPanel;
        private System.Windows.Forms.Label lblFecha;
    }
}

