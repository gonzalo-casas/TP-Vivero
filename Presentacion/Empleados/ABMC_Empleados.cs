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

namespace Vivero.Presentacion.Empleados
{
    
    public partial class ABMC_Empleados : Form
    {
        EmpleadoService oEmpleado = new EmpleadoService ();

        public ABMC_Empleados()
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
            var value = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
            ABM_Empleado formulario = new ABM_Empleado(int.Parse(value));
            formulario.SeleccionarEmpleado(ABM_Empleado.FormMode.update);
            formulario.ShowDialog();
            btn_ConsultarEmpleado_Click(sender, e);
        }

        private void btn_SalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_ConsultarEmpleado_Click(object sender, EventArgs e)
        {
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(oEmpleado.Todos_Los_Empleados());
                return;
            }

            if (chk_Activos.Checked == true)
            {
                Cargar_Grilla(oEmpleado.Empleados_Activos());
                return;
            }
            if (chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(oEmpleado.Empleados_Inactivos());
                return;
            }
            if (txt_IdEmpleado.Text != "" || txt_ApellidoEmpleado.Text != "" || txt_NombreEmpleado.Text != "")
            {
                Cargar_Grilla(oEmpleado.Buscar_empleado(txt_IdEmpleado.Text, txt_NombreEmpleado.Text, txt_ApellidoEmpleado.Text));
            }


            if (txt_IdEmpleado.Text == "" || txt_ApellidoEmpleado.Text == "" || txt_NombreEmpleado.Text == "")
            {
                Cargar_Grilla(oEmpleado.Todos_Los_Empleados());
            }
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

        private void ABMC_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarEmpleado_Click(object sender, EventArgs e)
        {
            // tomo el id del empleado seleccionado en la grilla
            var value = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
            ABM_Empleado formulario = new ABM_Empleado(int.Parse(value));
            formulario.SeleccionarEmpleado(ABM_Empleado.FormMode.delete);
            formulario.ShowDialog();
            btn_ConsultarEmpleado_Click(sender, e);
        }

        

    }
}
