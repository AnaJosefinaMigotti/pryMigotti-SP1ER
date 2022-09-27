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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes objClientes = new frmClientes();
            objClientes.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente objConsultaClientes = new frmConsultaCliente();
            objConsultaClientes.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedores objVendedores = new frmVendedores();
            objVendedores.ShowDialog();
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVendedores objConsultaVendedores = new frmConsultaVendedores();
            objConsultaVendedores.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas objVentas = new frmVentas();
            objVentas.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVentas objConsultasVentas = new frmConsultaVentas();
            objConsultasVentas.ShowDialog();
        }
    }
}
