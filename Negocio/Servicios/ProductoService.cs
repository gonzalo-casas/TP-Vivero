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
    class ProductoService
    {
        private IProducto dao;

        public ProductoService()
        {
            dao = new ProductoDao();
        }

        public DataTable Buscar_producto(string codigo, string nom_prod, decimal precio_min, decimal precio_max, string estado)
        {
            return dao.Buscar_producto(codigo, nom_prod, precio_min, precio_max, estado);
        }

        public DataTable BuscarUnSoloProducto(string nom_prod, int tipo, string stock, string costo, string precio)
        {
            return dao.BuscarUnSoloProducto(nom_prod, tipo, stock, costo, precio);
        }

        internal bool ActualizarProducto(Es_Producto oProductoSeleccionado)
        {
            return dao.Update(oProductoSeleccionado);
        }


        internal bool CrearProducto(Es_Producto oProducto)
        {
            return dao.Create(oProducto);
        }

        public DataTable RecuperarPorCod(int codigo)
        {
            return dao.RecuperarPorCod(codigo);
        }

        public bool ModificarEstadoProducto(Es_Producto oProducto)
        {
            return dao.Delete(oProducto);
        }
    }
}
