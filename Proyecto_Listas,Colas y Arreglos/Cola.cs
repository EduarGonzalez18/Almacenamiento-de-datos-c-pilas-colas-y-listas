using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Listas_Colas_y_Arreglos
{
    public partial class Cola : Form
    {
        private DialogResult resultado;

        Queue <ColaInfraccion> colaInfraccions = new Queue <ColaInfraccion> ();

        public Cola()
        {
            InitializeComponent();
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Boton Registrar


            // Filtros

            if (txtIdentificacion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su indetificación");
                errorProviderCola.SetError(txtIdentificacion, "Ingrese su identificación");
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                return;

            }
            errorProviderCola.SetError(txtIdentificacion, "");

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su Nombre");
                errorProviderCola.SetError(txtNombre, "Ingrese su nombre");
                txtNombre.Clear();
                txtNombre.Focus();
                return;

            }
            errorProviderCola.SetError(txtNombre, "");

            if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su direccion");
                errorProviderCola.SetError(txtDireccion, "Ingrese su direccion");
                txtDireccion.Clear();
                txtDireccion.Focus();
                return;

            }
            errorProviderCola.SetError(txtDireccion, "");


            if (txtPlaca.Text.Equals(""))
            {
                MessageBox.Show("Ingrese la placa del automovil");
                errorProviderCola.SetError(txtPlaca, "Ingrese la placa");
                txtPlaca.Clear();
                txtPlaca.Focus();
                return;
            }
            errorProviderCola.SetError(txtPlaca, "");

            // Filtro para validar campos de tipo caracter o numerico

            decimal identificacion;


            if (!decimal.TryParse(txtIdentificacion.Text, out identificacion))
            {
                MessageBox.Show("Ingrese valores numericos");
                errorProviderCola.SetError(txtIdentificacion, "Ingrese valores numericos");
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                return;


            }
            errorProviderCola.SetError(txtIdentificacion, "");



            // Filtro para el comboBox

            // filtros para los combobox




            if (ValidarTipoAutomotor() == false)
            {

                return;
            }


            // Registro de datos para enviar a la clase ColaInfraccion
            ColaInfraccion colaInfraccion = new ColaInfraccion();

            colaInfraccion.Identificacion = decimal.Parse(txtIdentificacion.Text);
            colaInfraccion.Nombre = txtNombre.Text;
            colaInfraccion.Direccion = txtDireccion.Text;
            colaInfraccion.placa = txtPlaca.Text;
            colaInfraccion.anioMatricula = dateAnioMatricula.Value;
            colaInfraccion.fechaComparendo = dateTimeComparendo.Value;
            //colaInfraccion.DiasExpedicionComparendo = int .Parse(txtDiasExpedicion.Text);
            colaInfraccion.TipoDeAutomotor = cmbTipoAutomotor.Text;
            colaInfraccion.ValorTotal = colaInfraccion.valorApagar();
            txtValorTotal.Text = colaInfraccion.valorApagar().ToString();

         

            // colaInfraccion.ValorTotal = double.Parse(txtValorTotal.Text);
            MessageBox.Show(" Registro exitoso");
            btnRegistrar.Enabled = true;

            // Instancia de la cola : colaInfraccions 

            colaInfraccions.Enqueue(colaInfraccion);
            DataGridCola.DataSource = null;
            DataGridCola.DataSource = colaInfraccions.ToList();

            // Limpiar Campos

            limpiardatos();





        }

        // Metodo para validar el comboBox del tipo de automotor

        private bool ValidarTipoAutomotor()
        {
            if (string.IsNullOrEmpty(cmbTipoAutomotor.Text))
            {
                errorProviderCola.SetError(cmbTipoAutomotor, "Debe ingresar una Categoria");
                cmbTipoAutomotor.Focus();
                MessageBox.Show("¿Debe ingresar una Categoría", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
               errorProviderCola.SetError(cmbTipoAutomotor, "");
                return true;
            }
        }

        public void limpiardatos()

        {   txtIdentificacion.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtPlaca.Clear();
            cmbTipoAutomotor.Text = "";
           // txtDiasExpedicion.Clear();
            txtValorTotal.Clear();
            dateAnioMatricula.Value = DateTime.Now;
            dateTimeComparendo.Value = DateTime.Now;
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

        private void btnEliminar_Click(object sender, EventArgs e)


        {

            resultado = MessageBox.Show("¿Desea Eliminar un registro", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                if (colaInfraccions.Count != 0)
                {

                    ColaInfraccion colaInfraccion = new ColaInfraccion();
                    colaInfraccion = colaInfraccions.Dequeue(); // El metodo dequeu nos permite eliminar los registros de la cola


                    txtIdentificacion.Text = colaInfraccion.Identificacion.ToString();
                    txtNombre.Text = colaInfraccion.Nombre;
                    txtDireccion.Text = colaInfraccion.Direccion;
                    txtPlaca.Text = colaInfraccion.placa;
                    dateAnioMatricula.Value = colaInfraccion.anioMatricula;
                    dateTimeComparendo.Value = colaInfraccion.fechaComparendo;

                    cmbTipoAutomotor.Text = colaInfraccion.TipoDeAutomotor;

                    // Limpiamos el data 
                    DataGridCola.DataSource = colaInfraccions.ToList();
                    MessageBox.Show("Se elimino el registro correctamente");
                    limpiardatos();



                }
                else
                {
                    MessageBox.Show("La cola esta vacia");
                    limpiardatos();

                }
            }



        }

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
