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
    public partial class AcercaDe : Form
    {
        private Principal volver;
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            volver = new Principal();
            volver.Show();
            this.Close();
        }
    }
}
