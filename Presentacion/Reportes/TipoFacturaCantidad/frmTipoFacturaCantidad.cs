using Microsoft.Reporting.WinForms;
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
using Vivero.Datos.Interfaces;
using Vivero.Datos.Daos;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Reportes
{
    public partial class frmTipoFacturaCantidad : Form
    {
        private readonly IReporte dao;


        public frmTipoFacturaCantidad()
        {
            InitializeComponent();
            dao = new ReporteDao();
        }


        private void frmTipoFacturaCantidad_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
          
        }


        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {
                
                rpvClientesPuntos.LocalReport.DataSources.Clear();
                rpvClientesPuntos.LocalReport.DataSources.Add(new ReportDataSource("TipoFacturaCantidad", dao.GenerarReporteTipoFacturaCantidad(dtpDesde.Text, dtpHasta.Text)));
                rpvClientesPuntos.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarCombo(ComboBox cbo, DataTable source, string display, String value)
        {
           
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = 0;


        }


    }
}
