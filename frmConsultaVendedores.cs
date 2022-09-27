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
    public partial class frmConsultaVendedores : Form
    {
        public frmConsultaVendedores()
        {
            InitializeComponent();
        }

        private void btnSalirCVendedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCVendedores_Click(object sender, EventArgs e)
        {
            dgvConsultaVendedor.Rows.Clear();
        }

        private void btnListarCVendedor_Click(object sender, EventArgs e)
        {
            StreamReader Vendedores = new StreamReader("./Vendedores.txt");
            while (!Vendedores.EndOfStream)
            {
                string DatoVendedor = Vendedores.ReadLine();
                string[] vecDatosVendedor = DatoVendedor.Split(',');
                dgvConsultaVendedor.Rows.Add(vecDatosVendedor[0], vecDatosVendedor[1]);
            }
            Vendedores.Close();
        }
    }
}
