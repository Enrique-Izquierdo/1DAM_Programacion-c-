
namespace AP14_02
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.pcbTriangulo = new System.Windows.Forms.PictureBox();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbDatos.Controls.Add(this.btnComprobar);
            this.grbDatos.Controls.Add(this.txtLado3);
            this.grbDatos.Controls.Add(this.txtLado2);
            this.grbDatos.Controls.Add(this.txtLado1);
            this.grbDatos.Controls.Add(this.lblLado3);
            this.grbDatos.Controls.Add(this.lblLado2);
            this.grbDatos.Controls.Add(this.lblLado1);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(33, 32);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(256, 268);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del Triángulo";
            // 
            // btnComprobar
            // 
            this.btnComprobar.AutoSize = true;
            this.btnComprobar.Location = new System.Drawing.Point(77, 204);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(120, 35);
            this.btnComprobar.TabIndex = 6;
            this.btnComprobar.Text = "&Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(120, 150);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 30);
            this.txtLado3.TabIndex = 5;
            this.txtLado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLado3.TextChanged += new System.EventHandler(this.txtLado3_TextChanged);
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(120, 102);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 30);
            this.txtLado2.TabIndex = 4;
            this.txtLado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLado2.TextChanged += new System.EventHandler(this.txtLado2_TextChanged);
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(120, 53);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 30);
            this.txtLado1.TabIndex = 3;
            this.txtLado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLado1.TextChanged += new System.EventHandler(this.txtLado1_TextChanged);
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Location = new System.Drawing.Point(18, 153);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(78, 25);
            this.lblLado3.TabIndex = 2;
            this.lblLado3.Text = "Lado 3:";
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Location = new System.Drawing.Point(18, 105);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(78, 25);
            this.lblLado2.TabIndex = 1;
            this.lblLado2.Text = "Lado 2:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(18, 56);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(78, 25);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1:";
            // 
            // pcbTriangulo
            // 
            this.pcbTriangulo.Image = global::AP14_02.Properties.Resources.blanco1;
            this.pcbTriangulo.Location = new System.Drawing.Point(336, 32);
            this.pcbTriangulo.Name = "pcbTriangulo";
            this.pcbTriangulo.Size = new System.Drawing.Size(269, 268);
            this.pcbTriangulo.TabIndex = 1;
            this.pcbTriangulo.TabStop = false;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 340);
            this.Controls.Add(this.pcbTriangulo);
            this.Controls.Add(this.grbDatos);
            this.Name = "FrmPpal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTriangulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.PictureBox pcbTriangulo;
    }
}

