using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionGestionClientesCSV
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void vendedorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agrearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarClientes frmCargarClientes = new frmCargarClientes();
            frmCargarClientes.ShowDialog();
        }
    }
}
