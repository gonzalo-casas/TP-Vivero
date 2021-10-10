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
    class TipoFacturaService
    {
        private ITipoFactura dao;
        public TipoFacturaService() // cto tab tab genera constructor automaticamente
        {
            dao = new TipoFacturaDao();
        }

        public DataTable traerTodo()
        {
            return dao.traerTodo();
        }
    }
}
