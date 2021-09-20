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
    class TipoDocService
    {
        private ITipoDoc dao;
        public TipoDocService() // cto tab tab genera constructor automaticamente
        {
            dao = new TipoDocDao();
        }

        public DataTable traerTodo()
        {
            return dao.traerTodo();
        }
    }
}
