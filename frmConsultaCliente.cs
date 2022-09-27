using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMigotti_SP1ER
{
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btnSalirCClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCClientes_Click(object sender, EventArgs e)
        {
            dgvConsultaCliente.Rows.Clear();
        }

        private void btnListarCClientes_Click(object sender, EventArgs e)
        {
            StreamReader Clientes = new StreamReader("./Clientes.txt");
            while (!Clientes.EndOfStream)
            {
                string DatoCliente = Clientes.ReadLine();
                string[] vecDatosCliente = DatoCliente.Split(',');
                dgvConsultaCliente.Rows.Add(vecDatosCliente[0], vecDatosCliente[1]);
            }
            Clientes.Close();
        }
    }
}
