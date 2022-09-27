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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void btnSalirVendedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistroVendedores_Click(object sender, EventArgs e)
        {
            //booleano v/f
            //para que el número de identificación no se repita
            bool Repetido = false;
            if (File.Exists("./Vendedores.txt"))
            {
                StreamReader IDControl = new StreamReader("./Vendedores.txt");
                while (!IDControl.EndOfStream)
                {
                    string varIDVendedor = IDControl.ReadLine();
                    //split(,) para separar los datos que se encuentran el archivo
                    string[] Vendedor = varIDVendedor.Split(',');

                    //si el número por registrar coincide con la primera posición
                    //del vector creado anteriormente no podrá ser guardado
                    if (mtbIdentificacionVendedores.Text == Vendedor[0])
                    {
                        MessageBox.Show("El número ingresado ya ha sido registrado.");
                        mtbIdentificacionVendedores.Text = "";
                        txtNombreVendedores.Text = "";
                        //focus para q quede seleccionada la masked
                        mtbIdentificacionVendedores.Focus();
                        Repetido = true;
                    }
                }
                IDControl.Close();
            }
            if (Repetido == false)
            {
                StreamWriter DatosClientes = new StreamWriter("./Vendedores.txt", true);
                DatosClientes.WriteLine(mtbIdentificacionVendedores.Text + "," + txtNombreVendedores.Text);
                MessageBox.Show("Los datos del cliente han sido registrados con éxito");
                DatosClientes.Close();
                mtbIdentificacionVendedores.Text = "";
                txtNombreVendedores.Text = "";
                //focus para q quede seleccionada la masked
                mtbIdentificacionVendedores.Focus();
            }
        }
    }
}
