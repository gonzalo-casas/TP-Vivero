﻿using System;
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
        DataTable Buscar_proveedor(string ID_emp, string nom_emp, string ap_emp, string estado);
        DataTable Todos_Los_Proveedores();
        bool Create(Es_Proveedor oProveedor);
        bool Update(Es_Proveedor oProveedorSeleccionado);
        bool Delete(Es_Proveedor oProveedor);
        DataTable RecuperarPorId(int idProveedor);
    }
}
