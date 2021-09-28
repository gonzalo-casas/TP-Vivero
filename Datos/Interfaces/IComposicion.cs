using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IComposicion
    {
        bool Create(Es_Composicion composicion);

        DataTable RecuperarPorCod(int CodCompuesto);

        bool Delete(Es_Composicion oComposicion);
    }
}
