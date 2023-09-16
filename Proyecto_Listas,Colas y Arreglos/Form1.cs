using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    public partial class frmLogin : Form
    {
 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            double clave = 0;
            //  clave = this.txtContraseña.Text.Trim();


            decimal identificacion;


            if (!decimal.TryParse(txtContraseña.Text, out identificacion))
            {
                MessageBox.Show("Ingrese una contraseña");
                ErrorProviderInicioSesion.SetError(txtContraseña, "Contraseña incorrecta");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;


            }



            if ((txtContraseña.Text.Equals("") || txtContraseña.Text != "123")){
                MessageBox.Show("Contrasela invalida");
                ErrorProviderInicioSesion.SetError(txtContraseña, "Ingrese una contraseña valida");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;

            }

            else {

                Menu menu = new Menu();
                menu.ShowDialog();
                this.Hide();
                
            
            }

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != 8 && e.KeyChar != 127
               && e.KeyChar != 32) e.Handled = true;

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
