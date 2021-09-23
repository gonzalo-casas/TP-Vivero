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
            oProveedorService = new ProveedorService();
            oBarrioService = new BarrioService();
            olocalidadService = new LocalidadService();

        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly ProveedorService oProveedorService;
        private readonly BarrioService oBarrioService;
        private readonly LocalidadService olocalidadService;
        private int idProveedor;
        private int EstadoActual; 


        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public ABM_Proveedor()
        {
            InitializeComponent();
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
        {   
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
                 
                        actualizarCampos();
                        txtNombreProveedor.Enabled = true;
                        txtRSProv.Enabled = true;                       
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
                        this.Text = "Habilitar/Deshabilitar Proveedor";
                        txtNombreProveedor.Enabled = false;
                        txtRSProv.Enabled = false;
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
           
            txtNombreProveedor.Text = tabla.Rows[0]["Nombre"].ToString();
            txtRSProv.Text = tabla.Rows[0]["Razon_Social"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtNroCalle.Text = tabla.Rows[0]["Nro_Calle"].ToString();
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
            if (txtNombreProveedor.Text == string.Empty)
            {
                MessageBox.Show("Ingrese nombre del Proveedor por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreProveedor.BackColor = Color.Red;
                txtNombreProveedor.Focus();
                return false;
            }
            else
                txtNombreProveedor.BackColor = Color.White;

            if (txtRSProv.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Razon Social por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRSProv.BackColor = Color.Red;
                txtRSProv.Focus();
                return false;
            }
            else
                txtRSProv.BackColor = Color.White;

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
                                var oProveedor = new Es_Proveedor();
                                oProveedor.Nombre = txtNombreProveedor.Text;
                                oProveedor.Razon_Social = txtRSProv.Text;
                                oProveedor.Calle = txtCalle.Text;
                                oProveedor.Telefono = txtTelefono.Text;
                                oProveedor.Nro_Calle = txtNroCalle.Text;
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
                        
                        
                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del proveedor seleccionado

                            Es_Proveedor oProveedorSeleccionado = new Es_Proveedor();

                            oProveedorSeleccionado.ID = idProveedor;
                            oProveedorSeleccionado.Nombre = txtNombreProveedor.Text;
                            oProveedorSeleccionado.Razon_Social = txtRSProv.Text;
                            oProveedorSeleccionado.Telefono = txtTelefono.Text;
                            oProveedorSeleccionado.Calle = txtCalle.Text;
                            oProveedorSeleccionado.Nro_Calle = txtNroCalle.Text;
                            oProveedorSeleccionado.Barrio = new Es_Barrio();
                            oProveedorSeleccionado.Barrio.IdBarrio = ((int)cboBarrio.SelectedIndex+1);
                            oProveedorSeleccionado.Localidad = new Es_Localidad();
                            oProveedorSeleccionado.Localidad.IdLocalidad = ((int)cboLocalidad.SelectedIndex+1);
                            oProveedorSeleccionado.Estado = EstadoActual;
                            



                          

                            if (oProveedorService.ActualizarProveedor(oProveedorSeleccionado))
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
