using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IEmpleado
    {
        DataTable Empleados_Activos();
        DataTable Empleados_Inactivos();
        DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp);
        DataTable Todos_Los_Empleados();
        Es_Empleado GetUserSinParametros(string nombreUsuario);
    }
}
