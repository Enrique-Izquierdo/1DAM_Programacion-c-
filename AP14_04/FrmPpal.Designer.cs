
namespace AP14_04
{
    partial class FrmPpal
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
            this.grbLados = new System.Windows.Forms.GroupBox();
            this.rdb1lado = new System.Windows.Forms.RadioButton();
            this.rdb2lados = new System.Windows.Forms.RadioButton();
            this.txt1lado = new System.Windows.Forms.TextBox();
            this.txt2lados = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.grbLados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLados
            // 
            this.grbLados.Controls.Add(this.btnCalcular);
            this.grbLados.Controls.Add(this.txt2lados);
            this.grbLados.Controls.Add(this.txt1lado);
            this.grbLados.Controls.Add(this.rdb2lados);
            this.grbLados.Controls.Add(this.rdb1lado);
            this.grbLados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLados.Location = new System.Drawing.Point(47, 38);
            this.grbLados.Name = "grbLados";
            this.grbLados.Size = new System.Drawing.Size(334, 260);
            this.grbLados.TabIndex = 0;
            this.grbLados.TabStop = false;
            this.grbLados.Text = "Introduce lados:";
            // 
            // rdb1lado
            // 
            this.rdb1lado.AutoSize = true;
            this.rdb1lado.Checked = true;
            this.rdb1lado.Location = new System.Drawing.Point(37, 61);
            this.rdb1lado.Name = "rdb1lado";
            this.rdb1lado.Size = new System.Drawing.Size(100, 29);
            this.rdb1lado.TabIndex = 0;
            this.rdb1lado.TabStop = true;
            this.rdb1lado.Text = "Un lado";
            this.rdb1lado.UseVisualStyleBackColor = true;
            // 
            // rdb2lados
            // 
            this.rdb2lados.AutoSize = true;
            this.rdb2lados.Location = new System.Drawing.Point(37, 119);
            this.rdb2lados.Name = "rdb2lados";
            this.rdb2lados.Size = new System.Drawing.Size(120, 29);
            this.rdb2lados.TabIndex = 1;
            this.rdb2lados.Text = "Dos lados";
            this.rdb2lados.UseVisualStyleBackColor = true;
            this.rdb2lados.CheckedChanged += new System.EventHandler(this.rdb2lados_CheckedChanged);
            // 
            // txt1lado
            // 
            this.txt1lado.Location = new System.Drawing.Point(174, 60);
            this.txt1lado.Name = "txt1lado";
            this.txt1lado.Size = new System.Drawing.Size(118, 30);
            this.txt1lado.TabIndex = 2;
            this.txt1lado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1lado.TextChanged += new System.EventHandler(this.txt1lado_TextChanged);
            // 
            // txt2lados
            // 
            this.txt2lados.Location = new System.Drawing.Point(174, 118);
            this.txt2lados.Name = "txt2lados";
            this.txt2lados.Size = new System.Drawing.Size(118, 30);
            this.txt2lados.TabIndex = 3;
            this.txt2lados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt2lados.Visible = false;
            this.txt2lados.TextChanged += new System.EventHandler(this.txt2lados_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Location = new System.Drawing.Point(122, 192);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(480, 106);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(69, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(424, 172);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lblPerimetro.TabIndex = 2;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(555, 103);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(139, 34);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(555, 169);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(139, 34);
            this.txtPerimetro.TabIndex = 4;
            this.txtPerimetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 342);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.grbLados);
            this.Name = "FrmPpal";
            this.Text = "Form1";
            this.grbLados.ResumeLayout(false);
            this.grbLados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt2lados;
        private System.Windows.Forms.TextBox txt1lado;
        private System.Windows.Forms.RadioButton rdb2lados;
        private System.Windows.Forms.RadioButton rdb1lado;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
    }
}

