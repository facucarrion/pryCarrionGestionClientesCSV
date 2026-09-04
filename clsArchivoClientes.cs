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
    }
}
