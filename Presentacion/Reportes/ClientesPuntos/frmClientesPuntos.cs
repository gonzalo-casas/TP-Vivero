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
    public partial class frmClientesPuntos : Form
    {
        private readonly IReporte dao;
        private LocalidadService oLocalidadService;

        public frmClientesPuntos()
        {
            InitializeComponent();
            dao = new ReporteDao();
            oLocalidadService = new LocalidadService();
        }


        DataTable tabla = new DataTable();
        bool flag = true;

        private void frmClientesPuntos_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
          
            tabla.Clear();
            tabla.Columns.Add("ID", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            DataRow filaTodas = tabla.NewRow();
            filaTodas["Nombre"] = "Todas";
            filaTodas["ID"] = "0";
            tabla.Rows.Add(filaTodas);

            LlenarCombo(cboLocalidad, tabla, "Nombre", "ID");

        }


        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {
                
                rpvClientesPuntos.LocalReport.DataSources.Clear();
                rpvClientesPuntos.LocalReport.DataSources.Add(new ReportDataSource("ClientesPuntos", dao.GenerarReporteClientesPuntos(dtpDesde.Text, dtpHasta.Text, cboLocalidad.SelectedValue.ToString())));
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

       

        private void cboLocalidad_Click(object sender, EventArgs e)
        {

        }
    }
}
