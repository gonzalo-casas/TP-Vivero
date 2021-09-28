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

namespace Vivero.Presentacion.Empleados
{
    
    public partial class C_Empleados : Form
    {
        EmpleadoService oEmpleado = new EmpleadoService();
        PerfilService oPerfil = new PerfilService();

        public C_Empleados()
        {
            InitializeComponent();
            
        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            ABM_Empleado fl;
            fl = new ABM_Empleado();
            fl.ShowDialog();
        }

        private void btn_EditarEmpleado_Click(object sender, EventArgs e)
        {
            // tomo el id del empleado seleccionado en la grilla
            if (dgv_Empleados.SelectedRows.Count > 0)
            {
                var value = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
                ABM_Empleado formulario = new ABM_Empleado(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Empleado.FormMode.update);
                formulario.ShowDialog();
                btn_ConsultarEmpleado_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ConsultarEmpleado_Click(object sender, EventArgs e)
        {
            var perfil = cboPerfil.SelectedValue  != null ? cboPerfil.SelectedValue.ToString() : "";
            var estado = "('0','1')";
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == false)
            {
                estado = "('1')";
            }
            if (chk_Activos.Checked == false && chk_Inactivos.Checked == true)
            {
                estado = "('0')";
            }

            Cargar_Grilla(oEmpleado.BuscarEmpleado(txt_IdEmpleado.Text, txt_NombreEmpleado.Text, txt_ApellidoEmpleado.Text, estado, perfil));
            return;

        }

        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Empleados.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Empleados.Rows.Add();
                dgv_Empleados.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                dgv_Empleados.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                dgv_Empleados.Rows[i].Cells[2].Value = tabla.Rows[i]["Apellido"].ToString();
                dgv_Empleados.Rows[i].Cells[3].Value = tabla.Rows[i]["Telefono"].ToString();
                dgv_Empleados.Rows[i].Cells[4].Value = tabla.Rows[i]["Calle"].ToString();
                dgv_Empleados.Rows[i].Cells[5].Value = tabla.Rows[i]["Nro_Calle"].ToString();
            }
        }



        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btn_EliminarEmpleado_Click(object sender, EventArgs e)
        {
            // tomo el id del empleado seleccionado en la grilla
            if (dgv_Empleados.SelectedRows.Count > 0)
            {
                var value = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
                ABM_Empleado formulario = new ABM_Empleado(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Empleado.FormMode.delete);
                formulario.ShowDialog();
                btn_ConsultarEmpleado_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cboPerfil_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, oPerfil.traerTodo(), "Descripcion", "ID");
        }
    }
}
