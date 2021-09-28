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
    class TipoProductoService
    {
        private ITipoProducto dao;
        public TipoProductoService()
        {
            dao = new TipoProductoDao();
        }

        public DataTable TraerTodo()
        {
            return dao.TraerTodo();
        }
    }
}
