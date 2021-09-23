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
            //InitializeDataGridView();
        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            ABM_Empleado fl;
            fl = new ABM_Empleado();
            fl.ShowDialog();
        }

        private void btn_EditarEmpleado_Click(object sender, EventArgs e)
        {
            
            var value = dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
            ABM_Proveedor formulario = new ABM_Proveedor(int.Parse(value));
            //var empleado = (Es_Empleado)dgv_Empleados.CurrentRow.DataBoundItem;
            formulario.SeleccionarProveedor(ABM_Proveedor.FormMode.update);
            formulario.ShowDialog();
            btn_ConsultarEmpleado_Click(sender, e);
        }

        private void btn_SalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ConsultarEmpleado_Click(object sender, EventArgs e)
        {
            var estado = "('0')";
            if (chk_Activos.Checked == true)
            {
                estado = "('1')";
            }
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == true)
            {
                estado = "('1','2')";
            }

            if (txt_IdProveedor.Text != "" || txt_Rs_Proveedor.Text != "" || txt_NombreProveedor.Text != "")
            {
                Cargar_Grilla(oProveedor.Buscar_proveedor(txt_IdProveedor.Text, txt_NombreProveedor.Text, txt_Rs_Proveedor.Text));
                return;
            }


            if (chk_Activos.Checked == true && chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(oProveedor.Todos_Los_Proveedores());
                return;
            }

            if (chk_Activos.Checked == true)
            {
                Cargar_Grilla(oProveedor.Proveedores_Activos());
                return;
            }
            if (chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(oProveedor.Proveedores_Inactivos());
                return;
            }



            if (txt_IdProveedor.Text == "" || txt_Rs_Proveedor.Text == "" || txt_NombreProveedor.Text == "")
            {
                Cargar_Grilla(oProveedor.Todos_Los_Proveedores());
            }
        }






        //{
        //    if (chk_Activos.Checked == true)
        //    {
        //        Cargar_Grilla(oProveedor.Proveedores_Activos());
        //        return;
        //    }
        //    if (chk_Inactivos.Checked == true)
        //    {
        //        Cargar_Grilla(oProveedor.Proveedores_Inactivos());
        //        return;
        //    }
        //    if (txt_IdProveedor.Text != "" || txt_Rs_Proveedor.Text != "" || txt_NombreProveedor.Text != "")
        //    {
        //        Cargar_Grilla(oProveedor.Buscar_proveedor(txt_IdProveedor.Text, txt_NombreProveedor.Text, txt_Rs_Proveedor.Text));
        //    }
        //    if (txt_IdProveedor.Text == "" || txt_Rs_Proveedor.Text == "" || txt_NombreProveedor.Text == "")
        //    {
        //        Cargar_Grilla(oProveedor.Todos_Los_Proveedores());
        //    }
        //}

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

        private void ABMC_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarEmpleado_Click(object sender, EventArgs e)
        {
            var value = dgv_Proveedores.CurrentRow.Cells[0].Value.ToString();
            ABM_Empleado formulario = new ABM_Empleado(int.Parse(value));
            //var empleado = (Es_Empleado)dgv_Empleados.CurrentRow.DataBoundItem;
            formulario.SeleccionarEmpleado(ABM_Empleado.FormMode.delete);
            formulario.ShowDialog();
            btn_ConsultarEmpleado_Click(sender, e);
        }

        //private void InitializeDataGridView()
        //{
        //    // Cree un DataGridView no vinculado declarando un recuento de columnas.
        //    dgv_Empleados.ColumnCount = 3;
        //    dgv_Empleados.ColumnHeadersVisible = true;

        //    // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
        //    dgv_Empleados.AutoGenerateColumns = false;

        //    // Cambia el estilo de la cabecera de la grilla.
        //    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

        //    columnHeaderStyle.BackColor = Color.Beige;
        //    columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
        //    dgv_Empleados.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

        //    // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
        //    dgv_Empleados.Columns[0].Name = "Usuario";
        //    dgv_Empleados.Columns[0].DataPropertyName = "NombreUsuario";
        //    // Definimos el ancho de la columna.

        //    dgv_Empleados.Columns[1].Name = "Email";
        //    dgv_Empleados.Columns[1].DataPropertyName = "Email";

        //    dgv_Empleados.Columns[2].Name = "Perfil";
        //    dgv_Empleados.Columns[2].DataPropertyName = "Perfil";

        //    // Cambia el tamaño de la altura de los encabezados de columna.
        //    dgv_Empleados.AutoResizeColumnHeadersHeight();

        //    // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
        //    dgv_Empleados.AutoResizeRows(
        //        DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        //}

    }
}
