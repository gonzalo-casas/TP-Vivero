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
    public partial class ALTA_Empleado : Form
    {
        private FormMode formMode = FormMode.insert;
        private readonly TipoDocService oTipoDocService;
        private readonly EmpleadoService oEmpleadoService;



        public ALTA_Empleado()
        {
            InitializeComponent();
             oTipoDocService = new TipoDocService();
            oEmpleadoService = new EmpleadoService();

        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }



        private void ALTA_Empleado_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipoDoc, oTipoDocService.traerTodo(), "Descripcion", "ID");
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
                        //MostrarDatos();
                        //txtNombre.Enabled = true;
                        //txtEmail.Enabled = true;
                        //txtEmail.Enabled = true;
                        //txtPassword.Enabled = true;
                        //txtConfirmarPass.Enabled = true;
                        //cboPerfil.Enabled = true;
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
                                oEmpleado.Barrio = int.Parse(txtBarrio.Text);
                                oEmpleado.Localidad = int.Parse(txtLocalidad.Text);
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

            }
        }
    }

}
