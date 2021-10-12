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
            string consulta = "SELECT tf.Nombre, Nro_Factura, f.NroDoc, f.Fecha, (e.Nombre + ' ' + e.Apellido) AS Empleado, Monto, Puntos FROM Factura f JOIN  TipoFactura tf ON (f.Tipo_Factura = tf.ID) " +
                              "JOIN Empleado e ON (e.ID = f.Id_Empleado) WHERE f.Estado in  " + estado;


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
                consulta += " AND f.Fecha = CONVERT(datetime, " +"'" + fecha.ToString() + "', " + "103)";
            }

          
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Buscar_Todas_Facturas()
        {
            string sql = "SELECT * FROM Factura WHERE Tipo_Factura > 0";
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }



        public DataTable RecuperarCliente(string dni)
        {
            string sql = "SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'";
            return BDHelper.obtenerInstancia().consultar(sql);


        }
        public DataTable RecuperarTipoDoc(string dni)
        {

            string sql = "SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'";
            return BDHelper.obtenerInstancia().consultar(sql);

        }

        public DataTable RecuperarEmp(string ID)
        {

            string sql = ("SELECT * FROM Empleado WHERE ID = " + ID);
            return BDHelper.obtenerInstancia().consultar(sql);
            //ojo capaz aca a la izquierda del ID le falte + "'"

        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Factura";
            tabla = BDHelper.obtenerInstancia().consultar(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }

       




    }
}
