using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.Servicios
{
    class DetalleCatalogoService
    {
        private IDetalleCatalogo dao;

        public DetalleCatalogoService()
        {
            dao = new DetalleCatalogoDao();
        }

        internal bool CrearDetalleCatalogo(Es_DetalleCatalogo oDetalleCatalogo)
        {
            return dao.Create(oDetalleCatalogo);
        }

        internal DataTable RecuperarPorId(int id_Catalogo)
        {
            return dao.RecuperarPorId(id_Catalogo);
        }

        internal bool Delete(Es_DetalleCatalogo oDetalleCatalogo)
        {
            return dao.Delete(oDetalleCatalogo);
        }
    }


}

