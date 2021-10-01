using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class EstadoPlantaDao : IEstadoPlanta
    {
        public DataTable traerTode()
        {
            string consulta = "SELECT * FROM Estado ";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
