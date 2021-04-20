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
    public partial class MostrarReservacion : Form
    {
        private Principal volver;
        public MostrarReservacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            volver = new Principal();
            volver.Show();
            this.Close();
        }

        private void MostrarReservacion_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMostrarReservacion.DataSource = Gestor.mostrarReservacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
