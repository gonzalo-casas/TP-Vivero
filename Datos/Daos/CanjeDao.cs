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
            string consulta = "SELECT(cl.Nombre + ' ' + cl.Apellido) AS Cliente, cat.Nombre AS NombreCatalogo, p.NombreComun AS Planta, dc.Puntos_Necesarios AS Puntos, ca.Fecha FROM Canje ca JOIN Cliente cl ON(cl.NroDoc = ca.NroDoc AND cl.TipoDoc = ca.TipoDoc) " +
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
            throw new NotImplementedException();
        }

        public bool Delete(Es_Canje canjeSeleccionada)
        {
            throw new NotImplementedException();
        }
    }
}
