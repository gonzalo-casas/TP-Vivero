using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Negocio;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Plantas
{
    public partial class C_Planta : Form
    {
        PlantasService planta = new PlantasService();
        PerfilService oPerfil = new PerfilService();
        public C_Planta()
        {
            InitializeComponent();
        }

        private void Cargar_Grilla(DataTable tabla)
        {
            dvg_Plantas.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dvg_Plantas.Rows.Add();
                dvg_Plantas.Rows[i].Cells[0].Value = tabla.Rows[i]["Codigo"].ToString();
                dvg_Plantas.Rows[i].Cells[1].Value = tabla.Rows[i]["NombreCientifico"].ToString();
                dvg_Plantas.Rows[i].Cells[2].Value = tabla.Rows[i]["NombreComun"].ToString();
                dvg_Plantas.Rows[i].Cells[3].Value = tabla.Rows[i]["Tipo"].ToString();
                dvg_Plantas.Rows[i].Cells[4].Value = tabla.Rows[i]["Precio"].ToString();
                dvg_Plantas.Rows[i].Cells[5].Value = tabla.Rows[i]["Stock"].ToString();
            }
        }



        private void btn_ConsultarPlanta_Click(object sender, EventArgs e)
        {
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(planta.Todas_las_Plantas());
                return;
            }
            if (chk_Activos.Checked == true)
            {
                Cargar_Grilla(planta.Plantas_Activas());
                return;
            }
            if (chk_Inactivos.Checked == true)
            {
                Cargar_Grilla(planta.Plantas_Inactivas());
                return;
            }
            if (txt_IdPlanta.Text == "" && txt_NombrePlanta.Text == "")
            {
                MessageBox.Show("No hay restricciones para realizar la búsqueda");
                return;
            }
            if (txt_IdPlanta.Text != "" || txt_NombrePlanta.Text != "")
            {
                Cargar_Grilla(planta.Buscar_Planta(txt_IdPlanta.Text, txt_NombrePlanta.Text));
                return;
                
            }

        }

        private void btn_EditarPlanta_Click(object sender, EventArgs e)
        {
            var value = dvg_Plantas.CurrentRow.Cells[0].Value.ToString();
            ABM_Planta Modif = new ABM_Planta(int.Parse(value));

            if (dvg_Plantas.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para modificar");
            }
            else
            {

                Modif.SeleccionarOpcion(ABM_Planta.FormMode.update);
                Modif.Codigo = dvg_Plantas.CurrentRow.Cells[0].Value.ToString();
                Modif.ShowDialog();
                Modif.Dispose();
            }
        }
        private void btn_AgregarPlanta_Click(object sender, EventArgs e)
        {
            ABM_Planta fl;
            fl = new ABM_Planta();
            fl.ShowDialog();
        }

        private void btn_EliminarPlanta_Click(object sender, EventArgs e)
        {
            if (dvg_Plantas.CurrentCell.Value == null)
            {
                MessageBox.Show("No se selecciono ninguna planta para eliminar");
            }
            else
            {
                string Codigo = dvg_Plantas.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la planta seleccionada?", "IMPORTANTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    var value = dvg_Plantas.CurrentRow.Cells[0].Value.ToString();
                    ABM_Planta Modif = new ABM_Planta(int.Parse(value));

                    if (dvg_Plantas.CurrentCell.Value == null)
                    {
                        MessageBox.Show("No se selecciono ninguna planta para modificar");
                    }
                    else
                    {

                        Modif.SeleccionarOpcion(ABM_Planta.FormMode.delete);
                        Modif.Codigo = dvg_Plantas.CurrentRow.Cells[0].Value.ToString();
                        Modif.ShowDialog();
                        Modif.Dispose();
                    }
                }
            }

        }

        private void btn_SalirPlanta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_IdPlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
