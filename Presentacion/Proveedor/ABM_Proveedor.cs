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

namespace Vivero.Presentacion.Proveedor
{
    public partial class ABM_Proveedor : Form
    {
        
        public ABM_Proveedor(int idProveedor)
        {
            InitializeComponent();
            this.idProveedor = idProveedor;
            //oTipoDocService = new TipoDocService();
            oProveedorService = new ProveedorService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();

        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        //private readonly TipoDocService oTipoDocService;
        private readonly ProveedorService oProveedorService;
        private readonly BarrioService oBarrioService;
        private readonly LocalidadService olocalidadService;
        private Es_Proveedor oProveedorSeleccionado;
        private int idProveedor;

        // para hace la modificacion  necesito un idEmpleado
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public ABM_Proveedor()
        {
            InitializeComponent();
            // oTipoDocService = new TipoDocService();
            oProveedorService = new ProveedorService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();

        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }



        private void ALTA_Proveedor_Load(object sender, EventArgs e)
        {    // lleno los combos
           // LlenarCombo(cboTipoDoc, oTipoDocService.traerTodo(), "Descripcion", "ID");
            LlenarCombo(cboBarrio, oBarrioService.traerTodo(), "Nombre", "ID");
            LlenarCombo(cboLocalidad, olocalidadService.traerTodo(), "Nombre", "ID");


            

            //switch para actualizar titulo y habilitar  txt y cbo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Proveedor";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Proveedor";
                        // Recuperar usuario seleccionado en la grilla 
                        //MostrarDatos();
                        actualizarCampos();
                        txtNombreProveedor.Enabled = true;
                        txtRSProv.Enabled = true;
                       // txtContrasena.Enabled = true;
                        //txtRepetirContrasena.Enabled = true;
                       // cboTipoDoc.Enabled = true;
                      //  txtNroDoc.Enabled = true;
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
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        txtNombreProveedor.Enabled = false;
                        txtRSProv.Enabled = false;
                       // txtContrasena.Enabled = false;
                       // txtRepetirContrasena.Enabled = false;
                        //cboTipoDoc.Enabled = false;
                       // txtNroDoc.Enabled = false;
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
            ProveedorService oProveedorSeleccionado = new ProveedorService();
            tabla = oProveedorSeleccionado.RecuperarPorId(idProveedor);
            //txt.Text = tabla.Rows[0]["ID"].ToString();
       
            //cboTipoDoc.Text = tabla.Rows[0]["TipoDoc"].ToString();
           // txtNroDoc.Text = tabla.Rows[0]["NroDoc"].ToString();
            txtNombreProveedor.Text = tabla.Rows[0]["Nombre"].ToString();
            txtRSProv.Text = tabla.Rows[0]["Razon_Social"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["Nro_Calle"].ToString();
            cboBarrio.Text = tabla.Rows[0]["Barrio"].ToString();
            cboLocalidad.Text = tabla.Rows[0]["Localidad"].ToString();
           // txtContrasena.Text = tabla.Rows[0]["Contraseña"].ToString();


            //txt_criticidad.Text = tabla.Rows[0]["Estado"].ToString();



            tabla.Clear();
            

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private bool ExisteProveedor()
        {
            return (oProveedorService.ObtenerProveedor(idProveedor.ToString()) != string.Empty);
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombreProveedor.Text == string.Empty)
            {
                txtNombreProveedor.BackColor = Color.Red;
                txtNombreProveedor.Focus();
                return false;
            }
            else
                txtNombreProveedor.BackColor = Color.White;

            return true;
        }

        public void SeleccionarProveedor(FormMode op)
        {
            formMode = op;
           
        }

        //private void MostrarDatos()
        //{
        //    if (oEmpleadoSeleccionado != null)
        //    {
                
        //        txt_NombreEmpleado.Text = oEmpleadoSeleccionado.Nombre;
        //        txt_ApellidoEmpleado.Text = oEmpleadoSeleccionado.Apellido;
        //        txtContrasena.Text = oEmpleadoSeleccionado.Contraseña;
        //        txtRepetirContrasena.Text = txtContrasena.Text;
        //        cboTipoDoc.Text = oEmpleadoSeleccionado.TipoDoc.Descripcion;
        //        txtNroDoc.Text = oEmpleadoSeleccionado.Nro_Doc;
        //        txtCalle.Text = oEmpleadoSeleccionado.Calle;
        //        txtNroCalle.Text = oEmpleadoSeleccionado.Nro_Calle.ToString();
        //        cboBarrio.Text = oEmpleadoSeleccionado.Barrio.Nombre;
        //        cboLocalidad.Text = oEmpleadoSeleccionado.Localidad.Nombre;
        //        txtTelefono.Text = oEmpleadoSeleccionado.Telefono;
        //    }
        //}


        


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (!ExisteProveedor())
                        {
                            if (ValidarCampos())
                            {
                                var oProveedor = new Es_Proveedor();
                                oProveedor.Nombre = txtNombreProveedor.Text;
                                oProveedor.Razon_Social = txtRSProv.Text;
                                //oEmpleado.Contraseña = txtContrasena.Text;
                                //oProveedor.TipoDoc = new Es_TipoDoc();
                                // oEmpleado.TipoDoc.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
                                //oEmpleado.Nro_Doc = txtNroDoc.Text;
                                oProveedor.Calle = txtCalle.Text;
                                oProveedor.Telefono = txtTelefono.Text;
                                oProveedor.Nro_Calle = int.Parse(txtNroCalle.Text);
                                oProveedor.Barrio = new Es_Barrio();
                                oProveedor.Barrio.IdBarrio = (int)cboBarrio.SelectedValue;
                                oProveedor.Localidad = new Es_Localidad();
                                oProveedor.Localidad.IdLocalidad = (int)cboLocalidad.SelectedValue;
                                oProveedor.Estado = 1;

                                if (oProveedorService.CrearProveedor(oProveedor))
                                {
                                    MessageBox.Show("Proveedor insertado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else { MessageBox.Show("Error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                        }
                        else
                            MessageBox.Show("Proveedor encontrado!. Ingrese un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del empleado seleccionado

                            Es_Proveedor oProveedorSeleccionado = new Es_Proveedor();

                            oProveedorSeleccionado.ID = idProveedor;
                            oProveedorSeleccionado.Nombre = txtNombreProveedor.Text;
                            oProveedorSeleccionado.Razon_Social = txtRSProv.Text;
                            //oProveedorSeleccionado.Contraseña = txtContrasena.Text;

                            //oProveedorSeleccionado.TipoDoc = new Es_TipoDoc();
                           // oProveedorSeleccionado.TipoDoc.IdTipoDoc = ((int)cboTipoDoc.SelectedIndex+1);
                            //oProveedorSeleccionado.Nro_Doc = txtNroDoc.Text;
                            oProveedorSeleccionado.Telefono = txtTelefono.Text;
                            oProveedorSeleccionado.Calle = txtCalle.Text;
                            oProveedorSeleccionado.Nro_Calle = int.Parse(txtNroCalle.Text);
                            oProveedorSeleccionado.Barrio = new Es_Barrio();
                            oProveedorSeleccionado.Barrio.IdBarrio = ((int)cboBarrio.SelectedIndex+1);
                            oProveedorSeleccionado.Localidad = new Es_Localidad();
                            oProveedorSeleccionado.Localidad.IdLocalidad = ((int)cboLocalidad.SelectedIndex+1);
                            oProveedorSeleccionado.Estado = 1;
                            



                          

                            if (oProveedorService.ActualizarUsuario(oProveedorSeleccionado))
                            {
                                MessageBox.Show("Proveedor actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Proveedor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el proveedor seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {


                            Es_Proveedor oProveedorSeleccionado = new Es_Proveedor();

                            oProveedorSeleccionado.ID = idProveedor;
                            oProveedorSeleccionado.Nombre = txtNombreProveedor.Text;
                            oProveedorSeleccionado.Razon_Social = txtRSProv.Text;
                            //oProveedorSeleccionado.Contraseña = txtContrasena.Text;

                            //oProveedorSeleccionado.TipoDoc = new Es_TipoDoc();
                            //oProveedorSeleccionado.TipoDoc.IdTipoDoc = ((int)cboTipoDoc.SelectedIndex + 1);
                            //oProveedorSeleccionado.Nro_Doc = txtNroDoc.Text;
                            oProveedorSeleccionado.Telefono = txtTelefono.Text;
                            oProveedorSeleccionado.Calle = txtCalle.Text;
                            oProveedorSeleccionado.Nro_Calle = int.Parse(txtNroCalle.Text);
                            oProveedorSeleccionado.Barrio = new Es_Barrio();
                            oProveedorSeleccionado.Barrio.IdBarrio = ((int)cboBarrio.SelectedIndex + 1);
                            oProveedorSeleccionado.Localidad = new Es_Localidad();
                            oProveedorSeleccionado.Localidad.IdLocalidad = ((int)cboLocalidad.SelectedIndex + 1);

                            if (oProveedorService.ModificarEstadoProveedor(oProveedorSeleccionado))
                            {
                                MessageBox.Show("Proveedor Habilitado/Deshabilitado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el proveedor!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
