namespace EvaluacionArbolGrafos.Formularios
{
    partial class FrmGrafo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMostrar = new System.Windows.Forms.TextBox();
            this.btnConexiones = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFin = new System.Windows.Forms.TextBox();
            this.btnRutaCorta = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del edificio:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(159, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(208, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(187, 67);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Edificio";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edificio de origen:";
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(170, 135);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(196, 22);
            this.tbOrigen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edificio Destino:";
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(170, 163);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(196, 22);
            this.tbDestino.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Distancia en metros:";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(170, 198);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(196, 22);
            this.tbDistancia.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Edificio:";
            // 
            // tbMostrar
            // 
            this.tbMostrar.Location = new System.Drawing.Point(96, 325);
            this.tbMostrar.Name = "tbMostrar";
            this.tbMostrar.Size = new System.Drawing.Size(130, 22);
            this.tbMostrar.TabIndex = 10;
            // 
            // btnConexiones
            // 
            this.btnConexiones.Location = new System.Drawing.Point(111, 364);
            this.btnConexiones.Name = "btnConexiones";
            this.btnConexiones.Size = new System.Drawing.Size(115, 45);
            this.btnConexiones.TabIndex = 11;
            this.btnConexiones.Text = "Mostrar Conexiones";
            this.btnConexiones.UseVisualStyleBackColor = true;
            this.btnConexiones.Click += new System.EventHandler(this.btnConexiones_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desde:";
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(360, 322);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(125, 22);
            this.tbInicio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasta:";
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(543, 322);
            this.tbFin.Name = "tbFin";
            this.tbFin.Size = new System.Drawing.Size(119, 22);
            this.tbFin.TabIndex = 15;
            // 
            // btnRutaCorta
            // 
            this.btnRutaCorta.Location = new System.Drawing.Point(449, 353);
            this.btnRutaCorta.Name = "btnRutaCorta";
            this.btnRutaCorta.Size = new System.Drawing.Size(121, 45);
            this.btnRutaCorta.TabIndex = 16;
            this.btnRutaCorta.Text = "Calcular ruta mas corta";
            this.btnRutaCorta.UseVisualStyleBackColor = true;
            this.btnRutaCorta.Click += new System.EventHandler(this.btnRutaCorta_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(187, 237);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(142, 30);
            this.btnRuta.TabIndex = 17;
            this.btnRuta.Text = "Agregar Ruta";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnRutaCorta);
            this.Controls.Add(this.tbFin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnConexiones);
            this.Controls.Add(this.tbMostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "FrmGrafo";
            this.Text = "Sistema de rutas del parque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMostrar;
        private System.Windows.Forms.Button btnConexiones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFin;
        private System.Windows.Forms.Button btnRutaCorta;
        private System.Windows.Forms.Button btnRuta;
    }
}