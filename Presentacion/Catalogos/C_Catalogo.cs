using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Catalogos
{
    public partial class C_Catalogo : Form
    {
        CatalogoService oCatalogo = new CatalogoService();
        public C_Catalogo()
        {
            InitializeComponent();
        }

        private void Puntos_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SalirCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AgregarCatalogo_Click(object sender, EventArgs e)
        {
            ABM_Catalogo fl;
            fl = new ABM_Catalogo();
            fl.ShowDialog();
        }
        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Catalogos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Catalogos.Rows.Add();
                dgv_Catalogos.Rows[i].Cells[0].Value = tabla.Rows[i]["ID"].ToString();
                dgv_Catalogos.Rows[i].Cells[1].Value = tabla.Rows[i]["NombreComun"].ToString();
                dgv_Catalogos.Rows[i].Cells[2].Value = tabla.Rows[i]["Puntos_Necesarios"].ToString();

            }
        }

       

        private void btn_EditarCatalogo_Click(object sender, EventArgs e)
        {
          /*  if (dgv_Catalogos.SelectedRows.Count > 0)
            {
                var value = dgv_Catalogos.CurrentRow.Cells[0].Value.ToString();
                ABM_Catalogo formulario = new ABM_Catalogo(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Catalogo.FormMode.update);
                formulario.ShowDialog();
                btn_ConsultarCatalogo_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btn_ConsultarCatalogo_Click(object sender, EventArgs e)
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
            Cargar_Grilla(oCatalogo.Buscar_Catalogo(txt_NumeroID.Text, txt_puntos.Text, estado ));
            return;
        }

        private void btn_EliminarCatalogo_Click(object sender, EventArgs e)
        {
           /* if (dgv_Catalogos.SelectedRows.Count > 0)
            {
                var value = dgv_Catalogos.CurrentRow.Cells[0].Value.ToString();
                ABM_Catalogo formulario = new ABM_Catalogo(int.Parse(value));
                formulario.SeleccionarOpcion(ABM_Catalogo.FormMode.delete);
                formulario.ShowDialog();
                btn_ConsultarCatalogo_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione un Catalogo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    }
    
}
