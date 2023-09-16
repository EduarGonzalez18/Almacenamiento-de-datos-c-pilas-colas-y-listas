using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    public partial class Pila : Form


    {
        private DialogResult resultado;

        Stack<PilaClientes> MiPilaCliente = new Stack<PilaClientes>();

        public Pila()
        {
            InitializeComponent();
            dateTimeAfiliacion.CustomFormat = "MMMM";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

           




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSueldo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DataGridPila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            //Filtros para los datos
            

            if (txtIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("¿Debe ingresar su identificación", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProviderPila.SetError(txtIdentificacion, "Ingrese su identificación");
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                return;

            }
            errorProviderPila.SetError(txtIdentificacion, "");

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("¿Debe ingresar su nombre", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProviderPila.SetError(txtNombre, "Ingrese su nombre");
                txtNombre.Clear();
                txtNombre.Focus();
                return;

            }
            errorProviderPila.SetError(txtNombre, "");



            if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("¿Debe ingresar su direccion", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                errorProviderPila.SetError(txtDireccion, "Ingrese su direccion");
                txtDireccion.Clear();
                txtDireccion.Focus();
                return;

            }
            errorProviderPila.SetError(txtDireccion, "");


            // filtros para los combobox

          


            if (ValidarCategoria() == false)
            {
                   
                return;
            }

            if (ValidarEstrato() == false)
            {
                return;
            }

            if (ValidarGenero() == false)
            {
                return;
            }

            if (ValidarMegas() == false)
            {
                return;
            }




            // Registrar datos

         

            PilaClientes miPilaClientes = new PilaClientes();
            miPilaClientes.Identificacion = this.txtIdentificacion.Text;
            miPilaClientes.Nombre = this.txtNombre.Text;
            miPilaClientes.Direccion = this.txtDireccion.Text;
            miPilaClientes.Estrato = int.Parse(this.cmbEstrato.Text);
            miPilaClientes.Genero = this.cmbGenero.Text;
            miPilaClientes.MesDeAfiliacion = dateTimeAfiliacion.Value;
            miPilaClientes.categoria = this.cmbCategoria.Text;
            miPilaClientes.CanalMegas = this.cmbCanal.Text;
            miPilaClientes.ValorTotal = miPilaClientes.ValorTotalApagar();


            txtValorTotal.Text = miPilaClientes.ValorTotalApagar().ToString();
             MiPilaCliente.Push(miPilaClientes);
            DataGridPila.DataSource = null;
            DataGridPila.DataSource = MiPilaCliente.ToArray();
            MessageBox.Show(" Registro exitoso");
            btnRegistrar.Enabled = true;
            LimpiarControles();

           




        }

       



        ////////////////////////////// METODOS DE VALICAION DE CAMPOS//////////////////////////
        private bool ValidarCategoria()
        {
            if (string.IsNullOrEmpty(cmbCategoria.Text))
            {
                errorProviderPila.SetError(cmbCategoria, "Debe ingresar una Categoria");
                cmbCategoria.Focus();
                MessageBox.Show("¿Debe ingresar una Categoría", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderPila.SetError(cmbCategoria,"");
                return true;
            }
        }




        private bool ValidarEstrato()
        {
            int edad;
            if (!int.TryParse(cmbEstrato.Text,out edad) || cmbEstrato.Text== "")
            {
                errorProviderPila.SetError(cmbEstrato, "Debe ingresar un estrato");
                MessageBox.Show("¿Debe ingresar su Estrato", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderPila.SetError(cmbEstrato, "");
                return true;
            }
        }






        private bool ValidarGenero()
        {
           
            if (string.IsNullOrEmpty(cmbGenero.Text))
            {
              errorProviderPila.SetError(cmbGenero, "Debe ingresar un genero");
                MessageBox.Show("¿Debe ingresar su Estrato", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderPila.SetError(cmbGenero, "");
                return true;
            }

        }


        private bool ValidarMegas()
        {
            if (string.IsNullOrEmpty(cmbCanal.Text))
            {
                errorProviderPila.SetError(cmbCanal, "Debe ingresar un la cantidad de megas Contratadas");
                MessageBox.Show("¿Ingrese el canal de megas Contratadas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderPila.SetError(cmbCanal, "");
                return true;
            }

        }








        // Boton de eliminar
        private void button1_Click(object sender, EventArgs e)
        {
            // Metodo para eliminar registros de la pila
          //  DialogResult = resultado;
            resultado = MessageBox.Show("¿Desea Eliminar un registro", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (MiPilaCliente.Count != 0)
                {
                    PilaClientes miPilaClientes = new PilaClientes();


                    // Envair valores a la clase Pila Cliente
                    miPilaClientes = MiPilaCliente.Pop();
                    txtIdentificacion.Text = miPilaClientes.Identificacion.ToString();
                    txtNombre.Text = miPilaClientes.Nombre.ToString();
                    txtDireccion.Text = miPilaClientes.Direccion.ToString();
                    cmbEstrato.Text = miPilaClientes.Estrato.ToString();
                    cmbGenero.Text = miPilaClientes.Genero.ToString();
                    cmbCategoria.Text = miPilaClientes.categoria.ToString();
                    cmbCanal.Text = miPilaClientes.CanalMegas.ToString();
                    txtValorTotal.Text = miPilaClientes.ValorTotal.ToString();
                    DataGridPila.DataSource = MiPilaCliente.ToArray();
                    LimpiarControles();

                   
                }
                else
                {

                    MessageBox.Show("La cola esta vacia");
                    LimpiarControles();

                }

            }

         

        }

        // Metodo para limpiar los controles

        public void LimpiarControles()
        {

            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtValorTotal.Clear();
            cmbCanal.Text = "";
            cmbCategoria.Text = "";
            cmbEstrato.Text = "";
            dateTimeAfiliacion.Value = DateTime.Now;
            cmbGenero.Text = "";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult = resultado;
            resultado = MessageBox.Show("¿Desea regresar al Menú?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {

                this.Hide();

            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Metodo para validar la identificacion con solo numeros
        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != 8 && e.KeyChar != 127
                && e.KeyChar != 32) e.Handled = true;


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122))
              && e.KeyChar != 8 && e.KeyChar != 127 && e.KeyChar != 32) e.Handled = true;

        }
    }
}
