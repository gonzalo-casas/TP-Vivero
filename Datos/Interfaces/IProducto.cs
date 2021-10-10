using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IProducto
    {
        DataTable Buscar_producto(string codigo, string nom_prod, decimal precio_min, decimal precio_max, string estado);
        bool Create(Es_Producto oProducto);
        bool Update(Es_Producto oProductoSeleccionado);
        bool Delete(Es_Producto oProducto);
        DataTable traerTodo();
        DataTable RecuperarPorCod(int CodProducto);
        DataTable BuscarUnSoloProducto(string nom_prod, int tipo, string stock, string costo, string precio);
    }
}
