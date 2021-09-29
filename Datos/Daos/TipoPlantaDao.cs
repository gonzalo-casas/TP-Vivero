using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class TipoPlantaDao : ITipoPlanta
    {
        public DataTable traerTode()
        {
            string consulta = "SELECT * FROM TipoPlanta";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
   
}
