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
        ClienteService oClienteService = new ClienteService();
        PlantasService oPlataService;
        Es_Cliente oCliente = new Es_Cliente();
        CatalogoService oCatalogoService = new CatalogoService();
        CanjeService oCanjeService = new CanjeService();
        public ABM_Canje()
        {
            InitializeComponent();
            oPlataService = new PlantasService();
            oCanjeService = new CanjeService();

        }

        private void ABM_Ventas_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCliente, oClienteService.traerTodo(), "FullName", "NroDoc");
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblNroDoc.Visible = false;
            dtpFecha.MaxDate = DateTime.Today;
            cboCliente.Enabled = true;
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
            if (cboCatalogo.Enabled.Equals(true))
            {
                cboPlanta.Enabled = false;
                cboPlanta.DataSource =  new DataTable();
                txtPuntos.Text = "";
                txtStock.Text = "";
                LlenarCombo(cboPlanta, oCanjeService.TraerPlantasCatalogo(cboCatalogo.SelectedValue.ToString()), "NombreComun", "Codigo");
                cboPlanta.Enabled = true;
                if ( cboCatalogo.SelectedIndex != -1 && cboPlanta.SelectedIndex != -1)
                {

                    LlenarPuntosStock(cboCatalogo.SelectedValue.ToString(), cboPlanta.SelectedValue.ToString());
                }

            }

        }

        public void LlenarPuntosStock(string catalogo, string planta)
        {
            List<string> lista = oCanjeService.TraerPuntosStock(catalogo, planta);

            txtPuntos.Text = lista[0];
            txtStock.Text = lista[1];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarCamposCanje())

            try
            {
                    Es_Canje oCanje = new Es_Canje();
                    oCanje.TipoDoc = oCliente.TipoDoc.IdTipoDoc.ToString();
                    oCanje.NroDoc = oCliente.NroDoc;
                    oCanje.Id_Catalogo = cboCatalogo.SelectedValue.ToString();
                    oCanje.Id_Planta = cboPlanta.SelectedValue.ToString();
                    oCanje.Fecha = dtpFecha.Text + " " +dtpHora.Text;

                    oCanjeService.Create(oCanje);
                    MessageBox.Show("Canje registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el canje " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCamposCanje()
        {

            if (cboCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un Cliente por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboCatalogo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un catalogo por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cboPlanta.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione una planta por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Int32.Parse(lblPuntos.Text) < Int32.Parse(txtPuntos.Text))
            {
                MessageBox.Show("El cliente no cuenta con los puntos suficientes para canjear esa planta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                lblPuntos.Text = oCanjeService.ObtenerPuntosCliente(oCliente.TipoDoc.IdTipoDoc, oCliente.NroDoc);
                
                if (!lblDireccion.Visible) lblDireccion.Visible = true;
                if (!lblTelefono.Visible) lblTelefono.Visible = true;
                if (!lblNroDoc.Visible) lblNroDoc.Visible = true;

                if (!cboCatalogo.Enabled)
                {
                LlenarCombo(cboCatalogo, oCatalogoService.Buscar_Catalogo("", "", "('1')"), "Nombre", "ID");
                cboCatalogo.Enabled = true;

                }

            }

        }

        private void cboPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlanta.Enabled.Equals(true) && cboCatalogo.SelectedIndex != -1 && cboPlanta.SelectedIndex != -1)
            {
                LlenarPuntosStock(cboCatalogo.SelectedValue.ToString(), cboPlanta.SelectedValue.ToString());
            }
        }
    } 
}
