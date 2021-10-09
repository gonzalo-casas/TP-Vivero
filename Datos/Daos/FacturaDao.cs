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
        public DataTable Buscar_Todas_Facturas()
        {
            string sql = "SELECT * FROM Factura WHERE Tipo_Factura > 0";
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }
    }
}
