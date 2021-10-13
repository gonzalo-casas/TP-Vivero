using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Datos;
using Vivero.Negocio;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;
using Vivero.Presentacion.Proveedor;

namespace Vivero.Presentacion.Ventas
{

    public partial class C_Ventas : Form
    {
        FacturaService oFactura = new FacturaService();

        public C_Ventas()
        {
            InitializeComponent();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            ABM_Ventas f;
            f = new ABM_Ventas();
            f.ShowDialog();
        }

        private void btn_SalirVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_ConsultarVentas_Click(object sender, EventArgs e)
        {
            var fecha = dtpFecha.Checked.Equals(true) ? dtpFecha.Text : "";

            var estado = "('0','1')";

            Cargar_Grilla(oFactura.BuscarFactura(txt_NroFactura.Text, txt_Documento.Text, txt_Empleado.Text, fecha, estado));
            return;

        }

        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Ventas.Rows.Clear();
            dgv_DetalleFactura.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Ventas.Rows.Add();
                dgv_Ventas.Rows[i].Cells[0].Value = tabla.Rows[i]["Nombre"].ToString(); // es el nombre del tipo factura
                dgv_Ventas.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_Factura"].ToString();
                dgv_Ventas.Rows[i].Cells[2].Value = tabla.Rows[i]["NroDoc"].ToString(); // nro doc del cliente
                dgv_Ventas.Rows[i].Cells[3].Value = tabla.Rows[i]["Fecha"].ToString();
                dgv_Ventas.Rows[i].Cells[4].Value = tabla.Rows[i]["Empleado"].ToString();
                dgv_Ventas.Rows[i].Cells[5].Value = tabla.Rows[i]["Monto"].ToString();
                dgv_Ventas.Rows[i].Cells[6].Value = tabla.Rows[i]["Puntos"].ToString();
            }

            dgv_Ventas.Enabled = true;
            if (dgv_Ventas.RowCount > 0)
            {
                int filaSeleccionada = dgv_Ventas.CurrentCell.RowIndex;
                Cargar_GrillaDetalle(oFactura.BuscarDetalle(dgv_Ventas.Rows[filaSeleccionada].Cells[0].Value.ToString(), dgv_Ventas.Rows[filaSeleccionada].Cells[1].Value.ToString()));
            }
            
        }

        private void Cargar_GrillaDetalle(DataTable tabla)
        {
            dgv_DetalleFactura.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_DetalleFactura.Rows.Add();
                dgv_DetalleFactura.Rows[i].Cells[0].Value = tabla.Rows[i]["NroItem"].ToString(); // es el nombre del tipo factura
                if (tabla.Rows[i]["Nombre_Producto"].ToString() == "")
                {
                    dgv_DetalleFactura.Rows[i].Cells[1].Value = "Planta";
                    dgv_DetalleFactura.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre_Planta"].ToString();
                }
                if (tabla.Rows[i]["Nombre_Planta"].ToString() == "")
                {
                    dgv_DetalleFactura.Rows[i].Cells[1].Value = "Producto";
                    dgv_DetalleFactura.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre_Producto"].ToString();
                }
                //dgv_DetalleFactura.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_Factura"].ToString();
                dgv_DetalleFactura.Rows[i].Cells[3].Value = tabla.Rows[i]["Cantidad"].ToString(); // nro doc del cliente
                dgv_DetalleFactura.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
            }
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgv_Ventas.SelectedRows.Count > 0)
            {
                var value = dgv_Ventas.CurrentRow.Cells[0].Value.ToString();
                ABM_Proveedor formulario = new ABM_Proveedor(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Proveedor.FormMode.delete);
                formulario.ShowDialog();

                btn_ConsultarVentas_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void C_Ventas_Load(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Checked = false;
        }

        private void dgv_Ventas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Ventas.Enabled && dgv_Ventas.RowCount > 1)
            {
                int filaSeleccionada = dgv_Ventas.CurrentCell.RowIndex;
                Cargar_GrillaDetalle(oFactura.BuscarDetalle(dgv_Ventas.Rows[filaSeleccionada].Cells[0].Value.ToString(), dgv_Ventas.Rows[filaSeleccionada].Cells[1].Value.ToString()));
            }
        }
    }
}