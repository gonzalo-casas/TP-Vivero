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

namespace Vivero.Negocio
{
    class EmpleadoService
    {

        private IEmpleado dao;
        public EmpleadoService() // cto tab tab genera constructor automaticamente
        {
            dao = new EmpleadoDao();
        }

        public DataTable Empleados_Activos()
        {
            return dao.Empleados_Activos();
        }

        public DataTable Empleados_Inactivos()
        {
            return dao.Empleados_Inactivos();

        }
        public DataTable Buscar_empleado(string ID_emp, string nom_emp, string ap_emp)
        {
            return dao.Buscar_empleado(ID_emp, nom_emp, ap_emp);
        }
        public ObtenerEmpleado(string usuario)
        {
            //SIN PARAMETROS
            return dao.GetUserSinParametros(usuario);

            //CON PARAMETROS
            // return oUsuarioDao.GetUserConParametros(usuario);
        }
        public DataTable Todos_Los_Empleados()
        {
            return dao.Todos_Los_Empleados();
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
