using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryCarrionGestionClientesCSV
{
    internal class clsArchivoClientes
    {
        public String filename = "clientes.csv";

        public struct Cliente
        {
            Int32 codigo;

        }

        public void Cargar(String codigoRecibido, String nombreRecibido, String limiteRecibido, String deudaRecibida)
        {
            StreamWriter SW = new StreamWriter(filename, true);

            SW.WriteLine(
                codigoRecibido + ";" +
                nombreRecibido + ";" +
                limiteRecibido + ";" +
                deudaRecibida
            );

            SW.Close();
            SW.Dispose();
        }

        public void Listar(DataGridView dgvListado)
        {
            StreamReader SR = new StreamReader(filename);
            String line;
            String[] lineArray = new String[4];

            dgvListado.Rows.Clear();

            line = SR.ReadLine();

            while (line != null)
            {
                lineArray = line.Split(';');

                dgvListado.Rows.Add(lineArray);

                line = SR.ReadLine();
            }

            SR.Close();
            SR.Dispose();
        }

        public void ObtenerTotalDeuda(Label lblTotalDeuda)
        {
            StreamReader SR = new StreamReader(filename);
            String[] lineArray = new String[4];
            String line;

            Decimal totalDeuda = 0;

            line = SR.ReadLine();

            while (line != null)
            {
                lineArray = line.Split(';');
                totalDeuda += Convert.ToDecimal(lineArray[3]);
                line = SR.ReadLine();
            }

            lblTotalDeuda.Text = "$" + totalDeuda.ToString();

            SR.Close();
            SR.Dispose();
        }

        public void ObtenerCantidadClientes(Label lblCantidadClientes)
        {
            StreamReader SR = new StreamReader(filename);
            String line;
            Int32 cantidadClientes = 0;

            line = SR.ReadLine();

            while (line != null)
            {
                cantidadClientes++;
                line = SR.ReadLine();
            }

            lblCantidadClientes.Text = cantidadClientes.ToString();

            SR.Close();
            SR.Dispose();
        }

        public void ObtenerPromedioDeuda(Label lblPromedioDeuda)
        {
            StreamReader SR = new StreamReader(filename);
            String line;
            String[] lineArray = new String[4];
            Int32 cantidad = 0;
            Decimal totalDeuda = 0;

            line = SR.ReadLine();

            while (line != null)
            {
                lineArray = line.Split(';');
                cantidad++;
                totalDeuda += Convert.ToDecimal(lineArray[3]);
                line = SR.ReadLine();
            }

            Decimal promedio = 0;

            if (cantidad > 0)
            {
                promedio = totalDeuda / cantidad;
            }

            lblPromedioDeuda.Text = "$" + promedio.ToString();

            SR.Close();
            SR.Dispose();
        }
    }
}
