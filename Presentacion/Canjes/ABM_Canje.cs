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


namespace Vivero.Presentacion.Canjes
{
    public partial class ABM_Canje : Form
    {
        //declaro objetos
        private readonly BindingList<Es_DetalleFactura> listaFacturaDetalle;
        TipoFacturaService oTipoFacturaService;
        ClienteService oClienteService;
        ProductoService oProductoService;
        PlantasService oPlataService;
        FacturaService oFacturaService;
        Es_Cliente oCliente = new Es_Cliente();
        string tipoDoc { get; set; }
        bool flag;





        public ABM_Canje()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oProductoService = new ProductoService();
            oPlataService = new PlantasService();
            cboItem.Enabled = false;
            //dgv_Items.AutoGenerateColumns = false;
            listaFacturaDetalle = new BindingList<Es_DetalleFactura>();
            oFacturaService = new FacturaService();
        }

        private FormMode formMode = FormMode.insert;

        public enum FormMode
        {
            insert,
            delete
        }

        private void ABM_Ventas_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(300, 50);
            
            //LlenarCombo(cboTipoFactura, oTipoFacturaService.traerTodo(), "Nombre", "ID");
            LlenarCombo(cboCliente, oClienteService.traerTodo(), "FullName", "NroDoc");
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblNroDoc.Visible = false;
            cboCliente.Enabled = true;
            dtpFecha.MaxDate = DateTime.Today;
            //dgv_Items.DataSource = listaFacturaDetalle;
            //rbProducto.Checked = true;





            //    switch (formMode)
            //    {
            //        case FormMode.insert:
            //            this.Text = "Nueva Factura";
            //            break;
            //        case FormMode.delete:
            //            this.Text = "Eliminar Factura";
            //            //actualizarCampos();
            //            //this.cboTipoFactura.Enabled = false;
            //            this.cboCliente.Enabled = false;
            //            this.dtpFecha.Enabled = false;
            //            this.rbPlanta.Enabled = false;
            //            this.rbProducto.Enabled = false;
            //            this.cboItem.Enabled = false;
            //            this.txtCantidad.Enabled = false;
            //            this.btnNueva.Enabled = false;
            //            this.btnEliminar.Enabled = false;
            //            this.dgv_Items.Enabled = false;
            //            break;
            //        default:
            //            break;
            //    }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {

            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.Enabled.Equals(true))
            {
                
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(validarCamposFactura())

            try
            {
                var factura = new Es_Factura();

                    factura.Fecha = dtpFecha.Value;
                    factura.Cliente = oCliente;
                factura.Tipo_Factura = new Es_TipoFactura();
                factura.FacturaDetalle = listaFacturaDetalle;
                factura.Monto = double.Parse(txtTotal.Text);
                factura.Id_Empleado = new Es_Empleado();
                factura.Id_Empleado.ID = FrmPrincipal.idUsuario;
                
               

                if (oFacturaService.ValidarDatos(factura))
                {
                    oFacturaService.Crear(factura);

                    MessageBox.Show(string.Concat("La factura nro: ", factura.Numero_Factura, " se generó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la factura! " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validarCamposFactura()
        {

            if (cboCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un Cliente por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var listaAgrupada = from i in listaFacturaDetalle
                                group i by i.Nombre into j
                                select new { Nombre = j.Key, Cantidad = j.Sum(k => k.Cantidad), Stock = j.First().Stock };

            foreach (var item in listaAgrupada)
            {
                if (item.Cantidad > int.Parse(item.Stock))
                {
                    MessageBox.Show("La cantidad requerida no esta en stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.Enabled)
            {
                string seleccionCbo = cboCliente.SelectedValue.ToString();
                
                DataTable clienteSeleccionado = oClienteService.BuscarCliente("", seleccionCbo, "", "", "(1)");
                oCliente.Calle = clienteSeleccionado.Rows[0]["Calle"].ToString();
                oCliente.NroCalle = clienteSeleccionado.Rows[0]["NroCalle"].ToString();
                oCliente.Telefono = clienteSeleccionado.Rows[0]["Telefono"].ToString();
                oCliente.NroDoc = seleccionCbo;
                oCliente.TipoDoc = new Es_TipoDoc();
                oCliente.TipoDoc.IdTipoDoc = int.Parse(clienteSeleccionado.Rows[0]["TipoDoc"].ToString());
                lblDireccion.Text = oCliente.Calle + " " + oCliente.NroCalle;
                lblTelefono.Text = oCliente.Telefono;
                lblNroDoc.Text = oCliente.NroDoc;
                
                if (!lblDireccion.Visible) lblDireccion.Visible = true;
                if (!lblTelefono.Visible) lblTelefono.Visible = true;
                if (!lblNroDoc.Visible) lblNroDoc.Visible = true;
            }

        }

    } 
}
