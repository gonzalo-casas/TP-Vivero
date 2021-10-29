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

namespace Vivero.Presentacion.Reportes
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            //this.productoTableAdapter.Fill(this.dSVentas.Producto);
        
            //this.rpvProductos.RefreshReport();
        }

        public DataTable GenerarReporte(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT p.Codigo, p.Nombre, SUM(df.Cantidad) AS Cantidad
                        FROM DetalleFactura df
                        JOIN Factura f ON (df.Nro_Factura = f.Nro_Factura AND df.Tipo_Factura = f.Tipo_Factura)
                        JOIN Producto p ON (p.Codigo = df.Id_Producto)
                        WHERE f.Fecha BETWEEN @FechaDesde AND @FechaHasta
                        GROUP BY p.Codigo, p.Nombre
                        ORDER BY 3 DESC";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Text != "" && dtpHasta.Text != "")
            {

                
                //rpvProductos.LocalReport.SetParameters(new ReportParameter[]{ new
                //ReportParameter("FechaDesde", dtpDesde.Text), new ReportParameter("FechaHasta",
                //dtpHasta.Text) });
                //DATASOURCE

                rpvProductos.LocalReport.DataSources.Clear();
                rpvProductos.LocalReport.DataSources.Add(new ReportDataSource("ProductosVendidos",GenerarReporte(dtpDesde.Text, dtpHasta.Text)));
                rpvProductos.RefreshReport();
            }

        }

        private void btn_SalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
