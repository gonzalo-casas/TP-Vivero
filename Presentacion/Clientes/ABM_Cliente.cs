//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vivero.Presentacion.Clientes
//{
//    public partial class ABM_Cliente : Form
//    {
//        public ABM_Cliente()
//        {
//            InitializeComponent();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Negocio;
using Vivero.Negocio.Entidades;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Clientes
{
    public partial class ABM_Cliente : Form
    {

        public ABM_Cliente(int TipoDoc, string NroDoc)
        {
            InitializeComponent();
            this.TipoDoc = TipoDoc;
            this.NroDoc = NroDoc;
            oTipoDocService = new TipoDocService();
            oClienteService = new ClienteService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();
        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly TipoDocService oTipoDocService;
        private readonly ClienteService oClienteService;
        private readonly BarrioService oBarrioService;
        private readonly LocalidadService olocalidadService;
        private int TipoDoc;
        private string NroDoc;
        private int EstadoActual; // para el update

        // para hace la modificacion  necesito un idProveedor

        public ABM_Cliente()
        {
            InitializeComponent();
            oTipoDocService = new TipoDocService();
            oClienteService = new ClienteService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();

        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }



        private void ABM_Cliente_Load(object sender, EventArgs e)
        {    // lleno los combos
            LlenarCombo(cboTipoDoc, oTipoDocService.traerTodo(), "Descripcion", "ID");
            LlenarCombo(cboBarrio, oBarrioService.traerTodo(), "Nombre", "ID");
            LlenarCombo(cboLocalidad, olocalidadService.traerTodo(), "Nombre", "ID");




            //switch para actualizar titulo y habilitar  txt y cbo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Empleado";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Empleado";
                        // Recuperar usuario seleccionado en la grilla 
                        actualizarCampos();
                        txt_NombreCliente.Enabled = true;
                        txt_ApellidoCliente.Enabled = true;
                        cboTipoDoc.Enabled = false;
                        txtNroDoc.Enabled = false;
                        txtCalle.Enabled = true;
                        txtNroCalle.Enabled = true;
                        cboBarrio.Enabled = true;
                        cboLocalidad.Enabled = true;
                        txtTelefono.Enabled = true;

                        break;
                    }

                case FormMode.delete:
                    {
                        actualizarCampos();
                        this.Text = "Deshabilitar Empleado";
                        txt_NombreCliente.Enabled = false;
                        txt_ApellidoCliente.Enabled = false;
                        cboTipoDoc.Enabled = false;
                        txtNroDoc.Enabled = false;
                        txtCalle.Enabled = false;
                        txtNroCalle.Enabled = false;
                        cboBarrio.Enabled = false;
                        cboLocalidad.Enabled = false;
                        txtTelefono.Enabled = false;
                        break;
                    }
            }


        }


        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            ClienteService oClienteSeleccionado = new ClienteService();
            tabla = oClienteSeleccionado.RecuperarPorTipoDoc_NroDoc(TipoDoc, NroDoc);
            cboTipoDoc.Text = tabla.Rows[0]["TipoDoc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["NroDoc"].ToString();
            txt_NombreCliente.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_ApellidoCliente.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["NroCalle"].ToString();
            cboBarrio.Text = tabla.Rows[0]["Barrio"].ToString();
            cboLocalidad.Text = tabla.Rows[0]["Localidad"].ToString();
            EstadoActual = Convert.ToInt32(tabla.Rows[0]["Estado"]);

            tabla.Clear();

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }



        private bool ValidarCampos()
        {

            // campos obligatorios
            if (txt_NombreCliente.Text == string.Empty)
            {
                MessageBox.Show("Ingrese nombre del cliente por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombreCliente.BackColor = Color.Red;
                txt_NombreCliente.Focus();
                return false;
            }
            else
                txt_NombreCliente.BackColor = Color.White;

            if (txt_ApellidoCliente.Text == string.Empty)
            {
                MessageBox.Show("Ingrese apellido del cliente por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ApellidoCliente.BackColor = Color.Red;
                txt_ApellidoCliente.Focus();
                return false;
            }
            else
                txt_ApellidoCliente.BackColor = Color.White;


            if (cboTipoDoc.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un tipo de documento por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNroDoc.Text == string.Empty)
            {
                MessageBox.Show("Ingrese numero del cliente por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroDoc.BackColor = Color.Red;
                txtNroDoc.Focus();
                return false;
            }
            else
                txtNroDoc.BackColor = Color.White;

            if (cboBarrio.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un barrio por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (cboLocalidad.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una localidad por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        public void SeleccionarOpcion(FormMode op)
        {
            formMode = op;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (ValidarCampos())
                        {
                            var oCliente = new Es_Cliente();
                            oCliente.Nombre = txt_NombreCliente.Text;
                            oCliente.Apellido = txt_ApellidoCliente.Text;
                            oCliente.TipoDoc = new Es_TipoDoc();
                            oCliente.TipoDoc.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
                            oCliente.NroDoc = txtNroDoc.Text;
                            oCliente.Telefono = txtTelefono.Text;
                            oCliente.Calle = txtCalle.Text;
                            oCliente.NroCalle = txtNroCalle.Text;
                            oCliente.Barrio = new Es_Barrio();
                            oCliente.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                            oCliente.Localidad = new Es_Localidad();
                            oCliente.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;
                            oCliente.Estado = 1;


                            if (oClienteService.CrearCliente(oCliente))
                            {
                                MessageBox.Show("Cliente insertado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }

                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del empleado seleccionado

                            Es_Cliente oClienteSeleccinado = new Es_Cliente();

                            var oClienteSeleccionado = new Es_Cliente();
                            oClienteSeleccionado.Nombre = txt_NombreCliente.Text;
                            oClienteSeleccionado.Apellido = txt_ApellidoCliente.Text;
                            oClienteSeleccionado.TipoDoc = new Es_TipoDoc();
                            oClienteSeleccionado.TipoDoc.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
                            oClienteSeleccionado.NroDoc = txtNroDoc.Text;
                            oClienteSeleccionado.Telefono = txtTelefono.Text;
                            oClienteSeleccionado.Calle = txtCalle.Text;
                            oClienteSeleccionado.NroCalle = txtNroCalle.Text;
                            oClienteSeleccionado.Barrio = new Es_Barrio();
                            oClienteSeleccionado.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                            oClienteSeleccionado.Localidad = new Es_Localidad();
                            oClienteSeleccionado.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;
                            oClienteSeleccionado.Estado = 1;


                            if (oClienteService.ActualizarCliente(oClienteSeleccionado))
                            {
                                MessageBox.Show("Cliente actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar el cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            Es_Cliente oClienteSeleccionado = new Es_Cliente();
                            oClienteSeleccionado.TipoDoc = new Es_TipoDoc();
                            oClienteSeleccionado.TipoDoc.IdTipoDoc = TipoDoc;
                            oClienteSeleccionado.NroDoc = NroDoc;

                            if (oClienteService.ModificarEstadoCliente(oClienteSeleccionado))
                            {
                                MessageBox.Show("Cliente Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el cliente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }
    }

}
