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
        FacturaService factura = new FacturaService();

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
            {
                if (txt_Documento.Text == "" && chk_Todos.Checked == false)
                {
                    MessageBox.Show("No hay restricciones para realizar la búsqueda");
                    return;
                }
                if (chk_Todos.Checked == true)
                {
                    Cargar_Grilla(factura.Buscar_Todas_Facturas());
                    return;
                }
                //if (txt_Documento.Text != "")
                //{
                //    Cargar_Grilla(factura.Buscar_Factura(txt_NroDoc.Text));
                //    return;
                //}
            }
            //{
            //    if (txt_NroDoc.Text == "" && chk_Activos.Checked == false)
            //    {
            //        MessageBox.Show("No hay restricciones para realizar la búsqueda");
            //        return;
            //    }
            //    if (chk_Todos.Checked == true)
            //    {
            //        Cargar_Grilla(factura.Buscar_Todas_Facturas());
            //        return;
            //    }
            //    if (txt_NroDoc.Text != "")
            //    {
            //        Cargar_Grilla(factura.Buscar_Factura(txt_NroDoc.Text));
            //        return;
            //    }
            //}

            //Cargar_Grilla(oProveedor.Buscar_proveedor(txt_IdProveedor.Text, txt_NombreProveedor.Text, txt_Rs_Proveedor.Text, estado));
            return;
        }
        //private void Cargar_Grilla(DataTable tabla)
        //{
        //    dgv_Proveedores.Rows.Clear();

        //    for (int i = 0; i < tabla.Rows.Count; i++)
        //    {
        //        dgv_Proveedores.Rows.Add();
        //        dgv_Proveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
        //        dgv_Proveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
        //        dgv_Proveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["Calle"].ToString();
        //        dgv_Proveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["Nro_Calle"].ToString();
        //        dgv_Proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["Telefono"].ToString();
        //        dgv_Proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["Razon_Social"].ToString();
        //    }
        //}
        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Ventas.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Ventas.Rows.Add();
                dgv_Ventas.Rows[i].Cells[0].Value = tabla.Rows[i]["Tipo_Factura"].ToString();
                dgv_Ventas.Rows[i].Cells[1].Value = tabla.Rows[i]["Nro_Factura"].ToString();
                dgv_Ventas.Rows[i].Cells[2].Value = tabla.Rows[i]["TipoDoc"].ToString();
                dgv_Ventas.Rows[i].Cells[3].Value = tabla.Rows[i]["NroDoc"].ToString();
                dgv_Ventas.Rows[i].Cells[4].Value = tabla.Rows[i]["Fecha"].ToString();
                dgv_Ventas.Rows[i].Cells[5].Value = tabla.Rows[i]["Id_Empleado"].ToString();
                dgv_Ventas.Rows[i].Cells[6].Value = tabla.Rows[i]["Monto"].ToString();
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
    }
}