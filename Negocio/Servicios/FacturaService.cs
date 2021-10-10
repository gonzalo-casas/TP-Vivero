using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;

namespace Vivero.Negocio.Servicios
{
    class FacturaService
    {
        private IFactura dao;

        public FacturaService() // cto tab tab genera constructor automaticamente
        {
            dao = new FacturaDao();
        }
        public DataTable Buscar_Todas_Facturas()
        {

            return dao.Buscar_Todas_Facturas();
        }

       public DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado)
        {
            return dao.BuscarFactura(nro_factura, nro_doc, id_empleado, fecha, estado);
        }

       
    }
   
}
