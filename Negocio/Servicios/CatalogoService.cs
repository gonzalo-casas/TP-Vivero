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

        public DataTable Buscar_Catalogo(string Nombre, string puntos, string estado)
        {
            return dao.Buscar_Catalogo(Nombre, puntos, estado);
        }
        public DataTable BuscarUnSoloCatalogo(string nom_cat)
        {
            return dao.BuscarUnSoloCatalogo(nom_cat);
        }
        public DataTable Buscar_Planta(string estado)
        {
            return dao.Buscar_Planta(estado);
        }

        internal bool CrearCatalogo(Es_Catalogo oCatalogo)
        {
            return dao.Create(oCatalogo);
        }

        public DataTable RecuperarPorId(int idCatalogo)
        {
            return dao.RecuperarPorId(idCatalogo);
        }

        public bool ModificarEstadoCatalogo(Es_Catalogo oCatalogo)
        {
            return dao.Delete(oCatalogo);
        }
        /*public DataTable Buscar_Catalogo2(string ID) 
        {
            return dao.Buscar_Catalogo2(ID);
        }*/
        public DataTable Buscar_PlantaId(string id_Planta)
        {
            return dao.Buscar_PlantaId(id_Planta);

        }
        public DataTable Buscar_CatalogoId(string nombre)
        {
            return dao.Buscar_CatalogoId(nombre);
        }
    }
}
