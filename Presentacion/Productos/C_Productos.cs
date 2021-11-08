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
using Vivero.Presentacion.Producto;
using Vivero.Presentacion.Productos;

namespace Vivero.Presentacion.Productos
{

    public partial class C_Productos : Form
    {
        ProductoService oProducto = new ProductoService();

        public C_Productos()
        {
            InitializeComponent();
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            ABM_Producto fl;
            fl = new ABM_Producto();
            fl.ShowDialog();
        }

        private void btn_EditarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.SelectedRows.Count > 0)
            {
                var value = dgv_Productos.CurrentRow.Cells[0].Value.ToString();
                ABM_Producto formulario = new ABM_Producto(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Producto.FormMode.update);
                formulario.ShowDialog();
                btn_ConsultarProducto_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SalirProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultarProducto_Click(object sender, EventArgs e)
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

            Cargar_Grilla(oProducto.Buscar_producto(txt_CodProducto.Text, txt_NombreProducto.Text, numericUpDownPrecioMin.Value, numericUpDownPrecioMax.Value, estado));
            return;

        }
        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Productos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Productos.Rows.Add();
                dgv_Productos.Rows[i].Cells[0].Value = tabla.Rows[i]["Codigo"].ToString();
                dgv_Productos.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                dgv_Productos.Rows[i].Cells[2].Value = tabla.Rows[i]["Stock"].ToString();
                dgv_Productos.Rows[i].Cells[3].Value = tabla.Rows[i]["Costo"].ToString();
                dgv_Productos.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
                //dgv_Productos.Rows[i].Cells[5].Value = tabla.Rows[i]["Tipo"].ToString();
            }
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.SelectedRows.Count > 0)
            {
                var value = dgv_Productos.CurrentRow.Cells[0].Value.ToString();
                ABM_Producto formulario = new ABM_Producto(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Producto.FormMode.delete);
                formulario.ShowDialog();
                btn_ConsultarProducto_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_CodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
