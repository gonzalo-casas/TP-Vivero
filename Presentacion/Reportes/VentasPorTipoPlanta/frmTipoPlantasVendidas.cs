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

namespace Vivero.Presentacion.Reportes
{
    public partial class frmTipoPlantasVendidas : Form
    {
        private readonly IReporte dao;

        public frmTipoPlantasVendidas()
        {
            InitializeComponent();
             dao = new ReporteDao();
        }


        

        private void frmTipoPlantasVendidas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
        }

        
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {
                rpvTipoPlantas.LocalReport.DataSources.Clear();
                rpvTipoPlantas.LocalReport.DataSources.Add(new ReportDataSource("TipoPlantasVendidas", dao.GenerarReporteTipoPlantasVendidas(dtpDesde.Text, dtpHasta.Text)));
                rpvTipoPlantas.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
