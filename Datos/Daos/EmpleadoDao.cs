using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.EstructuraNegocio;

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

        public Es_Empleado GetUserSinParametros(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String consulta = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        estado, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre as perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE u.borrado =0 ");

            consulta += " AND usuario=" + "'" + nombreUsuario + "'";


            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = BDHelper.obtenerInstancia().consultar(consulta);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        private Es_Empleado ObjectMapping(DataRow row)
        {
            Es_Empleado oEmpleado = new Es_Empleado
            {
                //ID = Convert.ToInt32(row["ID"].ToString()),
                //TipoDoc = row["TipoDoc"].ToString(),
                //NroDoc = row["NroDoc"].ToString(),
                //Nombre = row["Nombre"].ToString(),
                //Apellido = row["Apellido"].ToString(),
                //Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,

                
            };

            return oEmpleado;
        }

    }
}
