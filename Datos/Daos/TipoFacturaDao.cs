using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class TipoFacturaDao: ITipoFactura
    {
        public DataTable traerTodo()
        {
            string consulta = "SELECT * FROM TipoFactura ";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
