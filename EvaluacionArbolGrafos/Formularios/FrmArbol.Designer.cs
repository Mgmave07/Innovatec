namespace EvaluacionArbolGrafos.Formularios
{
    partial class FrmArbol
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
            this.tvOrganizacion = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarSubNodo = new System.Windows.Forms.Button();
            this.btnPreorden = new System.Windows.Forms.Button();
            this.btnPosOrden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnContarNodo = new System.Windows.Forms.Button();
            this.btnNivelNodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvOrganizacion
            // 
            this.tvOrganizacion.Location = new System.Drawing.Point(12, 12);
            this.tvOrganizacion.Name = "tvOrganizacion";
            this.tvOrganizacion.Size = new System.Drawing.Size(275, 192);
            this.tvOrganizacion.TabIndex = 0;
            this.tvOrganizacion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOrganizacion_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nodo seleccionado:";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.Location = new System.Drawing.Point(446, 27);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(145, 23);
            this.lblSeleccionado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo nombre:";
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(418, 83);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(155, 22);
            this.tbNuevoNombre.TabIndex = 4;
            // 
            // btnAgregarSubNodo
            // 
            this.btnAgregarSubNodo.Location = new System.Drawing.Point(407, 128);
            this.btnAgregarSubNodo.Name = "btnAgregarSubNodo";
            this.btnAgregarSubNodo.Size = new System.Drawing.Size(116, 47);
            this.btnAgregarSubNodo.TabIndex = 5;
            this.btnAgregarSubNodo.Text = "Agregar subnodo";
            this.btnAgregarSubNodo.UseVisualStyleBackColor = true;
            this.btnAgregarSubNodo.Click += new System.EventHandler(this.btnAgregarSubNodo_Click);
            // 
            // btnPreorden
            // 
            this.btnPreorden.Location = new System.Drawing.Point(33, 210);
            this.btnPreorden.Name = "btnPreorden";
            this.btnPreorden.Size = new System.Drawing.Size(168, 36);
            this.btnPreorden.TabIndex = 6;
            this.btnPreorden.Text = "PreOrden";
            this.btnPreorden.UseVisualStyleBackColor = true;
            this.btnPreorden.Click += new System.EventHandler(this.btnPreorden_Click);
            // 
            // btnPosOrden
            // 
            this.btnPosOrden.Location = new System.Drawing.Point(33, 252);
            this.btnPosOrden.Name = "btnPosOrden";
            this.btnPosOrden.Size = new System.Drawing.Size(168, 36);
            this.btnPosOrden.TabIndex = 7;
            this.btnPosOrden.Text = "PostOrden";
            this.btnPosOrden.UseVisualStyleBackColor = true;
            this.btnPosOrden.Click += new System.EventHandler(this.btnPosOrden_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(372, 235);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 22);
            this.tbBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(516, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 22);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnContarNodo
            // 
            this.btnContarNodo.Location = new System.Drawing.Point(33, 294);
            this.btnContarNodo.Name = "btnContarNodo";
            this.btnContarNodo.Size = new System.Drawing.Size(168, 36);
            this.btnContarNodo.TabIndex = 11;
            this.btnContarNodo.Text = "Contar Nodos";
            this.btnContarNodo.UseVisualStyleBackColor = true;
            this.btnContarNodo.Click += new System.EventHandler(this.btnContarNodo_Click);
            // 
            // btnNivelNodo
            // 
            this.btnNivelNodo.Location = new System.Drawing.Point(33, 336);
            this.btnNivelNodo.Name = "btnNivelNodo";
            this.btnNivelNodo.Size = new System.Drawing.Size(168, 36);
            this.btnNivelNodo.TabIndex = 12;
            this.btnNivelNodo.Text = "Nivel Nodo";
            this.btnNivelNodo.UseVisualStyleBackColor = true;
            this.btnNivelNodo.Click += new System.EventHandler(this.btnNivelNodo_Click);
            // 
            // FrmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.btnNivelNodo);
            this.Controls.Add(this.btnContarNodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPosOrden);
            this.Controls.Add(this.btnPreorden);
            this.Controls.Add(this.btnAgregarSubNodo);
            this.Controls.Add(this.tbNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvOrganizacion);
            this.Name = "FrmArbol";
            this.Text = "Jerarquía Organizativa ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvOrganizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Button btnAgregarSubNodo;
        private System.Windows.Forms.Button btnPreorden;
        private System.Windows.Forms.Button btnPosOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnContarNodo;
        private System.Windows.Forms.Button btnNivelNodo;
    }
}