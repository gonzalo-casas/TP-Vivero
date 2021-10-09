using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Datos.Interfaces
{
    interface IFactura
    {
        DataTable Buscar_Todas_Facturas();
    }
}
