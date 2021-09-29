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
    class TipoPlantaService
    {
        private ITipoPlanta dao;
        public TipoPlantaService() // cto tab tab genera constructor automaticamente
        {
            dao = new TipoPlantaDao();
        }

        public DataTable traerTode()
        {
            return dao.traerTode();
        }

        internal object Todos_Tipos_Plantas()
        {
            throw new NotImplementedException();
        }
    }
}
