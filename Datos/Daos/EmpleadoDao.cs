using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;

namespace Vivero.Datos.Daos
{
    class EmpleadoDao : IEmpleado
    {

        public DataTable Empleados_Activos()
        {
            string consulta = "SELECT * FROM Empleado WHERE Estado = 1";
            
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable Empleados_Inactivos()
        {
            string consulta = "SELECT * FROM Empleado WHERE Estado = 0";
   
            return BDHelper.obtenerInstancia().consultar(consulta);

        }
        public DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp)
        {
            string consulta = "SELECT * FROM Empleado WHERE ID LIKE '%" + ID_emp + "%' AND Nombre LIKE '%" + nom_emp + "%' AND Apellido LIKE '%" + ap_emp + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Todos_Los_Empleados()
        {
            string consulta = "SELECT * FROM Empleado WHERE Estado = 1 or Estado = 2";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
