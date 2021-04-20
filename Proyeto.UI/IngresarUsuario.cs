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
    public partial class IngresarUsuario : Form
    {
        private Usuarios user;
        private Principal volver;
        public IngresarUsuario()
        {
            InitializeComponent();
        }

        public IngresarUsuario(Usuarios obj)
        {
            InitializeComponent();
            this.user = obj;
           
        }
        private void btnCancelarUsu_Click(object sender, EventArgs e)
        {

            volver = new Principal();
            volver.Show();
            this.Close();
            limpiar();
        }

        private void btnAgregarUsu_Click(object sender, EventArgs e)
        {
            agregarUsuario();
        }
        private void agregarUsuario()
        {
            try
            {
                user = new Usuarios(this.txtNombreUsu.Text, this.txtCedulaUsu.Text, this.dtpAnacimiento.Value, this.cmbPerfil.Text,
                this.txtUsuarioUs.Text, this.txtClaveUsu.Text);

                Gestor.agregarUsuario(user);

                MessageBox.Show("Usuario agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            public void limpiar()
        {
            this.txtNombreUsu.Clear();
            this.txtCedulaUsu.Clear();
            this.txtUsuarioUs.Clear();
            this.txtClaveUsu.Clear();
         
            this.cmbPerfil.SelectedIndex = -1;
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
          user = new Usuarios(this.txtNombreUsu.Text, this.txtCedulaUsu.Text, this.dtpAnacimiento.Value, this.cmbPerfil.Text,
             this.txtUsuarioUs.Text, this.txtClaveUsu.Text);

        }
    }

    
}
