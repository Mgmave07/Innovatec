namespace EvaluacionArbolGrafos
{
    partial class Form1
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.innovatecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jerarquíaOrganizativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaDeRutasDelParqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.innovatecToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // innovatecToolStripMenuItem
            // 
            this.innovatecToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jerarquíaOrganizativaToolStripMenuItem,
            this.sistemaDeRutasDelParqueToolStripMenuItem});
            this.innovatecToolStripMenuItem.Name = "innovatecToolStripMenuItem";
            this.innovatecToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.innovatecToolStripMenuItem.Text = "Innovatec";
            // 
            // jerarquíaOrganizativaToolStripMenuItem
            // 
            this.jerarquíaOrganizativaToolStripMenuItem.Name = "jerarquíaOrganizativaToolStripMenuItem";
            this.jerarquíaOrganizativaToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.jerarquíaOrganizativaToolStripMenuItem.Text = "Jerarquía Organizativa ";
            this.jerarquíaOrganizativaToolStripMenuItem.Click += new System.EventHandler(this.jerarquíaOrganizativaToolStripMenuItem_Click);
            // 
            // sistemaDeRutasDelParqueToolStripMenuItem
            // 
            this.sistemaDeRutasDelParqueToolStripMenuItem.Name = "sistemaDeRutasDelParqueToolStripMenuItem";
            this.sistemaDeRutasDelParqueToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.sistemaDeRutasDelParqueToolStripMenuItem.Text = " Sistema de Rutas del Parque ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Innovatec";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem innovatecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jerarquíaOrganizativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaDeRutasDelParqueToolStripMenuItem;
    }
}

