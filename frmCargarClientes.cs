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
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }

        clsArchivoClientes clsArchivoClientes = new clsArchivoClientes();

        private void frmCargarClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            clsArchivoClientes.Cargar(txtCodigo.Text, txtNombre.Text, txtLimite.Text, txtDeuda.Text);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtLimite.Clear();
            txtDeuda.Clear();

            MessageBox.Show("Cliente cargado con exito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
