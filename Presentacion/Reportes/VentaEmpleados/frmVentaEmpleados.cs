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
    public partial class frmVentaEmpleados : Form
    {
        private readonly IReporte dao;

        public frmVentaEmpleados()
        {
            InitializeComponent();
             dao = new ReporteDao();
        }


        

        private void frmVentaEmpleados_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
        }

        
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {

                rpvVentaEmpleados.LocalReport.DataSources.Clear();
                rpvVentaEmpleados.LocalReport.DataSources.Add(new ReportDataSource("VentaEmpleados", dao.GenerarReporteVentaEmpleados(dtpDesde.Text, dtpHasta.Text)));
                rpvVentaEmpleados.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
