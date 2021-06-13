
namespace AP16_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministrativa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecursosH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContable,
            this.mnuAdministrativa,
            this.mnuRecursosH,
            this.toolStripSeparator1,
            this.mnuSalir});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // mnuContable
            // 
            this.mnuContable.Name = "mnuContable";
            this.mnuContable.Size = new System.Drawing.Size(224, 26);
            this.mnuContable.Text = "Contable";
            this.mnuContable.Click += new System.EventHandler(this.mnuContable_Click);
            // 
            // mnuAdministrativa
            // 
            this.mnuAdministrativa.Name = "mnuAdministrativa";
            this.mnuAdministrativa.Size = new System.Drawing.Size(224, 26);
            this.mnuAdministrativa.Text = "Administrativa";
            this.mnuAdministrativa.Click += new System.EventHandler(this.mnuAdministrativa_Click);
            // 
            // mnuRecursosH
            // 
            this.mnuRecursosH.Name = "mnuRecursosH";
            this.mnuRecursosH.Size = new System.Drawing.Size(224, 26);
            this.mnuRecursosH.Text = "Recursos Humanos";
            this.mnuRecursosH.Click += new System.EventHandler(this.mnuRecursosH_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Gestión Empresarial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuContable;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrativa;
        private System.Windows.Forms.ToolStripMenuItem mnuRecursosH;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}

