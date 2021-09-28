//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vivero.Presentacion.Clientes
//{
//    public partial class C_Clientes : Form
//    {
//        public C_Clientes()
//        {
//            InitializeComponent();
//        }
//    }
//}

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

namespace Vivero.Presentacion.Clientes
{

    public partial class C_Clientes : Form
    {
        ClienteService oCliente = new ClienteService();
        TipoDocService oTipoDoc = new TipoDocService();

        public C_Clientes()
        {
            InitializeComponent();

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            ABM_Cliente fl;
            fl = new ABM_Cliente();
            fl.ShowDialog();
            btn_ConsultarEmpleado_Click(sender, e);
        }

        private void btn_EditarCliente_Click(object sender, EventArgs e)
        {
            // tomo el tipoDoc y Nro Doc del cliente seleccionado en la grilla
            if (dgv_Clientes.SelectedRows.Count > 0)
            {
                var tipoDoc = dgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                var nroDoc = dgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                ABM_Cliente formulario = new ABM_Cliente(int.Parse(tipoDoc), nroDoc.ToString());
                formulario.SeleccionarOpcion(ABM_Cliente.FormMode.update);
                formulario.ShowDialog();
                btn_ConsultarEmpleado_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultarEmpleado_Click(object sender, EventArgs e)
        {
            var tipoDoc = cboTipoDoc.SelectedValue != null ? cboTipoDoc.SelectedValue.ToString() : "";
            var estado = "('0','1')";
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == false)
            {
                estado = "('1')";
            }
            if (chk_Activos.Checked == false && chk_Inactivos.Checked == true)
            {
                estado = "('0')";
            }

            Cargar_Grilla(oCliente.BuscarCliente(tipoDoc, txtNroDoc.Text, txt_NombreCliente.Text, txt_ApellidoCliente.Text, estado));
            return;

        }

        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Clientes.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Clientes.Rows.Add();
                dgv_Clientes.Rows[i].Cells[0].Value = tabla.Rows[i]["TipoDoc"].ToString();
                dgv_Clientes.Rows[i].Cells[1].Value = tabla.Rows[i]["NroDoc"].ToString();
                dgv_Clientes.Rows[i].Cells[2].Value = tabla.Rows[i]["Nombre"].ToString();
                dgv_Clientes.Rows[i].Cells[3].Value = tabla.Rows[i]["Apellido"].ToString();
                dgv_Clientes.Rows[i].Cells[4].Value = tabla.Rows[i]["Calle"].ToString();
                dgv_Clientes.Rows[i].Cells[5].Value = tabla.Rows[i]["NroCalle"].ToString();
            }
        }



        private void C_Clientes_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipoDoc, oTipoDoc.traerTodo(), "Descripcion", "ID");
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }


        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            // tomo el id del empleado seleccionado en la grilla
            if (dgv_Clientes.SelectedRows.Count > 0)
            {

                var tipoDoc = dgv_Clientes.CurrentRow.Cells[0].Value.ToString();
                var nroDoc = dgv_Clientes.CurrentRow.Cells[1].Value.ToString();
                ABM_Cliente formulario = new ABM_Cliente(int.Parse(tipoDoc), nroDoc.ToString());
                formulario.SeleccionarOpcion(ABM_Cliente.FormMode.delete);
                formulario.ShowDialog();
                btn_ConsultarEmpleado_Click(sender, e);


            }
            else
            {
                MessageBox.Show("Seleccione un Cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }


}

