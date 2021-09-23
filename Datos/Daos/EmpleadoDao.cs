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

        public DataTable BuscarEmpleado (string ID_emp, string nom_emp, string ap_emp, string estado)
        {
           
            string consulta = "SELECT * FROM Empleado WHERE Estado in  " + estado;
            

            if (!String.IsNullOrEmpty(ID_emp))
            {
                consulta += " AND ID LIKE " + ID_emp;

            } 

            if (!String.IsNullOrEmpty(nom_emp))
            {
                consulta += " AND Nombre LIKE " + "'" + nom_emp + "'";
            }

            if (!String.IsNullOrEmpty(ap_emp))
            {
                consulta += " AND Apellido LIKE " + "'" + ap_emp + "'";
            }



            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Todos_Los_Empleados()
        {
            string consulta = "SELECT * FROM Empleado WHERE Estado = 1 or Estado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public string GetUserSinParametros(string nombreUsuario, string Contrasena)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            string consulta = "SELECT * FROM Empleado WHERE nombre='" + nombreUsuario + "' AND contraseña='" + Contrasena + "'";



            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (string)tabla.Rows[0][1];
            else
                return string.Empty;
        }

        public bool Create(Es_Empleado oEmpleado)
        {
            //CON PARAMETROS
            //string str_sql = "     INSERT INTO Usuarios (usuario, password, email, id_perfil, estado, borrado)" +
            //                 "     VALUES (@usuario, @password, @email, @id_perfil, 'S', 0)";

            // var parametros = new Dictionary<string, object>();
            //parametros.Add("usuario", oUsuario.NombreUsuario);
            //parametros.Add("password", oUsuario.Password);
            //parametros.Add("email", oUsuario.Email);
            //parametros.Add("id_perfil", oUsuario.Perfil.IdPerfil);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            //con parametros
            //return (DBHelper.GetDBHelper().EjecutarSQLConParametros(str_sql, parametros) == 1);

            //SIN PARAMETROS

            string consulta = "INSERT INTO Empleado (TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Barrio, Localidad, Contraseña, Estado)" +
                            " VALUES (" +
                            "'" + oEmpleado.TipoDoc.IdTipoDoc + "'" + "," +
                            "'" + oEmpleado.Nro_Doc + "'" + "," +
                            "'" + oEmpleado.Nombre + "'" + "," +
                            "'" + oEmpleado.Apellido + "'" + "," +
                            "'" + oEmpleado.Telefono + "'" + "," +
                            "'" + oEmpleado.Calle + "'" + "," +
                            "'" + oEmpleado.Nro_Calle + "'" + "," +
                            "'" + oEmpleado.Barrio.IdBarrio + "'" + "," +
                            "'" + oEmpleado.Localidad.IdLocalidad + "'" + "," +
                            "'" + oEmpleado.Contraseña  +"' , 1)";
          
            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
            
        }

       
        public bool Update(Es_Empleado oEmpleadoSeleccionado)
        {
            string consulta = "UPDATE Empleado " +
                             "SET TipoDoc=" + "'" + oEmpleadoSeleccionado.TipoDoc.IdTipoDoc + "'" + "," +
                             " NroDoc=" + "'" + oEmpleadoSeleccionado.Contraseña + "'" + "," +
                             " Nombre=" + "'" + oEmpleadoSeleccionado.Nombre + "'" + "," +
                             " Apellido=" + "'" + oEmpleadoSeleccionado.Apellido + "'" + "," +
                             " Telefono=" + "'" + oEmpleadoSeleccionado.Telefono + "'" + "," +
                             " Calle=" + "'" + oEmpleadoSeleccionado.Calle + "'" +  "," +
                             " Nro_Calle=" + "'" + oEmpleadoSeleccionado.Nro_Calle + "'" + "," +
                             " Barrio=" + "'" + oEmpleadoSeleccionado.Barrio.IdBarrio + "'" +  "," +
                             " Localidad=" + "'" + oEmpleadoSeleccionado.Localidad.IdLocalidad + "'" + "," +
                             " Contraseña=" + "'" + oEmpleadoSeleccionado.Contraseña + "'" +  "," +
                             " Estado=" + "'" + 1 +  "'" + 
                             " WHERE ID=" +  oEmpleadoSeleccionado.ID ;

            //TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Barrio, Localidad, Contraseña, Estado

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idEmpleado)
        {
            string consulta = "SELECT e.ID, t.Descripcion as TipoDoc, e.NroDoc, e.Nombre, e.Apellido, e.Telefono, e.Calle, e.Nro_Calle, b.Nombre as Barrio, l.Nombre as Localidad, e.Contraseña, e.Estado" +
            " FROM Empleado e " +
           "  JOIN TipoDoc t ON(t.ID = e.TipoDoc) " +
            " JOIN Barrio b ON(b.ID = e.Barrio) " +
           "  JOIN Localidad l ON(l.ID = e.Localidad) " +
           "  WHERE e.ID =" +
              idEmpleado;


            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Empleado oEmpleadoSeleccionado)
        {
            string consulta = "UPDATE Empleado " +
                             "SET TipoDoc=" + "'" + oEmpleadoSeleccionado.TipoDoc.IdTipoDoc + "'" + "," +
                             " NroDoc=" + "'" + oEmpleadoSeleccionado.Contraseña + "'" + "," +
                             " Nombre=" + "'" + oEmpleadoSeleccionado.Nombre + "'" + "," +
                             " Apellido=" + "'" + oEmpleadoSeleccionado.Apellido + "'" + "," +
                             " Telefono=" + "'" + oEmpleadoSeleccionado.Telefono + "'" + "," +
                             " Calle=" + "'" + oEmpleadoSeleccionado.Calle + "'" + "," +
                             " Nro_Calle=" + "'" + oEmpleadoSeleccionado.Nro_Calle + "'" + "," +
                             " Barrio=" + "'" + oEmpleadoSeleccionado.Barrio.IdBarrio + "'" + "," +
                             " Localidad=" + "'" + oEmpleadoSeleccionado.Localidad.IdLocalidad + "'" + "," +
                             " Contraseña=" + "'" + oEmpleadoSeleccionado.Contraseña + "'" + "," +
                             " Estado=" + "'" + 0 + "'" +
                             " WHERE ID=" + oEmpleadoSeleccionado.ID;

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

    }
}
