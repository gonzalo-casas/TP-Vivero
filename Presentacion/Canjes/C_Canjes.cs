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
using Vivero.Negocio.Entidades;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;
using Vivero.Presentacion.Canjes;

namespace Vivero.Presentacion.Canjes
{

    public partial class C_Canjes : Form
    {
        FacturaService oFactura = new FacturaService();

        public C_Canjes()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ABM_Canje f;
            f = new ABM_Canje();
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
            if (chk_Activos.Checked == true && chk_Inactivos.Checked == false)
            {
                estado = "('1')";
            }
            if (chk_Activos.Checked == false && chk_Inactivos.Checked == true)
            {
                estado = "('0')";
            }

            Cargar_Grilla(oFactura.BuscarFactura(txt_NroCanje.Text, txt_Documento.Text, txt_Planta.Text, fecha, estado));
            return;

        }

        private void Cargar_Grilla(DataTable tabla)
        {
            dgv_Canjes.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgv_Canjes.Rows.Add();
                dgv_Canjes.Rows[i].Cells[0].Value = tabla.Rows[i]["NroCanje"].ToString(); // es el nombre del tipo factura
                dgv_Canjes.Rows[i].Cells[1].Value = tabla.Rows[i]["NroDoc"].ToString();
                dgv_Canjes.Rows[i].Cells[2].Value = tabla.Rows[i]["Catalogo"].ToString(); // nro doc del cliente
                dgv_Canjes.Rows[i].Cells[3].Value = tabla.Rows[i]["Nombre_Comun"].ToString();
                dgv_Canjes.Rows[i].Cells[4].Value = tabla.Rows[i]["Fecha"].ToString();
                dgv_Canjes.Rows[i].Cells[5].Value = tabla.Rows[i]["Fecha"].ToString();
            }

            dgv_Canjes.Enabled = true;  
        }

        private void C_Ventas_Load(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.MaxDate = DateTime.Today;
            dtpFecha.Checked = false;
        }
     
        private void AnularBoton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea anular la factura seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {



                var tipoFactura = oFactura.RecuperarTipoFactura(dgv_Canjes.CurrentRow.Cells[0].Value.ToString()).Rows[0][0].ToString();
               


                Es_Factura FacturaSeleccionada = new Es_Factura();
                FacturaSeleccionada.Tipo_Factura = new Es_TipoFactura();
                FacturaSeleccionada.Numero_Factura = int.Parse(dgv_Canjes.CurrentRow.Cells[1].Value.ToString());
                FacturaSeleccionada.Tipo_Factura.ID = int.Parse(tipoFactura);



                if (oFactura.Anular(FacturaSeleccionada))
                {
                    MessageBox.Show("Factura anulada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al anular la factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}