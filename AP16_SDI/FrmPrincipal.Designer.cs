
namespace AP16
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
            this.components = new System.ComponentModel.Container();
            this.btnAbrirGestion = new System.Windows.Forms.Button();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.cmnuTxtMensaje1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuAmarillo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRestablecer = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.btnAbrirProceso = new System.Windows.Forms.Button();
            this.mnuFrmPrincipal = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuActivados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tstHerramientas = new System.Windows.Forms.ToolStrip();
            this.tstbGestion = new System.Windows.Forms.ToolStripButton();
            this.tstbProceso = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbSalir = new System.Windows.Forms.ToolStripButton();
            this.btnAbrirTareas = new System.Windows.Forms.Button();
            this.cmnuTxtMensaje1.SuspendLayout();
            this.mnuFrmPrincipal.SuspendLayout();
            this.tstHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirGestion
            // 
            this.btnAbrirGestion.AutoSize = true;
            this.btnAbrirGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirGestion.Location = new System.Drawing.Point(615, 76);
            this.btnAbrirGestion.Name = "btnAbrirGestion";
            this.btnAbrirGestion.Size = new System.Drawing.Size(118, 30);
            this.btnAbrirGestion.TabIndex = 0;
            this.btnAbrirGestion.Text = "Abrir Gestión";
            this.btnAbrirGestion.UseVisualStyleBackColor = true;
            this.btnAbrirGestion.Click += new System.EventHandler(this.btnAbrirGestion_Click);
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.ContextMenuStrip = this.cmnuTxtMensaje1;
            this.txtMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje1.Location = new System.Drawing.Point(65, 78);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(232, 26);
            this.txtMensaje1.TabIndex = 1;
            // 
            // cmnuTxtMensaje1
            // 
            this.cmnuTxtMensaje1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuTxtMensaje1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuAzul,
            this.cmnuAmarillo,
            this.cmnuRestablecer});
            this.cmnuTxtMensaje1.Name = "cmnuTxtMensaje1";
            this.cmnuTxtMensaje1.Size = new System.Drawing.Size(156, 76);
            // 
            // cmnuAzul
            // 
            this.cmnuAzul.Name = "cmnuAzul";
            this.cmnuAzul.Size = new System.Drawing.Size(155, 24);
            this.cmnuAzul.Text = "Azul";
            this.cmnuAzul.Click += new System.EventHandler(this.cmnuAzul_Click);
            // 
            // cmnuAmarillo
            // 
            this.cmnuAmarillo.Name = "cmnuAmarillo";
            this.cmnuAmarillo.Size = new System.Drawing.Size(155, 24);
            this.cmnuAmarillo.Text = "Amarillo";
            this.cmnuAmarillo.Click += new System.EventHandler(this.cmnuAmarillo_Click);
            // 
            // cmnuRestablecer
            // 
            this.cmnuRestablecer.Name = "cmnuRestablecer";
            this.cmnuRestablecer.Size = new System.Drawing.Size(155, 24);
            this.cmnuRestablecer.Text = "Restablecer";
            this.cmnuRestablecer.Click += new System.EventHandler(this.cmnuRestablecer_Click);
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje2.Location = new System.Drawing.Point(65, 134);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(232, 26);
            this.txtMensaje2.TabIndex = 2;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(61, 192);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(121, 20);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // btnAbrirProceso
            // 
            this.btnAbrirProceso.AutoSize = true;
            this.btnAbrirProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirProceso.Location = new System.Drawing.Point(615, 130);
            this.btnAbrirProceso.Name = "btnAbrirProceso";
            this.btnAbrirProceso.Size = new System.Drawing.Size(122, 30);
            this.btnAbrirProceso.TabIndex = 4;
            this.btnAbrirProceso.Text = "Abrir Proceso";
            this.btnAbrirProceso.UseVisualStyleBackColor = true;
            this.btnAbrirProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // mnuFrmPrincipal
            // 
            this.mnuFrmPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuFrmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmPrincipal.Name = "mnuFrmPrincipal";
            this.mnuFrmPrincipal.Size = new System.Drawing.Size(800, 28);
            this.mnuFrmPrincipal.TabIndex = 5;
            this.mnuFrmPrincipal.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestion,
            this.mnuProceso,
            this.MnuActivados,
            this.toolStripSeparator1,
            this.mnuSalir});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mnuGestion
            // 
            this.mnuGestion.AutoToolTip = true;
            this.mnuGestion.Name = "mnuGestion";
            this.mnuGestion.Size = new System.Drawing.Size(171, 26);
            this.mnuGestion.Text = "Gestión";
            this.mnuGestion.ToolTipText = "Abrir formulario de gestión";
            this.mnuGestion.Click += new System.EventHandler(this.btnAbrirGestion_Click);
            // 
            // mnuProceso
            // 
            this.mnuProceso.Name = "mnuProceso";
            this.mnuProceso.Size = new System.Drawing.Size(171, 26);
            this.mnuProceso.Text = "Proceso";
            this.mnuProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // MnuActivados
            // 
            this.MnuActivados.Checked = true;
            this.MnuActivados.CheckOnClick = true;
            this.MnuActivados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuActivados.Name = "MnuActivados";
            this.MnuActivados.Size = new System.Drawing.Size(171, 26);
            this.MnuActivados.Text = "Activados";
            this.MnuActivados.CheckedChanged += new System.EventHandler(this.activadosToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSalir.Size = new System.Drawing.Size(171, 26);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izquierdaToolStripMenuItem,
            this.derechaToolStripMenuItem,
            this.arribaToolStripMenuItem,
            this.abajoToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opción1ToolStripMenuItem,
            this.opción2ToolStripMenuItem});
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.opción1ToolStripMenuItem.Text = "Opción1";
            // 
            // opción2ToolStripMenuItem
            // 
            this.opción2ToolStripMenuItem.Name = "opción2ToolStripMenuItem";
            this.opción2ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.opción2ToolStripMenuItem.Text = "Opción2";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Enabled = false;
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.derechaToolStripMenuItem.Text = "Derecha";
            // 
            // arribaToolStripMenuItem
            // 
            this.arribaToolStripMenuItem.Name = "arribaToolStripMenuItem";
            this.arribaToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.arribaToolStripMenuItem.Text = "Arriba";
            // 
            // abajoToolStripMenuItem
            // 
            this.abajoToolStripMenuItem.Name = "abajoToolStripMenuItem";
            this.abajoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.abajoToolStripMenuItem.Text = "Abajo";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MnuAcercaDe
            // 
            this.MnuAcercaDe.Name = "MnuAcercaDe";
            this.MnuAcercaDe.Size = new System.Drawing.Size(158, 26);
            this.MnuAcercaDe.Text = "Acerca de";
            this.MnuAcercaDe.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tstHerramientas
            // 
            this.tstHerramientas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbGestion,
            this.tstbProceso,
            this.toolStripSeparator2,
            this.tstbSalir});
            this.tstHerramientas.Location = new System.Drawing.Point(0, 28);
            this.tstHerramientas.Name = "tstHerramientas";
            this.tstHerramientas.Size = new System.Drawing.Size(800, 27);
            this.tstHerramientas.TabIndex = 6;
            this.tstHerramientas.Text = "toolStrip1";
            // 
            // tstbGestion
            // 
            this.tstbGestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbGestion.Image = global::AP16.Properties.Resources.iconfinderGestion;
            this.tstbGestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbGestion.Name = "tstbGestion";
            this.tstbGestion.Size = new System.Drawing.Size(29, 24);
            this.tstbGestion.Text = "Abrir Gestión";
            this.tstbGestion.Click += new System.EventHandler(this.btnAbrirGestion_Click);
            // 
            // tstbProceso
            // 
            this.tstbProceso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbProceso.Image = global::AP16.Properties.Resources.iconfinderProceso;
            this.tstbProceso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbProceso.Name = "tstbProceso";
            this.tstbProceso.Size = new System.Drawing.Size(29, 24);
            this.tstbProceso.Text = "Abrir Proceso";
            this.tstbProceso.Click += new System.EventHandler(this.btnProceso_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tstbSalir
            // 
            this.tstbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbSalir.Image = global::AP16.Properties.Resources.iconfinderSalir;
            this.tstbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbSalir.Name = "tstbSalir";
            this.tstbSalir.Size = new System.Drawing.Size(29, 24);
            this.tstbSalir.Text = "Salir";
            this.tstbSalir.Click += new System.EventHandler(this.tstbSalir_Click);
            // 
            // btnAbrirTareas
            // 
            this.btnAbrirTareas.AutoSize = true;
            this.btnAbrirTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirTareas.Location = new System.Drawing.Point(615, 187);
            this.btnAbrirTareas.Name = "btnAbrirTareas";
            this.btnAbrirTareas.Size = new System.Drawing.Size(122, 30);
            this.btnAbrirTareas.TabIndex = 7;
            this.btnAbrirTareas.Text = "Abrir Tareas";
            this.btnAbrirTareas.UseVisualStyleBackColor = true;
            this.btnAbrirTareas.Click += new System.EventHandler(this.btnAbrirTareas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirTareas);
            this.Controls.Add(this.tstHerramientas);
            this.Controls.Add(this.btnAbrirProceso);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.btnAbrirGestion);
            this.Controls.Add(this.mnuFrmPrincipal);
            this.MainMenuStrip = this.mnuFrmPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Aplicación Principal (inicio)";
            this.cmnuTxtMensaje1.ResumeLayout(false);
            this.mnuFrmPrincipal.ResumeLayout(false);
            this.mnuFrmPrincipal.PerformLayout();
            this.tstHerramientas.ResumeLayout(false);
            this.tstHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirGestion;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Button btnAbrirProceso;
        private System.Windows.Forms.MenuStrip mnuFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuProceso;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem opción1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuActivados;
        private System.Windows.Forms.ContextMenuStrip cmnuTxtMensaje1;
        private System.Windows.Forms.ToolStripMenuItem cmnuAzul;
        private System.Windows.Forms.ToolStripMenuItem cmnuAmarillo;
        private System.Windows.Forms.ToolStripMenuItem cmnuRestablecer;
        private System.Windows.Forms.ToolStrip tstHerramientas;
        private System.Windows.Forms.ToolStripButton tstbGestion;
        private System.Windows.Forms.ToolStripButton tstbProceso;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tstbSalir;
        private System.Windows.Forms.Button btnAbrirTareas;
    }
}

