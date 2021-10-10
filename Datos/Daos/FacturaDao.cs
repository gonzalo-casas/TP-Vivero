using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class FacturaDao : IFactura
    {
        public DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado)
        {
            string consulta = "SELECT * FROM Factura f JOIN  TipoFactura tf ON (f.Tipo_Factura = tf.ID) WHERE f.Estado in  " + estado;


            if (!String.IsNullOrEmpty(nro_factura))
            {
                consulta += " AND f.Nro_Factura LIKE " + nro_factura;

            }

            if (!String.IsNullOrEmpty(nro_doc))
            {
                consulta += " AND f.NroDoc LIKE "  + nro_doc ;
            }

            if (!String.IsNullOrEmpty(id_empleado))
            {
                consulta += " AND f.Id_Empleado LIKE " + id_empleado;
            }
            if (!String.IsNullOrEmpty(fecha.ToString()))
            {
                consulta += " AND f.Fecha = CONVERT(datetime, " +"'" + fecha.ToString() + "', " + "101)";
            }

          
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Buscar_Todas_Facturas()
        {
            string sql = "SELECT * FROM Factura WHERE Tipo_Factura > 0";
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }
    }
}
