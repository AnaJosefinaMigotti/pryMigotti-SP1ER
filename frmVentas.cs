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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnSalirVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //agrego a las listas desplegables los datos
            //que transcribí anteriormente en el archivo .txt

            //primero con los datos de los clientes
            StreamReader IDCliente = new StreamReader("./Clientes.txt");
            while (!IDCliente.EndOfStream)
            {
                string varIDCliente = IDCliente.ReadLine();
                //agrego los datos a un vector y los separo usando split(,)
                string[] vIDCliente = varIDCliente.Split(',');
                //muestro en la lista desplegable los datos q ingresé en
                //el vector en la posición 0
                lstCliente.Items.Add(vIDCliente[0]);
            }
            IDCliente.Close();

            //igual pero con los datos de los vendedores
            StreamReader IDVendedor = new StreamReader("./Vendedores.txt");
            while (!IDVendedor.EndOfStream)
            {
                string varIDVendedor = IDVendedor.ReadLine();
                //agrego los datos a un vector y los separo usando split(,)
                string[] vIDVendedor = varIDVendedor.Split(',');
                //muestro en la lista desplegable los datos q ingresé en
                //el vector en la posición 0
                lstVendedor.Items.Add(vIDVendedor[0]);
            }
            IDVendedor.Close();
         
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            StreamWriter Ventas = new StreamWriter("./Ventas.txt", true);
            Ventas.WriteLine(mtbFechasVentas.Text + "," + mtbMontoVentas.Text + "," + lstCliente.SelectedIndex + "," + lstVendedor.SelectedIndex + "," + mtbNFactura.Text + "," + lstTipoFactura.Text);
            MessageBox.Show("Los datos han sido cargado con éxito.");
            Ventas.Close();
            mtbFechasVentas.Text = "";
            mtbMontoVentas.Text = "";
            lstCliente.SelectedIndex = 0;
            lstVendedor.SelectedIndex = 0;
            mtbNFactura.Text = "";
            lstTipoFactura.SelectedIndex = 0;   
            
        }
    }
}
