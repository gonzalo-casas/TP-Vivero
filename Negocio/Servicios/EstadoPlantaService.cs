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
    class EstadoPlantaService
    {
        private IEstadoPlanta dao;
        public EstadoPlantaService() // cto tab tab genera constructor automaticamente
        {
            dao = new EstadoPlantaDao();
        }

        public DataTable traerTode()
        {
            return dao.traerTode();
        }
    }
}
