using PPAI.Entidades;
using PPAI.Interfaces_de_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{

    public partial class frmLogin : Form
    {

        private readonly frmPantallaPrinCoord menuEste;
        private Usuario usuario;

        public frmLogin(frmPantallaPrinCoord menu)
        {
            menuEste = menu;
            InitializeComponent();
            usuario = new Usuario("", "");
        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuario.ValidarUsuario(txtNombre.Text.ToLower() , txtClave.Text))
            {
                MessageBox.Show("Bienvenido Coordinador");
                this.Dispose();
                menuEste.Show();


            }
            else
            {
                MessageBox.Show("El usuario ingresado es incorrecto");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

    }


}
