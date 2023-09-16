using System;
using System.Collections;
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
    public partial class Lista : Form
    {
        private DialogResult resultado;
        // creamos la lista
        List<ListaEstudiante> miListaEstudiantes = new List<ListaEstudiante>();
        private string servicioPAE;

        public Lista()
        {
            InitializeComponent();
            btnConsultar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (validarTipoIdentificacion() == false)
            {
                return;
            }

            if (validarIdentificacion() == false)
            {
                return;
            }

            if (validarNombre() == false)
            {
                return;
            }

            if (validarEstrato() == false)
            {
                return;
            }

            if (validarServicioPAE() == false)
            {
                return;

            }


            if (validarGrado() == false)
            {
                return;
            }

            /*

            if(validarTipoIdentificacionC() == false)

            {
                return;

            }

            */

            // Creamos un objeto de la clase listaEstuduantes para enviarle los valores

            ListaEstudiante listaEstudiante = new ListaEstudiante();

            listaEstudiante.TipoIdentificacion = this.cmbTipoIdentificacion.Text;
            listaEstudiante.Identificacion = (txtIdentificacion.Text);
            listaEstudiante.Nombre = this.txtNombre.Text;
            listaEstudiante.estrato = int.Parse(cmbEstrato.Text);
            listaEstudiante.fechaNacimiento = dateTimeFechaNacimiento.Value;
            listaEstudiante.Grado = int.Parse(cmbGrado.Text);
            listaEstudiante.servicioPAE = servicioPAE.ToString();
            listaEstudiante.beneficio = listaEstudiante.BeneficioAlimentario();

            

            // Adicionar Servicio PAE
            MessageBox.Show(" Registro exitoso");
            // Validacion de botones
            btnRegistrar.Enabled = true;
            btnConsultar.Enabled = true;
            
            
            miListaEstudiantes.Add(listaEstudiante);
            DataGridLista.DataSource = null;
            DataGridLista.DataSource = miListaEstudiantes;
            limpiarCampos();




        }

        private bool validarServicioPAE()
        {
            if (this.radioButtonSi.Checked == false && this.radioButtonNo.Checked == false)
            {
                MessageBox.Show("¿Utilizo el servicio PAE", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cmbTipoIdentificacion.Focus();
                return false;


            }

            else
            {


                //servicioPAE

                if(this.radioButtonSi.Checked == true)
                {
                    this.servicioPAE = "Si";                
                    return true;

                }
                if(this.radioButtonNo.Checked == true)
                {
                    this.servicioPAE = "No";

                }
                return true;

            }
        }

       


        ///////////////   FILTROS DE VALIDACIÓN DE CAMPOS /////////////////////////
        // validar tipo Identificaicon
        private bool validarTipoIdentificacion()
        {
            if (string.IsNullOrEmpty(cmbTipoIdentificacion.Text))
            {
                errorProviderLista.SetError(cmbTipoIdentificacion, "Debe ingresar un tipo de indentificacion");
                MessageBox.Show("¿Debe ingresar su tipo identificación", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //cmbTipoIdentificacion.Focus();
                return false;
            }
            else
            {
                errorProviderLista.SetError(cmbTipoIdentificacion,"");
                return true;
            }
        }


        // validar identificacion
        public bool validarIdentificacion()
        {
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                errorProviderLista.SetError(txtIdentificacion, "Debe ingresar un tipo de indentificacion");
                MessageBox.Show("¿Debe ingresar su identificación", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return false;
            }
            else
            {
                errorProviderLista.SetError(txtIdentificacion,"");
                return true;
            }
        }


        // Validar el nombre
        private bool validarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProviderLista.SetError(txtNombre, "Debe ingresar un nombre");
                MessageBox.Show("¿Debe ingresar su nombre", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderLista.SetError(txtNombre,"");
                return true;
            }
        }

        // Validar estrato


        private bool validarEstrato()
        {
            int edad;
            if (!int.TryParse(cmbEstrato.Text, out edad) || cmbEstrato.Text == "")
            {
                errorProviderLista.SetError(cmbEstrato, "Debe ingresar un estrato");
                MessageBox.Show("¿Debe ingresar su Estrato", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderLista.SetError(cmbEstrato, "");
                return true;
            }
        }

        // Validar Grado

        private bool validarGrado()
        {

            int grado;
            if (!int.TryParse(cmbGrado.Text, out grado) || cmbGrado.Text == "")
            {
                errorProviderLista.SetError(cmbGrado, "Debe ingresar un grado");
                MessageBox.Show("¿Debe ingresar el grado academico", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                errorProviderLista.SetError(cmbGrado, "");
                return true;
            }
        }

        

 

        // Limpiar campos

        private void limpiarCampos()
        {
            cmbTipoIdentificacion.Text = "";
            txtIdentificacion.Clear();
            txtNombre.Clear();
            cmbEstrato.Text = "";
            cmbGrado.Text = "";
            dateTimeFechaNacimiento.Value = DateTime.Now;
           
            

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

        private void cmbEstrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != 8 && e.KeyChar != 127
                && e.KeyChar != 32) e.Handled = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)


        {

            if (validarIdentificacionC() == false)
            {

                return;
            }






            ListaEstudiante miConsulta = getConsulta(txtIdentificacionC .Text);

            if (miConsulta == null)
            {
                // Proba con txt identificacionC
                errorProviderLista.SetError(txtIdentificacionC, "La identificación no se encuentra registrada");
                limpiarCampos();
                txtIdentificacionC.Focus();
                return;

            }
            else
            {
                errorProviderLista.SetError(txtIdentificacionC, "");
               // cmbTipoIdentificacion.SelectedItem = miConsulta.TipoIdentificacion;
                cmbTipoIdentificacion.Text = miConsulta.TipoIdentificacion.ToString();
                txtIdentificacion.Text = miConsulta.Identificacion;
                txtNombre.Text = miConsulta.Nombre;
               // cmbEstrato.SelectedItem = miConsulta.estrato.ToString();
                cmbEstrato.Text = miConsulta.estrato.ToString();
                dateTimeFechaNacimiento.Value = miConsulta.fechaNacimiento;
               // cmbGrado.SelectedItem = miConsulta.Grado;
                cmbGrado.Text = miConsulta.Grado.ToString();
                btnEliminar.Enabled = true;

            }

        }

        private bool validarIdentificacionC()
        {
            if (string.IsNullOrEmpty(txtIdentificacionC.Text))
            {
                errorProviderLista.SetError(txtIdentificacionC, "Debe ingresar un tipo de indentificacion");
                MessageBox.Show("¿Debe ingresar su identificación", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;
            }
            else
            {
                errorProviderLista.SetError(txtIdentificacionC, "");
                return true;
            }
        }






        // Metodo de consular registros
        private ListaEstudiante getConsulta(string identificacion)
        {
            return miListaEstudiantes.Find(consulta => consulta.Identificacion.Contains(identificacion));

            // En el ultimo arreglo cambie el tipo de variable identificacion de decimal a string



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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(txtIdentificacionC.Text == "")
            {
                errorProviderLista.SetError(txtIdentificacionC,"Debe consultar el estudiante a eliminar");
                limpiarCampos();
                txtIdentificacionC.Focus();
                btnEliminar.Enabled = false;
                return;

            }

            else
            {

                errorProviderLista.SetError(txtIdentificacionC, "");
                DialogResult = resultado;
                resultado = MessageBox.Show("¿Desea Eliminar el Estudiante?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resultado == DialogResult.Yes )
                {

                    // Arreglar el eliminar
                    // No elimina pero si consula coreectamente

                    foreach (ListaEstudiante miConsulta in miListaEstudiantes)
                    {

                        if(miConsulta.Identificacion == txtIdentificacionC.Text)
                        {

                            miListaEstudiantes.Remove(miConsulta);  
                            break;
                        }

                    }
                    limpiarCampos();
                    txtIdentificacionC.Clear();
                    DataGridLista.DataSource = null;
                    DataGridLista.DataSource = miListaEstudiantes;

                }

                else
                {
                    MessageBox.Show("La lista esta vacia");
                    limpiarCampos();

                }

            }





        }
    }
}
