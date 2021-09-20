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
    class BarrioService
    {
        private IBarrrio dao;
        public BarrioService() // cto tab tab genera constructor automaticamente
        {
            dao = new BarrioDao();
        }

        public DataTable traerTodo()
        {
            return dao.traerTodo();
        }
    }
}
