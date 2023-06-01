using PPAI.Entidades;
using PPAI.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Interfaces_de_Usuario
{
    public partial class frmPantallaPrinCoord : Form
    {
        public frmPantallaPrinCoord()
        {
            
            InitializeComponent();

        }

        private void frmPantallaPrinCoord_Load(object sender, EventArgs e)
        {
            var login = new frmLogin(this);
            this.Hide();
            login.ShowDialog();
        }

        private void btnConsultarEncuestas_Click(object sender, EventArgs e)
        {
            frmPantallaConsulEnc pantalla = new frmPantallaConsulEnc(this);
            pantalla.Show();
            this.Hide();
            
        }

        private void frmPantallaPrinCoord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
