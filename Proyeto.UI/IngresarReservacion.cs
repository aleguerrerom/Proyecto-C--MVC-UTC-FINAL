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
    public partial class AgregarReservacion : Form
    {
        private Reservacion reservation;
        private Principal volver;
        public AgregarReservacion()
        {
            InitializeComponent();
        }

        public AgregarReservacion(Reservacion obj)
        {
            InitializeComponent();
            this.reservation = obj;
            // cargar los datos del funcionario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            volver = new Principal();
            volver.Show();
            this.Close();
            limpiar();

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            agregarReservacion();
        }

        private void agregarReservacion()
        {
            try
            {
                reservation = new Reservacion(this.txtCedulaHab.Text, this.txtNombreHab.Text, this.cmbMetPago.Text, this.txtNumHabitacion.Text,
                Convert.ToDouble(this.txtDias.Text), this.dtpReserva.Value,this.cmbAdicional.Text/*, Convert.ToDouble(this.txtPagoFinal.Text)*/);
                
                Gestor.agregarReservacion(reservation);

                MessageBox.Show("Reservacion agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            this.txtNombreHab.Clear();
            this.txtCedulaHab.Clear();
            this.ss = null;
            this.txtNumHabitacion.Clear();
            this.cmbAdicional.SelectedIndex = -1;
            this.cmbMetPago.SelectedIndex = -1;
        
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDias.Text))
                {
                // reservation = new Reservacion(this.txtCedulaHab.Text, this.txtNombreHab.Text,this.cmbMetPago.Text, this.txtNumHabitacion.Text,
                // Convert.ToDouble(this.txtDias.Text), this.dtpReserva.Value, this.cmbAdicional.Text, Convert.ToDouble(this.txtPagoFinal.Text));

                    txtPagoFinal.Text = Convert.ToString(reservation.CostoFinal);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
