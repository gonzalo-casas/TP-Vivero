using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivero.Presentacion.Ventas
{
    public partial class ABM_Ventas : Form
    {
        public ABM_Ventas()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
