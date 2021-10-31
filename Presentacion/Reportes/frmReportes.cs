using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivero.Presentacion.Reportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelReportes.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario

            //si el formulario/instancia no existe
            if (formulario == null)
            {
                panelReportes.BringToFront();
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelReportes.Controls.Add(formulario);
                panelReportes.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            panelReportes.SendToBack();
        }

        private void btn_ProductosVendidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProductosVendidos>();
        }

        private void btn_VentaEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentaEmpleados>();
        }

        private void btn_ComprasClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmComprasClientes>();
        }

        private void btn_ClientesPuntos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClientesPuntos>();
        }

        private void btn_TipoFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTipoFacturaCantidad>();
        }

     

        private void btn_PlantasVendidas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPlantasVendidas>();
        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CatalogosSeleccionados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCatalogosSeleccionados>();
        }

        private void btn_VentasPorAño_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVentasPorAño>();
        }
    }
}
