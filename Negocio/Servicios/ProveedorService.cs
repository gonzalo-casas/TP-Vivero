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
    class ProveedorService
    {
        private IProveedor dao;

        public ProveedorService() // cto tab tab genera constructor automaticamente
        {
            dao = new ProveedorDao();
        }


        public DataTable Buscar_proveedor(string ID_emp, string nom_emp, string ap_emp, string estado)
        {
            return dao.Buscar_proveedor(ID_emp, nom_emp, ap_emp, estado);
        }

        internal bool ActualizarProveedor(Es_Proveedor oProveedorSeleccionado)
        {
            return dao.Update(oProveedorSeleccionado);
        }


        internal bool CrearProveedor(Es_Proveedor oProveedor)
        {
            return dao.Create(oProveedor);
        }

        public DataTable RecuperarPorId(int idProveedor)
        {
            return dao.RecuperarPorId(idProveedor);
        }

        public bool ModificarEstadoProveedor(Es_Proveedor oProveedor)
        {
            return dao.Delete(oProveedor);
        }
    }
}
