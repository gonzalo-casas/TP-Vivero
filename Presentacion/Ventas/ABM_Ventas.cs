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


namespace Vivero.Presentacion.Ventas
{
    public partial class ABM_Ventas : Form
    {
        //declaro objetos
        private readonly BindingList<Es_DetalleFactura> listaFacturaDetalle;
        TipoFacturaService oTipoFacturaService;
        ClienteService oClienteService;
        ProductoService oProductoService;
        PlantasService oPlataService;
        FacturaService oFacturaService;
        string tipoDoc { get; set; }
        bool flag;

      



        public ABM_Ventas()
        {
            InitializeComponent();
            oTipoFacturaService = new TipoFacturaService();
            oClienteService = new ClienteService();
            oProductoService = new ProductoService();
            oPlataService = new PlantasService();
            cboItem.Enabled = false;
            dgv_Items.AutoGenerateColumns = false;
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
            this.Location = new Point(300, 50);
            
            LlenarCombo(cboTipoFactura, oTipoFacturaService.traerTodo(), "Nombre", "ID");
            LlenarCombo(cboCliente, oClienteService.traerTodo(), "FullName", "NroDoc");
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblNroDoc.Visible = false;
            cboCliente.Enabled = true;

            dgv_Items.DataSource = listaFacturaDetalle;

            



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
                    this.btnEliminar.Enabled = false;
                    this.dgv_Items.Enabled = false;
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

 
        private void btnEliminar_Click(object sender, EventArgs e) // es el boton de quitar 
        {
            if (dgv_Items.CurrentRow != null)
            {
                var detalleSeleccionado = (Es_DetalleFactura)dgv_Items.CurrentRow.DataBoundItem;
                listaFacturaDetalle.Remove(detalleSeleccionado);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
          
           
                cboItem.Enabled = false;
                LlenarCombo(cboItem, oProductoService.traerTodo(), "Nombre", "Codigo");
                txtPrecio.Clear(); // para que cuando cambie de combo, que borre el precio e importe anterior
                txtImporte.Clear();
                cboItem.Enabled = true;
          


        }

        private void rbPlanta_CheckedChanged(object sender, EventArgs e)
        {
           
            cboItem.Enabled = false;
            LlenarCombo(cboItem, oPlataService.Todas_las_Plantas(), "NombreComun", "Codigo");
            txtPrecio.Clear();
            txtImporte.Clear();
            cboItem.Enabled = true;
           
        }




        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            if (cboItem.Enabled.Equals(true))
            {
                int cantidad = 0;
                int precio = 0;
                int.TryParse(txtCantidad.Text, out cantidad);
                int.TryParse(txtPrecio.Text, out precio);
                txtImporte.Text = (precio * cantidad).ToString();
            }
        }

        

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.Enabled.Equals(true)) 
            {
                
                var precio = rbProducto.Checked ? oProductoService.RecuperarPorCod(int.Parse(cboItem.SelectedValue.ToString())).Rows[0]["Precio"] : oPlataService.Recuperar_Planta(cboItem.SelectedValue.ToString()).Rows[0]["Precio"]; 
                txtPrecio.Text = precio.ToString();
                txtCantidad.Enabled = true;
                txtCantidad.Text = "1";
                int cantidad = 0;
                int.TryParse(txtCantidad.Text, out cantidad);
                txtImporte.Text = (int.Parse(txtPrecio.Text) * cantidad).ToString();
               
            }


         
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()){
                var codigo = int.Parse(cboItem.SelectedValue.ToString());
                var nombre = cboItem.Text.ToString();
                var producto = new Es_Producto();
                var planta = new Es_Planta();
                 flag = rbPlanta.Checked ? true : false;  // bandera para saber si es producto o planta

                if (rbProducto.Checked)
                {
                    producto.Codigo = codigo;
                    producto.Nombre = nombre;
                }else
                {
                    planta.Codigo = codigo.ToString();
                    planta.NombreComun = nombre;
                }
               
                

                listaFacturaDetalle.Add(new Es_DetalleFactura(flag)
                {
                    NroItem = listaFacturaDetalle.Count + 1,
                    Producto = producto,
                    Planta = planta,
                    Cantidad = int.Parse(txtCantidad.Text),
                    Precio = int.Parse(txtPrecio.Text)
                }); 

                CalcularTotales();

                InicializarDetalle();
            }

           


        }

        private void CalcularTotales()
        {
            var importeTotal = listaFacturaDetalle.Sum(p => p.Importe);
            txtTotal.Text = importeTotal.ToString();
        }

        private void InicializarDetalle()
        {
            /*cboItem.SelectedIndex = -1*/;
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtImporte.Text = "";
        }



        public bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCantidad.Text) || int.Parse(txtCantidad.Text) <= 0)
            {
                MessageBox.Show("Ingrese un precio del producto y que sea mayor a 0 por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.BackColor = Color.Red;
                txtCantidad.Focus();
                return false;
            }
            else
                txtCantidad.BackColor = Color.White;

            if (cboItem.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un tipo de producto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //DataTable tabla = new DataTable();
            //tabla = factura.RecuperarCliente(txt_NroDoc.Text.ToString());

            //DataTable tabla2 = new DataTable();
            //tabla2 = factura.RecuperarEmp(txt_IdEmpleado.Text.ToString());

            //DataTable tabla3 = new DataTable();
            //tabla3 = factura.RecuperarTipoDoc(txt_NroDoc.Text.ToString());

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontró el Empleado");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("El cliente no está registrado");
            //}

            try
            {
                var factura = new Es_Factura 
                {
                    Fecha = dtpFecha.Value,
                    Cliente = (Es_Cliente)cboCliente.SelectedItem,
                    Tipo_Factura = (Es_TipoFactura)cboTipoFactura.SelectedItem,
                    FacturaDetalle = listaFacturaDetalle,
                    Monto = double.Parse(txtTotal.Text),
                    //Descuento = double.Parse(txtDescuento.Text)
                    Puntos = int.Parse(txtPuntos.Text)
                };

                if (oFacturaService.ValidarDatos(factura))
                {
                    oFacturaService.Crear(factura);

            //}
            //else
            //{
            //    MessageBox.Show("El cliente no está registrado");
            //}
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.Enabled)
            {
                string seleccionCbo = cboCliente.SelectedValue.ToString();
                Es_Cliente oCliente = new Es_Cliente();
                DataTable clienteSeleccionado = oClienteService.BuscarCliente("", seleccionCbo, "", "", "(1)");
                oCliente.Calle = clienteSeleccionado.Rows[0]["Calle"].ToString();
                oCliente.NroCalle = clienteSeleccionado.Rows[0]["NroCalle"].ToString();
                oCliente.Telefono = clienteSeleccionado.Rows[0]["Telefono"].ToString();
                oCliente.NroDoc = seleccionCbo;

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
