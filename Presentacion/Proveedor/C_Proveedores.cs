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

namespace Vivero.Presentacion.Empleados
{
    
    public partial class ABMC_Proveedores : Form
    {
        ProveedorService oProveedor = new ProveedorService();

        public ABMC_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            ABM_Proveedor fl;
            fl = new ABM_Proveedor();
            fl.ShowDialog();
        }

        private void btn_EditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgv_Proveedores.SelectedRows.Count > 0)
            {
                var value = dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
                ABM_Proveedor formulario = new ABM_Proveedor(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Proveedor.FormMode.update);
                formulario.ShowDialog();
                btn_ConsultarProveedor_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SalirProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ConsultarProveedor_Click(object sender, EventArgs e)
        {
            var estado = "('0','1')";
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == false)
            {
                estado = "('1')";
            }
            if (chk_Activos.Checked == false && chk_Inactivos.Checked == true)
            {
                estado = "('0')";
            }

            Cargar_Grilla(oProveedor.Buscar_proveedor(txt_IdProveedor.Text, txt_NombreProveedor.Text, txt_Rs_Proveedor.Text, estado));
             return;

        }


        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Proveedores.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Proveedores.Rows.Add();
                dgv_Proveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                dgv_Proveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                dgv_Proveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["Calle"].ToString();
                dgv_Proveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["Nro_Calle"].ToString();
                dgv_Proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["Telefono"].ToString();
                dgv_Proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["Razon_Social"].ToString();
            }
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgv_Proveedores.SelectedRows.Count > 0)
            {
                var value = dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
                ABM_Proveedor formulario = new ABM_Proveedor(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Proveedor.FormMode.delete);
                formulario.ShowDialog();
                btn_ConsultarProveedor_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
