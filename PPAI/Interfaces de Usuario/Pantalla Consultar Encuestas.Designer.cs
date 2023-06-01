namespace PPAI.Interfaces_de_Usuario
{
    partial class frmPantallaConsulEnc
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLlamadasEncontradas = new System.Windows.Forms.Label();
            this.cmbLlamadasAMostrar = new System.Windows.Forms.ComboBox();
            this.lblMostrarDatosLlamada = new System.Windows.Forms.Label();
            this.cbImprimir = new System.Windows.Forms.CheckBox();
            this.cbCSV = new System.Windows.Forms.CheckBox();
            this.lblFormaVisualizacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(173, 26);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(173, 92);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 0;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(36, 32);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(36, 92);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 2;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(663, 302);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(55, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblLlamadasEncontradas
            // 
            this.lblLlamadasEncontradas.AutoSize = true;
            this.lblLlamadasEncontradas.Location = new System.Drawing.Point(36, 167);
            this.lblLlamadasEncontradas.Name = "lblLlamadasEncontradas";
            this.lblLlamadasEncontradas.Size = new System.Drawing.Size(115, 13);
            this.lblLlamadasEncontradas.TabIndex = 5;
            this.lblLlamadasEncontradas.Text = "Llamadas Encontradas";
            this.lblLlamadasEncontradas.Visible = false;
            // 
            // cmbLlamadasAMostrar
            // 
            this.cmbLlamadasAMostrar.FormattingEnabled = true;
            this.cmbLlamadasAMostrar.Location = new System.Drawing.Point(173, 158);
            this.cmbLlamadasAMostrar.Name = "cmbLlamadasAMostrar";
            this.cmbLlamadasAMostrar.Size = new System.Drawing.Size(300, 21);
            this.cmbLlamadasAMostrar.TabIndex = 6;
            this.cmbLlamadasAMostrar.Visible = false;
            this.cmbLlamadasAMostrar.SelectedIndexChanged += new System.EventHandler(this.cmbLlamadasAMostrar_SelectedIndexChanged);
            // 
            // lblMostrarDatosLlamada
            // 
            this.lblMostrarDatosLlamada.AutoSize = true;
            this.lblMostrarDatosLlamada.Location = new System.Drawing.Point(539, 26);
            this.lblMostrarDatosLlamada.Name = "lblMostrarDatosLlamada";
            this.lblMostrarDatosLlamada.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarDatosLlamada.TabIndex = 7;
            this.lblMostrarDatosLlamada.Text = "label1";
            this.lblMostrarDatosLlamada.Visible = false;
            this.lblMostrarDatosLlamada.Click += new System.EventHandler(this.lblMostrarDatosLlamada_Click);
            // 
            // cbImprimir
            // 
            this.cbImprimir.AutoSize = true;
            this.cbImprimir.Location = new System.Drawing.Point(542, 160);
            this.cbImprimir.Name = "cbImprimir";
            this.cbImprimir.Size = new System.Drawing.Size(61, 17);
            this.cbImprimir.TabIndex = 9;
            this.cbImprimir.Text = "Imprimir";
            this.cbImprimir.UseVisualStyleBackColor = true;
            this.cbImprimir.Visible = false;
            this.cbImprimir.CheckedChanged += new System.EventHandler(this.cbImprimir_CheckedChanged);
            // 
            // cbCSV
            // 
            this.cbCSV.AutoSize = true;
            this.cbCSV.Location = new System.Drawing.Point(542, 183);
            this.cbCSV.Name = "cbCSV";
            this.cbCSV.Size = new System.Drawing.Size(47, 17);
            this.cbCSV.TabIndex = 10;
            this.cbCSV.Text = "CSV";
            this.cbCSV.UseVisualStyleBackColor = true;
            this.cbCSV.Visible = false;
            this.cbCSV.CheckedChanged += new System.EventHandler(this.cbCSV_CheckedChanged);
            // 
            // lblFormaVisualizacion
            // 
            this.lblFormaVisualizacion.AutoSize = true;
            this.lblFormaVisualizacion.Location = new System.Drawing.Point(542, 126);
            this.lblFormaVisualizacion.Name = "lblFormaVisualizacion";
            this.lblFormaVisualizacion.Size = new System.Drawing.Size(117, 13);
            this.lblFormaVisualizacion.TabIndex = 11;
            this.lblFormaVisualizacion.Text = "Forma de visualizacion:";
            this.lblFormaVisualizacion.Visible = false;
            // 
            // frmPantallaConsulEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 362);
            this.Controls.Add(this.lblFormaVisualizacion);
            this.Controls.Add(this.cbCSV);
            this.Controls.Add(this.cbImprimir);
            this.Controls.Add(this.lblMostrarDatosLlamada);
            this.Controls.Add(this.cmbLlamadasAMostrar);
            this.Controls.Add(this.lblLlamadasEncontradas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Name = "frmPantallaConsulEnc";
            this.Text = "Pantalla_Consultar_Encuestas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPantallaConsulEnc_FormClosing);
            this.Load += new System.EventHandler(this.frmPantallaConsulEnc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblLlamadasEncontradas;
        private System.Windows.Forms.ComboBox cmbLlamadasAMostrar;
        private System.Windows.Forms.Label lblMostrarDatosLlamada;
        private System.Windows.Forms.CheckBox cbImprimir;
        private System.Windows.Forms.CheckBox cbCSV;
        private System.Windows.Forms.Label lblFormaVisualizacion;
    }
}