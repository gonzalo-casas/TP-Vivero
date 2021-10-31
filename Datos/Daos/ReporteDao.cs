using System;
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

        public DataTable GenerarReporteComprasClientes(string Desde, string Hasta, string valueCbo)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT (c.Apellido + ' ' + c.Nombre) AS Nombre, c.NroDoc AS Documento, l.Nombre AS Localidad, COUNT(*) AS Compras
                           FROM Cliente c
                           JOIN Localidad l ON (l.ID = c.Localidad)
                           JOIN Factura f ON (f.TipoDoc = c.TipoDoc AND f.NroDoc = c.NroDoc) 
                           WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103) ";
            if (valueCbo != "0")
            {
                parametros.Add("Loc", valueCbo);
                sql += "AND l.ID = @Loc ";

            }
            sql += @"AND c.NroDoc <> '0000000'
                     GROUP BY c.Nombre, c.Apellido, c.NroDoc, l.Nombre
                     ORDER BY Compras DESC";
                           
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }

        public DataTable GenerarReporteClientesPuntos(string Desde, string Hasta, string localidad)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT td.Descripcion as TipoDoc, f.NroDoc, (cl.Apellido + ' ' + cl.Nombre) as NombreCliente,  (SUM(f.Puntos ) - ISNULL(SUM(dc.Puntos_Necesarios), 0) ) AS PuntosDisponibles
                            FROM Factura f
                            FULL OUTER JOIN Canje c ON (f.TipoDoc = c.TipoDoc AND f.NroDoc = c.NroDoc)
                            LEFT JOIN DetalleCatalogo dc ON (dc.Id_Planta = c.Id_Planta AND dc.ID_Catalogo = c.Id_Catalogo)
                            LEFT JOIN Cliente  cl ON (f.TipoDoc = cl.TipoDoc AND f.NroDoc = cl.NroDoc)
                            JOIN TipoDoc td ON (f.TipoDoc = td.ID)
                            WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)";

            if (localidad != "0")
            {
                parametros.Add("Loc", localidad);
                sql += "AND cl.localidad = @Loc ";

            }



            sql += @"AND f.NroDoc != 0000000
                            GROUP BY td.Descripcion, f.NroDoc, cl.Apellido, cl.Nombre
                            ORDER BY 4 DESC";


            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }

        public DataTable GenerarReporteTipoFacturaCantidad(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT tf.Nombre , COUNT(f.Tipo_Factura) as Cantidad
                           FROM Factura f
                           JOIN TipoFactura tf ON (f.Tipo_Factura = tf.ID)
                           GROUP BY tf.Nombre";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }
       
        public DataTable GenerarReportePlantasVendidas(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"SELECT p.Codigo, p.NombreCientifico, SUM(df.Cantidad) AS Cantidad
                        FROM DetalleFactura df
                        JOIN Factura f ON (df.Nro_Factura = f.Nro_Factura AND df.Tipo_Factura = f.Tipo_Factura)
                        JOIN Planta p ON (p.Codigo = df.Id_Planta)
                        WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)
                        GROUP BY p.Codigo, p.NombreCientifico
                        ORDER BY 3 DESC";
            DataTable tabla = dm.ConsultaSQLConParametros(sql, parametros);
            dm.Close();
            return tabla;
        }
        
        public DataTable GenerarReporteTipoPlantasVendidas(string Desde, string Hasta)
        {
            DataManager dm = new DataManager();
            dm.Open();
            var parametros = new Dictionary<string, object>();
            parametros.Add("FechaDesde", Desde);
            parametros.Add("FechaHasta", Hasta);
            string sql = @"select Nombre, sum(cantidad) as Cantidad From Planta p 
                        join DetalleFactura d on p.Codigo = d.Id_Planta
                        join TipoPlanta Tp on Tp.ID = P.Tipo
                        join Factura f on d.Nro_Factura = f.Nro_Factura
                        WHERE f.Fecha BETWEEN CONVERT(DATE,@FechaDesde, 103) AND  CONVERT(DATE,@FechaHasta, 103)
                        GROUP BY Tp.Nombre, p.NombreCientifico";
                        
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
