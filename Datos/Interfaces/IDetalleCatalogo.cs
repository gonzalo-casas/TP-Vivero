using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Interfaces
{
     interface IDetalleCatalogo
     {
            bool Create(Es_DetalleCatalogo detalleCatalogo);

            DataTable RecuperarPorId(int id_Catalogo);

            bool Delete(Es_DetalleCatalogo oDetalleCatalogo);
     }
    
}
