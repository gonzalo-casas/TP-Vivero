﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class ReporteDao : IReporte
    {
        public DataTable GenerarReporteProductosVendidos(string Desde, string Hasta)
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
                        WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)
                        GROUP BY p.Codigo, p.Nombre
                        ORDER BY 3 DESC";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }

        public DataTable GenerarReporteVentaEmpleados(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT e.ID, e.NroDoc AS Documento , (e.Nombre + ' ' + e.Apellido) AS Nombre , COUNT(*) AS Ventas
                        FROM Factura f
                        JOIN Empleado e ON (f.Id_Empleado = e.ID)
                        WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)
                        GROUP BY e.ID, e.NroDoc, e.Nombre, e.Apellido
                        ORDER BY 4 DESC";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }
        public DataTable GenerarReporteCatalogosSeleccionados(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT ca.Nombre,P.NombreComun,P.Precio,COUNT(*) AS Cantidad
                           FROM Canje c join Catalogo ca on (c.Id_Catalogo = ca.ID)
                           JOIN Planta P on (c.Id_Planta = p.Codigo )
                           WHERE c.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)
                           GROUP BY ca.Nombre,P.NombreComun,P.Precio
                           ORDER by 4 DESC";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }
        public DataTable GenerarReporteVentasPorAño(string año)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("Año", año);
            
            string sql = @"SELECT DateName(month,DateAdd(month,DATEPART(MONTH,Fecha),0)- 1) as Mes ,COUNT(*) AS Cantidad, SUM(Monto) as 'MontoDelMes'
                           FROM Factura
                           WHERE YEAR (Fecha) = @Año
                           GROUP BY DATEPART(MONTH,Fecha)";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }
    }
}
