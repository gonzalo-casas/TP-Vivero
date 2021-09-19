using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio
{
    class Ng_Empleados
    {


        public DataTable Empleados_Activos()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 1";
            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(sql);
        }
        public DataTable Empleados_Inactivos()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 0";
            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(sql);

        }
        public DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp)
        {
            string sql = "SELECT * FROM Empleado WHERE ID LIKE '%" + ID_emp + "%' AND Nombre LIKE '%" + nom_emp + "%' AND Apellido LIKE '%" + ap_emp + "%'";
            DataTable tabla = new DataTable();
            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(sql);
        }

        public DataTable Todos_Los_Empleados()
        {
            string sql = "SELECT * FROM Empleado WHERE Estado = 1 or Estado = 2";
            DataTable tabla = new DataTable();
            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(sql);
        }
        //public DataTable Todos_Los_Empleados()
        //{
        //    string sql = "SELECT * FROM Empleado WHERE Estado = 1 or Estado = 2";
        //    DBHelper oDatos = new DBHelper();
        //    oDatos = _BD.Consulta(sql);
        //    return oDatos;
        //}
        //public DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp)
        //{
        //    string sql = "SELECT * FROM Empleado WHERE ID LIKE '%" + ID_emp + "%' AND Nombre LIKE '%" + nom_emp + "%' AND Apellido LIKE '%" + ap_emp + "%'";
        //    DBHelper oDatos = new DBHelper();
        //    oDatos = _BD.Consulta(sql);
        //    return oDatos;
        //}





    }
}
