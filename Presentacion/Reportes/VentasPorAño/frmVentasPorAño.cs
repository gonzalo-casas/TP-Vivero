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
    public partial class frmVentasPorAño : Form
    {
        private readonly IReporte dao;

        public frmVentasPorAño()
        {
            InitializeComponent();
             dao = new ReporteDao();
        }


        

        private void frmVentaEmpleados_Load(object sender, EventArgs e)
        {
            Fill_CmbYear();
        }

        
        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (cmbAño.Text != "")
            {

                rpvVentaEmpleados.LocalReport.DataSources.Clear();
                rpvVentaEmpleados.LocalReport.DataSources.Add(new ReportDataSource("VentasPorAño", dao.GenerarReporteVentasPorAño(cmbAño.Text)));
                rpvVentaEmpleados.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Fill_CmbYear()
        {
            try
            {
                //clear all data from combobox
                cmbAño.Items.Clear();
                //add default item
                cmbAño.Text = DateTime.Now.Year.ToString();
                //loop array for add items
                for (int i = DateTime.Now.Year; i > DateTime.Now.Year - 2; i--)
                {
                    cmbAño.Items.Add(i.ToString());
                }
                //set selected item for display on startup
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
