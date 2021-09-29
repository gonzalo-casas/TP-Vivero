using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio.Servicios
{
    class CatalogoService
    {
        private ICatalogo dao;
        public CatalogoService() // cto tab tab genera constructor automaticamente
        {
            dao = new CatalogoDao();
        }

        internal bool ActualizarCatalogo(Es_Catalogo oCatalogoSeleccionado)
        {
            return dao.Update(oCatalogoSeleccionado);
        }

        public DataTable Buscar_Catalogo(string ID, string Puntos_Necesarios, string estado)
        {
            return dao.Buscar_Catalogo(ID, Puntos_Necesarios, estado );
        }
        public DataTable Buscar_Planta()
        {
            return dao.Buscar_Planta();
        }

        internal bool CrearCatalogo(Es_Catalogo oCatalogo)
        {
            return dao.Create(oCatalogo);
        }

        public DataTable RecuperarPorId(int idCatalogo,int id_Planta)
        {
            return dao.RecuperarPorId(idCatalogo, id_Planta);
        }

        public bool ModificarEstadoCatalogo(Es_Catalogo oCatalogo)
        {
            return dao.Delete(oCatalogo);
        }
    }
}
