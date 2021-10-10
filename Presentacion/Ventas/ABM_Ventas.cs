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
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Ventas
{
    public partial class ABM_Ventas : Form
    {
        //declaro objetos
        TipoFacturaService oTipoFacturaService;
        ClienteService oClienteService;
        ProductoService oProductoService;
        PlantasService oPlataService;


        public ABM_Ventas()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oProductoService = new ProductoService();
            oPlataService = new PlantasService();
        }

        private FormMode formMode = FormMode.insert;

        public enum FormMode
        {
            insert,
            delete
        }
        
        private void ABM_Ventas_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 50);
        
            LlenarCombo(cboTipoFactura, oTipoFacturaService.traerTodo(), "Nombre", "ID");
            LlenarCombo(cboCliente, oClienteService.traerTodo(), "FullName", "NroDoc");
            LlenarCombo(cboItem, oProductoService.traerTodo(), "Nombre", "Codigo");


            switch (formMode)
            {
                case FormMode.insert:
                    this.Text = "Nueva Factura";
                    break;
                case FormMode.delete:
                    this.Text = "Eliminar Factura";
                    //actualizarCampos();
                    this.cboTipoFactura.Enabled = false;
                    this.cboCliente.Enabled = false;
                    this.dtpFecha.Enabled = false;
                    this.rbPlanta.Enabled = false;
                    this.rbProducto.Enabled = false;
                    this.cboItem.Enabled = false;
                    this.txtCantidad.Enabled = false;
                    this.btnNueva.Enabled = false;
                    this.btnConfirmar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.dgv_Items.Enabled = false;
                    this.txtDescuento.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;

        }

     



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            //cboItem.DataSource = null;
            //cboItem.Items.Clear();
            LlenarCombo(cboItem, oProductoService.traerTodo(), "Nombre", "Codigo");
            
        }

        private void rbPlanta_CheckedChanged(object sender, EventArgs e)
        {
            //cboItem.DataSource = null;
            //cboItem.Items.Clear();
            LlenarCombo(cboItem, oPlataService.Todas_las_Plantas(), "NombreComun", "Codigo");
            
        }

       

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            txtImporte.Text = (int.Parse(txtCantidad.Text) * int.Parse(txtPrecio.Text)).ToString();
        }

        private void cboItem_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
