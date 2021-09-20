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
        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly TipoDocService oTipoDocService;
        private readonly EmpleadoService oEmpleadoService;
        private readonly BarrioService oBarrioService;
        private readonly LocalidadService olocalidadService;
        private Es_Empleado oEmpleadoSeleccionado;
        private int idEmpleado;


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

            //switch

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
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
                        //MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        //txtNombre.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtEmail.Enabled = false;
                        //txtPassword.Enabled = false;
                        //cboPerfil.Enabled = false;
                        //txtConfirmarPass.Enabled = false;
                        break;
                    }
            }

            
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private bool ExisteUsuario()
        {
            return (oEmpleadoService.ObtenerEmpleado(txt_NombreEmpleado.Text, txtContrasena.Text) != string.Empty);
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

        public void SeleccionarEmpleado(FormMode op, Es_Empleado empleadoSeleccionado)
        {
            formMode = op;
            oEmpleadoSeleccionado = empleadoSeleccionado;
        }

        private void MostrarDatos()
        {
            if (oEmpleadoSeleccionado != null)
            {
                
                txt_NombreEmpleado.Text = oEmpleadoSeleccionado.Nombre;
                txt_ApellidoEmpleado.Text = oEmpleadoSeleccionado.Apellido;
                txtContrasena.Text = oEmpleadoSeleccionado.Contraseña;
                txtRepetirContrasena.Text = txtContrasena.Text;
                cboTipoDoc.Text = oEmpleadoSeleccionado.TipoDoc.Descripcion;
                txtNroDoc.Text = oEmpleadoSeleccionado.Nro_Doc;
                txtCalle.Text = oEmpleadoSeleccionado.Calle;
                txtNroCalle.Text = oEmpleadoSeleccionado.Nro_Calle.ToString();
                cboBarrio.Text = oEmpleadoSeleccionado.Barrio.Nombre;
                cboLocalidad.Text = oEmpleadoSeleccionado.Localidad.Nombre;
                txtTelefono.Text = oEmpleadoSeleccionado.Telefono;
            }
        }


        


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteUsuario() == false)
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
                                oEmpleado.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                                oEmpleado.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;
                                oEmpleado.Estado = 1;

                                if (oEmpleadoService.CrearUsuario(oEmpleado))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else { MessageBox.Show("Error"); }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del empleado seleccionado
                            

                            oEmpleadoSeleccionado.Nombre = txt_NombreEmpleado.Text;
                            oEmpleadoSeleccionado.Apellido = txt_ApellidoEmpleado.Text;
                            oEmpleadoSeleccionado.Contraseña = txtContrasena.Text;

                            oEmpleadoSeleccionado.TipoDoc = new Es_TipoDoc();
                            oEmpleadoSeleccionado.TipoDoc.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
                            oEmpleadoSeleccionado.Nro_Doc = txtNroDoc.Text;
                            oEmpleadoSeleccionado.Telefono = txtTelefono.Text;
                            oEmpleadoSeleccionado.Calle = txtCalle.Text;
                            oEmpleadoSeleccionado.Nro_Calle = int.Parse(txtNroCalle.Text);
                            oEmpleadoSeleccionado.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                            oEmpleadoSeleccionado.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;



                          

                            if (oEmpleadoService.ActualizarUsuario(oEmpleadoSeleccionado))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

            }
        }
    }

}
