using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Negocios;
namespace Proyeto.UI
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtUsuario.Text != "" && this.txtClave.Text != "")
                {
                Usuarios userlogin = Gestor.validarLogin(this.txtUsuario.Text, this.txtClave.Text);
                    Principal inicio = new Principal();
                   inicio.statusUsuario.Text = "Usuario: " + this.txtUsuario.Text;
                    inicio.Show();
                    this.Hide();
                }
                else MessageBox.Show("Debe llenar todos los campos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
