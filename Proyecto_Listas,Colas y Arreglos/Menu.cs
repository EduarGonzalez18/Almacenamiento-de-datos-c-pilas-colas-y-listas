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
    public partial class Menu : Form
    {
        private DialogResult resultado;

        public Menu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPila_Click(object sender, EventArgs e)
        {

            Pila pila = new Pila();
            pila.ShowDialog();
           

        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            Cola cola = new Cola();
            cola.ShowDialog();
            




        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

           DialogResult = resultado;
            resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Validacion",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            
            if (resultado == DialogResult.Yes)
            {

                Application.Exit();

            }


        }

        private void Lista_Click(object sender, EventArgs e)
        {

            Lista lista = new Lista();

            lista.ShowDialog();



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
