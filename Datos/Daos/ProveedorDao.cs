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
    class ProveedorDao : IProveedor
    {
        public DataTable Proveedores_Activos()
        {
            string consulta = "SELECT * FROM Proveedor WHERE Estado = 1";
            
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable Proveedores_Inactivos()
        {
            string consulta = "SELECT * FROM Proveedor WHERE Estado = 0";
   
            return BDHelper.obtenerInstancia().consultar(consulta);

        }
        public DataTable Buscar_proveedor(string ID_proveedor, string nom_proveedor, string rs_proveedor)
        {
            string consulta = "SELECT * FROM Proveedor WHERE ID LIKE '%" + ID_proveedor + "%' AND Nombre LIKE '%" + nom_proveedor + "%' AND Razon_Social LIKE '%" + rs_proveedor + "%'";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Todos_Los_Proveedores()
        {
            string consulta = "SELECT * FROM Proveedor WHERE Estado = 1 or Estado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public string GetProveedor(string idProveedor)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            string consulta = "SELECT * FROM Proveedor WHERE ID='" + idProveedor + "'";



            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (string)tabla.Rows[0][1];
            else
                return string.Empty;
        }

        public bool Create(Es_Proveedor oProveedor)
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

            string consulta = "INSERT INTO Proveedor (Nombre, Calle, Nro_Calle, Barrio, Localidad, Telefono, Razon_Social, Estado)" +
                            " VALUES (" +
                            "'" + oProveedor.Nombre + "'" + "," +
                            "'" + oProveedor.Calle + "'" + "," +
                            "'" + oProveedor.Nro_Calle + "'" + "," +
                            "'" + oProveedor.Barrio + "'" + "," +
                            "'" + oProveedor.Localidad + "'" + "," +
                            "'" + oProveedor.Telefono + "'" + "," +
                            oProveedor.Razon_Social + " , 1)";
           // "'" + oEmpleado.Estado + " )";
                                 //oUsuario.Perfil.IdPerfil + ",0)";

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
            //return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        //oEmpleado.Nombre = txt_NombreEmpleado.Text;
        //                        oEmpleado.Apellido = txt_ApellidoEmpleado.Text;
        //                        oEmpleado.Contraseña = txtContrasena.Text;
        //                        oEmpleado.TipoDoc = new Es_TipoDoc();
        //oEmpleado.TipoDoc.IdTipoDoc = (int) cboTipoDoc.SelectedValue;
        //oEmpleado.Nro_Doc = txtNroDoc.Text;
        //                        oEmpleado.Calle = txtCalle.Text;
        //                        oEmpleado.Nro_Calle = txtNroCalle.Text;
        //                        oEmpleado.Barrio = txtBarrio.Text;
        //                        oEmpleado.Localidad = txtLocalidad.Text;
        //                        oEmpleado.Estado = "1";

        public bool Update(Es_Proveedor oProveedorSeleccionado)
        {
            string consulta = "UPDATE Empleado " +
                             "SET Nombre=" + "'" + oProveedorSeleccionado.Nombre + "'" + "," +
                             " Calle=" + "'" + oProveedorSeleccionado.Calle + "'" + "," +
                             " Nro_Calle=" + "'" + oProveedorSeleccionado.Nro_Calle + "'" + "," +
                             " Barrio=" + "'" + oProveedorSeleccionado.Barrio + "'" + "," +
                             " Localidad=" + "'" + oProveedorSeleccionado.Localidad + "'" + "," +
                             " Telefono=" + "'" + oProveedorSeleccionado.Telefono + "'" +  "," +
                             " Razon_Social=" + "'" + oProveedorSeleccionado.Razon_Social + "'" + "," +
                             " Estado=" + "'" + oProveedorSeleccionado.Estado +  "'" + 
                             " WHERE ID=" + oProveedorSeleccionado.ID ;

            //TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Barrio, Localidad, Contraseña, Estado

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idProveedor)
        {
            string consulta = "SELECT p.ID, p.Nombre, p.Calle, p.Nro_Calle, b.Nombre AS Barrio, l.Nombre AS Localidad, p.Telefono, p.Razon_Social, p.Estado" +
            " FROM Proveedor p " +
            " JOIN Barrio b ON(b.ID = p.Barrio) " +
           "  JOIN Localidad l ON(l.ID = p.Localidad) " +
           "  WHERE e.ID =" +
              idProveedor;

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public bool Delete(Es_Proveedor oProveedorSeleccionado)
        {
            string consulta = "UPDATE Proveedor " +
                             "SET Estado= '0'" +
                             " WHERE ID=" + oProveedorSeleccionado.ID;

            //TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Barrio, Localidad, Contraseña, Estado

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
    }
}
