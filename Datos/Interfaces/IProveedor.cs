using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IProveedor
    {
        DataTable Proveedores_Activos();
        DataTable Proveedores_Inactivos();
        DataTable Buscar_proveedor(string ID_emp, string nom_emp, string ap_emp);
        DataTable Todos_Los_Proveedores();
        string GetUserSinParametros(string nombre, string contrasena);
        bool Create(Es_Proveedor oProveedor);
        bool Update(Es_Proveedor oProveedorSeleccionado);
        DataTable RecuperarPorId(int idProveedor);
    }
}
