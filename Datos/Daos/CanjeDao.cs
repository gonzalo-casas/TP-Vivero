using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Daos
{
    class CanjeDao : ICanje
    {
        public DataTable BuscarCanje(string nombreApellido, string nro_doc, string nombreComun, string fecha, string estado)
        {
            string consulta = "SELECT ca.ID, (cl.Nombre + ' ' + cl.Apellido) AS Cliente, cat.Nombre AS NombreCatalogo, p.NombreComun AS Planta, dc.Puntos_Necesarios AS Puntos, ca.Fecha FROM Canje ca JOIN Cliente cl ON(cl.NroDoc = ca.NroDoc AND cl.TipoDoc = ca.TipoDoc) " +
                             " JOIN Catalogo cat ON(cat.ID = ca.Id_Catalogo) JOIN Planta p ON(p.Codigo = ca.Id_Planta)   JOIN DetalleCatalogo dc ON(dc.Id_Planta = ca.Id_Planta AND dc.ID_Catalogo = ca.Id_Catalogo) " +
                             " WHERE ca.Estado in  " + estado;



            if (!String.IsNullOrEmpty(nombreApellido))
            {
                consulta += " AND (cl.Nombre LIKE '%" + nombreApellido + "%' " + " OR cl.Apellido LIKE '%" + nombreApellido + "%') ";
                //consulta += " AND f.Nro_Factura LIKE '" + nro_factura + "%'";


            }

            if (!String.IsNullOrEmpty(nro_doc))
            {
                consulta += " AND cl.NroDoc LIKE '%" + nro_doc + "%'";
            }

            if (!String.IsNullOrEmpty(nombreComun))
            {
                consulta += " AND p.NombreComun LIKE '%" + nombreComun + "%'";
            }
            if (!String.IsNullOrEmpty(fecha.ToString()))
            {
                consulta += " AND ca.Fecha = CONVERT(datetime, " + "'" + fecha.ToString() + "', " + "103)";
            }

            consulta += " ORDER BY Fecha DESC";


            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Create(Es_Canje canje)
        {
            try
            {
                BDHelper.obtenerInstancia().Open();
                BDHelper.obtenerInstancia().BeginTransaction();

                string consulta = @"INSERT INTO Canje(TipoDoc,NroDoc,Id_Catalogo,Id_Planta,Fecha,Estado)
                                    VALUES (" + canje.TipoDoc + "," + canje.NroDoc +"," + canje.Id_Catalogo +"," + canje.Id_Planta + ",TRY_PARSE('" + canje.Fecha +"' AS DATETIME USING 'en-gb'),1)";

                BDHelper.obtenerInstancia().EjecutarSQL(consulta);

                string sacarStock = @"UPDATE Planta
                                      SET Stock = Stock - 1
                                      WHERE Codigo = " + canje.Id_Planta;

                BDHelper.obtenerInstancia().EjecutarSQL(sacarStock);
                BDHelper.obtenerInstancia().Commit();
            }
            catch (Exception ex)
            {
                BDHelper.obtenerInstancia().Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                BDHelper.obtenerInstancia().Close();
            }
            return true;
        }

        public bool Delete(string idCanje)
        {
            try
            {
                BDHelper.obtenerInstancia().Open();

                string recuperarCanje = @"SELECT * FROM Canje WHERE ID = " + idCanje;
                DataTable canje = BDHelper.obtenerInstancia().consultar(recuperarCanje);
                BDHelper.obtenerInstancia().BeginTransaction();

                string anular = @"UPDATE Canje
                                    SET Estado = 0 
                                    WHERE ID = " + idCanje;

                BDHelper.obtenerInstancia().EjecutarSQL(anular);

                string idPlanta = canje.Rows[0]["Id_Planta"].ToString();

                string devolverStock = @"UPDATE Planta
                                         SET Stock = Stock + 1
                                         WHERE Codigo = " + idPlanta;
                BDHelper.obtenerInstancia().EjecutarSQL(devolverStock);
                BDHelper.obtenerInstancia().Commit();
            }
            catch (Exception ex)
            {
                BDHelper.obtenerInstancia().Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                BDHelper.obtenerInstancia().Close();
            }
            return true;
        }

        public string ObtenerPuntosCliente(int idTipoDoc, string nroDoc)
        {
            
            string puntosGastados = @"SELECT SUM(dc.Puntos_Necesarios) AS PuntosGastados
                                    FROM Cliente cl
                                    LEFT JOIN Canje c ON(cl.TipoDoc = c.TipoDoc AND cl.NroDoc = c.NroDoc)
                                    JOIN DetalleCatalogo dc ON(dc.Id_Planta = c.Id_Planta AND dc.ID_Catalogo = c.Id_Catalogo)
                                    WHERE c.Estado = 1 AND cl.TipoDoc = " + idTipoDoc + " AND cl.NroDoc like '%" + nroDoc + "%'";

            DataTable tablaGastados = BDHelper.obtenerInstancia().consultar(puntosGastados);

            string puntosObtenidos = @"SELECT SUM(f.Puntos) AS PuntosObtenidos
                                     FROM Factura f
                                     WHERE f.Estado = 1
                                     AND f.TipoDoc = " + idTipoDoc +
                                     " AND f.NroDoc like '%" + nroDoc + "%'";

            DataTable tablaObtenidos = BDHelper.obtenerInstancia().consultar(puntosObtenidos);


            string res = (Int32.Parse(tablaObtenidos.Rows[0][0].ToString()) - Int32.Parse(tablaGastados.Rows[0][0].ToString())).ToString();
            return res;
        }

        public List<string> TraerPuntosStock(string catalogo, string planta)
        {
            string consulta = @"SELECT dc.Puntos_Necesarios, p.Stock
                                FROM Catalogo c
                                JOIN DetalleCatalogo dc ON (dc.ID_Catalogo = c.ID)
                                JOIN Planta p ON (p.Codigo = dc.Id_Planta)
                                WHERE c.ID = " + catalogo +
                                " AND p.Codigo = " + planta;

            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);

            List<string> lista = new List<string>();
            lista.Add(tabla.Rows[0]["Puntos_Necesarios"].ToString());
            lista.Add(tabla.Rows[0]["Stock"].ToString());
            return lista;
        }

        public DataTable TraerPlantasCatalogo(string catalogo)
        {
            string consulta = @"SELECT *
                                FROM Planta p
                                JOIN DetalleCatalogo dc ON (dc.Id_Planta = p.Codigo)
                                WHERE dc.ID_Catalogo = " + catalogo;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
