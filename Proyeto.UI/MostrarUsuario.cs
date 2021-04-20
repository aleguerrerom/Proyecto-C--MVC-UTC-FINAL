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
    public partial class MostrarUsuario : Form
    {
        private Principal volver;
        public MostrarUsuario()
        {
            InitializeComponent();
        }

        private void MostrarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMostrar.DataSource = Gestor.mostrarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            volver = new Principal();
            volver.Show();
            this.Close();
        }
    }
}
