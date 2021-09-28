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
    class PerfilService
    {
        private IPerfil dao;
        public PerfilService() // cto tab tab genera constructor automaticamente
        {
            dao = new PerfilDao();
        }

        public DataTable traerTodo()
        {
            return dao.traerTodo();
        }
    }
}
