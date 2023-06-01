namespace PPAI.Interfaces_de_Usuario
{
    partial class frmPantallaPrinCoord
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
            this.btnConsultarEncuestas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarEncuestas
            // 
            this.btnConsultarEncuestas.Location = new System.Drawing.Point(274, 119);
            this.btnConsultarEncuestas.Name = "btnConsultarEncuestas";
            this.btnConsultarEncuestas.Size = new System.Drawing.Size(245, 73);
            this.btnConsultarEncuestas.TabIndex = 0;
            this.btnConsultarEncuestas.Text = "Consultar Encuestas";
            this.btnConsultarEncuestas.UseVisualStyleBackColor = true;
            this.btnConsultarEncuestas.Click += new System.EventHandler(this.btnConsultarEncuestas_Click);
            // 
            // frmPantallaPrinCoord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarEncuestas);
            this.Name = "frmPantallaPrinCoord";
            this.Text = "Pantalla_Principal_Coordinador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPantallaPrinCoord_FormClosing);
            this.Load += new System.EventHandler(this.frmPantallaPrinCoord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarEncuestas;
    }
}