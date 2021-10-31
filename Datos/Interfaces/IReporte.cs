using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Datos.Interfaces
{
    interface IReporte
    {
        DataTable GenerarReporteProductosVendidos(string Desde, string Hasta);

        DataTable GenerarReporteVentaEmpleados(string Desde, string Hasta);

        DataTable GenerarReporteComprasClientes(string Desde, string Hasta, string valueCbo);

        DataTable GenerarReporteClientesPuntos(string Desde, string Hasta, string localidad);

        DataTable GenerarReporteTipoFacturaCantidad(string Desde, string Hasta);

        DataTable GenerarReportePlantasVendidas(string Desde, string Hasta);

        DataTable GenerarReporteCatalogosSeleccionados(string Desde, string Hasta);

        DataTable GenerarReporteVentasPorAño(string Año);

        DataTable GenerarReporteTipoPlantasVendidas(string Desde, string Hasta);

        
    }
}
