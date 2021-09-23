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

namespace Vivero.Presentacion.Empleados
{
    public partial class ABM_Empleado : Form
    {
        
        public ABM_Empleado(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            oTipoDocService = new TipoDocService();
            oEmpleadoService = new EmpleadoService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();
        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly TipoDocService oTipoDocService;
        private readonly EmpleadoService oEmpleadoService;
        private readonly BarrioService oBarrioService;
        private readonly LocalidadService olocalidadService;
        private int idEmpleado;
        private int EstadoActual; // para el update

        // para hace la modificacion  necesito un idProveedor
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public ABM_Empleado()
        {
            InitializeComponent();
            oTipoDocService = new TipoDocService();
            oEmpleadoService = new EmpleadoService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();

        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }



        private void ALTA_Empleado_Load(object sender, EventArgs e)
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
                        txt_NombreEmpleado.Enabled = true;
                        txt_ApellidoEmpleado.Enabled = true;
                        txtContrasena.Enabled = true;
                        txtRepetirContrasena.Enabled = true;
                        cboTipoDoc.Enabled = true;
                        txtNroDoc.Enabled = true;
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
                        this.Text = "Habilitar/Deshabilitar Empleado";
                        txt_NombreEmpleado.Enabled = false;
                        txt_ApellidoEmpleado.Enabled = false;
                        txtContrasena.Enabled = false;
                        txtRepetirContrasena.Enabled = false;
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
            EmpleadoService oEmpleadoSeleccionado = new EmpleadoService();
            tabla = oEmpleadoSeleccionado.RecuperarPorId(idEmpleado);
            cboTipoDoc.Text = tabla.Rows[0]["TipoDoc"].ToString();
            txtNroDoc.Text = tabla.Rows[0]["NroDoc"].ToString();
            txt_NombreEmpleado.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_ApellidoEmpleado.Text = tabla.Rows[0]["Apellido"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            cboBarrio.Text = tabla.Rows[0]["Barrio"].ToString();
            cboLocalidad.Text = tabla.Rows[0]["Localidad"].ToString();
            txtContrasena.Text = tabla.Rows[0]["Contraseña"].ToString();
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
            if (txt_NombreEmpleado.Text == string.Empty)
            {
                txt_NombreEmpleado.BackColor = Color.Red;
                txt_NombreEmpleado.Focus();
                return false;
            }
            else
                txt_NombreEmpleado.BackColor = Color.White;

            return true;
        }

        public void SeleccionarEmpleado(FormMode op)
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
                                var oEmpleado = new Es_Empleado();
                                oEmpleado.Nombre = txt_NombreEmpleado.Text;
                                oEmpleado.Apellido = txt_ApellidoEmpleado.Text;
                                oEmpleado.Contraseña = txtContrasena.Text;
                                oEmpleado.TipoDoc = new Es_TipoDoc();
                                oEmpleado.TipoDoc.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
                                oEmpleado.Nro_Doc = txtNroDoc.Text;
                                oEmpleado.Telefono = txtTelefono.Text;
                                oEmpleado.Calle = txtCalle.Text;
                                oEmpleado.Nro_Calle = int.Parse(txtNroCalle.Text);
                                oEmpleado.Barrio = new Es_Barrio();
                                oEmpleado.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                                oEmpleado.Localidad = new Es_Localidad();
                                oEmpleado.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;
                                oEmpleado.Estado = 1;

                                if (oEmpleadoService.CrearEmpleado(oEmpleado))
                                {
                                    MessageBox.Show("Empleado insertado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else { MessageBox.Show("Error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                        
                        
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del empleado seleccionado

                            Es_Empleado oEmpleadoSeleccionado = new Es_Empleado();

                            oEmpleadoSeleccionado.ID = idEmpleado;
                            oEmpleadoSeleccionado.Nombre = txt_NombreEmpleado.Text;
                            oEmpleadoSeleccionado.Apellido = txt_ApellidoEmpleado.Text;
                            oEmpleadoSeleccionado.Contraseña = txtContrasena.Text;

                            oEmpleadoSeleccionado.TipoDoc = new Es_TipoDoc();
                            oEmpleadoSeleccionado.TipoDoc.IdTipoDoc = ((int)cboTipoDoc.SelectedIndex+1);
                            oEmpleadoSeleccionado.Nro_Doc = txtNroDoc.Text;
                            oEmpleadoSeleccionado.Telefono = txtTelefono.Text;
                            oEmpleadoSeleccionado.Calle = txtCalle.Text;
                            oEmpleadoSeleccionado.Nro_Calle = int.Parse(txtNroCalle.Text);
                            oEmpleadoSeleccionado.Barrio = new Es_Barrio();
                            oEmpleadoSeleccionado.Barrio.IdBarrio = ((int)cboBarrio.SelectedIndex+1);
                            oEmpleadoSeleccionado.Localidad = new Es_Localidad();
                            oEmpleadoSeleccionado.Localidad.IdLocalidad = ((int)cboLocalidad.SelectedIndex+1);
                            oEmpleadoSeleccionado.Estado =  EstadoActual;
                            



                          

                            if (oEmpleadoService.ActualizarEmpleado(oEmpleadoSeleccionado))
                            {
                                MessageBox.Show("Empleado actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Empleado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el empleado seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {


                            Es_Empleado oEmpleadoSeleccionado = new Es_Empleado();

                            oEmpleadoSeleccionado.ID = idEmpleado;
                            oEmpleadoSeleccionado.Nombre = txt_NombreEmpleado.Text;
                            oEmpleadoSeleccionado.Apellido = txt_ApellidoEmpleado.Text;
                            oEmpleadoSeleccionado.Contraseña = txtContrasena.Text;

                            oEmpleadoSeleccionado.TipoDoc = new Es_TipoDoc();
                            oEmpleadoSeleccionado.TipoDoc.IdTipoDoc = ((int)cboTipoDoc.SelectedIndex + 1);
                            oEmpleadoSeleccionado.Nro_Doc = txtNroDoc.Text;
                            oEmpleadoSeleccionado.Telefono = txtTelefono.Text;
                            oEmpleadoSeleccionado.Calle = txtCalle.Text;
                            oEmpleadoSeleccionado.Nro_Calle = int.Parse(txtNroCalle.Text);
                            oEmpleadoSeleccionado.Barrio = new Es_Barrio();
                            oEmpleadoSeleccionado.Barrio.IdBarrio = ((int)cboBarrio.SelectedIndex + 1);
                            oEmpleadoSeleccionado.Localidad = new Es_Localidad();
                            oEmpleadoSeleccionado.Localidad.IdLocalidad = ((int)cboLocalidad.SelectedIndex + 1);

                            if (oEmpleadoService.ModificarEstadoEmpleado(oEmpleadoSeleccionado))
                            {
                                MessageBox.Show("Empleado Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el empleado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
