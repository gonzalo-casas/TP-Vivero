using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio.Servicios
{
    class ComposicionService
    {
        private IComposicion dao;

        public ComposicionService()
        {
            dao = new ComposicionDao();
        }

        internal bool CrearComposicion(Es_Composicion oComposicion)
        {
            return dao.Create(oComposicion);
        }

        internal DataTable RecuperarPorCod(int CodCompuesto)
        {
            return dao.RecuperarPorCod(CodCompuesto);
        }

        internal bool Delete(Es_Composicion oComposicion)
        {
            return dao.Delete(oComposicion);
        }
    }
}
