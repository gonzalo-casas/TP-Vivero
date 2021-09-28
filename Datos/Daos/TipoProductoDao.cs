using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class TipoProductoDao : ITipoProducto
    {
        public DataTable TraerTodo()
        {
            string consulta = "SELECT * FROM TipoProducto ";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
