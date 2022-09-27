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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            //booleano v/f
            //para que el número de identificación no se repita
            bool Repetido = false;
            if (File.Exists("./Clientes.txt"))
            {
                StreamReader IDControl = new StreamReader("./Clientes.txt");
                while (!IDControl.EndOfStream)
                {
                    string varIDCliente = IDControl.ReadLine();
                    //split(,) para separar los datos que se encuentran el archivo
                    string[] Clientes = varIDCliente.Split(',');

                    //si el número por registrar coincide con la primera posición
                    //del vector creado anteriormente no podrá ser guardado
                    if (mtbIdentificacionClientes.Text == Clientes[0])
                    {
                        MessageBox.Show("El número ingresado ya ha sido registrado.");
                        mtbIdentificacionClientes.Text = "";
                        txtNombreCliente.Text = "";
                        //focus para q quede seleccionada la masked
                        mtbIdentificacionClientes.Focus();
                        Repetido = true;
                    }
                }
                IDControl.Close();
            }
            if (Repetido == false)
            {
                StreamWriter DatosClientes = new StreamWriter("./Clientes.txt", true);
                DatosClientes.WriteLine(mtbIdentificacionClientes.Text + "," + txtNombreCliente.Text);
                MessageBox.Show("Los datos del cliente han sido registrados con éxito");
                DatosClientes.Close();
                mtbIdentificacionClientes.Text = "";
                txtNombreCliente.Text = "";
                //focus para q quede seleccionada la masked
                mtbIdentificacionClientes.Focus();
            }

        }
    }
}
