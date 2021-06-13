
namespace AP13
{
    partial class FrmPrincipal
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
            this.lblValorVehiculo = new System.Windows.Forms.Label();
            this.grbSeguros = new System.Windows.Forms.GroupBox();
            this.radBasico = new System.Windows.Forms.RadioButton();
            this.radTerceros = new System.Windows.Forms.RadioButton();
            this.radTodoRiesgo = new System.Windows.Forms.RadioButton();
            this.grbEquipamiento = new System.Windows.Forms.GroupBox();
            this.chkAireAcond = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValorVehiculo = new System.Windows.Forms.TextBox();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbSeguros.SuspendLayout();
            this.grbEquipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblValorVehiculo
            // 
            this.lblValorVehiculo.AutoSize = true;
            this.lblValorVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVehiculo.Location = new System.Drawing.Point(47, 306);
            this.lblValorVehiculo.Name = "lblValorVehiculo";
            this.lblValorVehiculo.Size = new System.Drawing.Size(137, 20);
            this.lblValorVehiculo.TabIndex = 1;
            this.lblValorVehiculo.Text = "Valor Vehículo:";
            // 
            // grbSeguros
            // 
            this.grbSeguros.Controls.Add(this.radTodoRiesgo);
            this.grbSeguros.Controls.Add(this.radTerceros);
            this.grbSeguros.Controls.Add(this.radBasico);
            this.grbSeguros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeguros.Location = new System.Drawing.Point(51, 95);
            this.grbSeguros.Name = "grbSeguros";
            this.grbSeguros.Size = new System.Drawing.Size(253, 170);
            this.grbSeguros.TabIndex = 2;
            this.grbSeguros.TabStop = false;
            this.grbSeguros.Text = "Seguros:";
            // 
            // radBasico
            // 
            this.radBasico.AutoSize = true;
            this.radBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBasico.Location = new System.Drawing.Point(50, 38);
            this.radBasico.Name = "radBasico";
            this.radBasico.Size = new System.Drawing.Size(82, 24);
            this.radBasico.TabIndex = 0;
            this.radBasico.TabStop = true;
            this.radBasico.Text = "Básico";
            this.radBasico.UseVisualStyleBackColor = true;
            // 
            // radTerceros
            // 
            this.radTerceros.AutoSize = true;
            this.radTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTerceros.Location = new System.Drawing.Point(50, 84);
            this.radTerceros.Name = "radTerceros";
            this.radTerceros.Size = new System.Drawing.Size(113, 24);
            this.radTerceros.TabIndex = 1;
            this.radTerceros.TabStop = true;
            this.radTerceros.Text = "A Terceros";
            this.radTerceros.UseVisualStyleBackColor = true;
            // 
            // radTodoRiesgo
            // 
            this.radTodoRiesgo.AutoSize = true;
            this.radTodoRiesgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTodoRiesgo.Location = new System.Drawing.Point(50, 128);
            this.radTodoRiesgo.Name = "radTodoRiesgo";
            this.radTodoRiesgo.Size = new System.Drawing.Size(124, 24);
            this.radTodoRiesgo.TabIndex = 2;
            this.radTodoRiesgo.TabStop = true;
            this.radTodoRiesgo.Text = "Todo Riesgo";
            this.radTodoRiesgo.UseVisualStyleBackColor = true;
            // 
            // grbEquipamiento
            // 
            this.grbEquipamiento.Controls.Add(this.chkAudio);
            this.grbEquipamiento.Controls.Add(this.chkAireAcond);
            this.grbEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEquipamiento.Location = new System.Drawing.Point(402, 95);
            this.grbEquipamiento.Name = "grbEquipamiento";
            this.grbEquipamiento.Size = new System.Drawing.Size(294, 170);
            this.grbEquipamiento.TabIndex = 3;
            this.grbEquipamiento.TabStop = false;
            this.grbEquipamiento.Text = "Equipamiento:";
            // 
            // chkAireAcond
            // 
            this.chkAireAcond.AutoSize = true;
            this.chkAireAcond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAireAcond.Location = new System.Drawing.Point(38, 40);
            this.chkAireAcond.Name = "chkAireAcond";
            this.chkAireAcond.Size = new System.Drawing.Size(175, 24);
            this.chkAireAcond.TabIndex = 0;
            this.chkAireAcond.Text = "Aire Acondicionado";
            this.chkAireAcond.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAudio.Location = new System.Drawing.Point(38, 85);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(162, 24);
            this.chkAudio.TabIndex = 1;
            this.chkAudio.Text = "Sistema de Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(156, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 26);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtValorVehiculo
            // 
            this.txtValorVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVehiculo.Location = new System.Drawing.Point(216, 300);
            this.txtValorVehiculo.Name = "txtValorVehiculo";
            this.txtValorVehiculo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorVehiculo.Size = new System.Drawing.Size(170, 26);
            this.txtValorVehiculo.TabIndex = 5;
            this.txtValorVehiculo.TextChanged += new System.EventHandler(this.txtValorVehiculo_TextChanged);
            // 
            // txtResumen
            // 
            this.txtResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumen.Location = new System.Drawing.Point(51, 356);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.ReadOnly = true;
            this.txtResumen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResumen.Size = new System.Drawing.Size(649, 145);
            this.txtResumen.TabIndex = 6;
            this.txtResumen.TextChanged += new System.EventHandler(this.txtResumen_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(603, 293);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 527);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.txtValorVehiculo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.grbEquipamiento);
            this.Controls.Add(this.grbSeguros);
            this.Controls.Add(this.lblValorVehiculo);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSeguros.ResumeLayout(false);
            this.grbSeguros.PerformLayout();
            this.grbEquipamiento.ResumeLayout(false);
            this.grbEquipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValorVehiculo;
        private System.Windows.Forms.GroupBox grbSeguros;
        private System.Windows.Forms.RadioButton radTodoRiesgo;
        private System.Windows.Forms.RadioButton radTerceros;
        private System.Windows.Forms.RadioButton radBasico;
        private System.Windows.Forms.GroupBox grbEquipamiento;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAireAcond;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValorVehiculo;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Button btnCalcular;
    }
}

