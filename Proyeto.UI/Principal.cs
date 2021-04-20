using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto.UI
{
    public partial class Principal : Form

    {
        private Login Ingresar;
        private AgregarReservacion AgregarHabitacion;
        private MostrarReservacion ShowReservation;
        private IngresarUsuario AddUsuario;
        private MostrarUsuario ShowUser;
        private AcercaDe About;

        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddUsuario = null;
            ShowUser = null;
            AgregarHabitacion = null;
            ShowReservation = null;
            Application.Exit();
        }

        private void ingresarConOtroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsuario = null;
            ShowUser = null;
            AgregarHabitacion = null;
            ShowReservation = null;
            Ingresar = new Login();
            Ingresar.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarHabitacion = new AgregarReservacion();
            AgregarHabitacion.Show();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUsuario = new IngresarUsuario();
            AddUsuario.Show();
            this.Close();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReservation= new MostrarReservacion();
            ShowReservation.Show();
            this.Close();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowUser = new MostrarUsuario();
            ShowUser.Show();
            this.Close();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About = new AcercaDe();
            About.Show();
            this.Close();
        }
    }
}
