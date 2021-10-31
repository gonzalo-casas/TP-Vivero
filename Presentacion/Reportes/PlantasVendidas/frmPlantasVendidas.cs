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
    public partial class frmPlantasVendidas : Form
    {
        private readonly IReporte dao;

        public frmPlantasVendidas()
        {
            InitializeComponent();
             dao = new ReporteDao();
        }


        

        private void frmPlantasVendidas_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        }

        
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {
                rpvPlantas.LocalReport.DataSources.Clear();
                rpvPlantas.LocalReport.DataSources.Add(new ReportDataSource("PlantasVendidas", dao.GenerarReportePlantasVendidas(dtpDesde.Text, dtpHasta.Text)));
                rpvPlantas.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
