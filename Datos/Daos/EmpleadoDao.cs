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
        public Array ValidarUsuario(int Id_Usuario, string Contrasena)
        {
            string consulta = "SELECT * FROM Empleado WHERE ID=" + Id_Usuario + " AND contraseña='" + Contrasena + "'";

            string[] array;

            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
               return  array = new string [2]{ (string)tabla.Rows[0]["Nombre"].ToString(), (string)tabla.Rows[0]["Perfil"].ToString()};
            else
                return array= new string[1] {string.Empty};
        }

            public DataTable BuscarEmpleado (string ID_emp, string nom_emp, string ap_emp, string estado, string Perfil)
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
            if (!String.IsNullOrEmpty(Perfil))
            {
                consulta += " AND Perfil LIKE " + "'" + Perfil + "'";
            }



            return BDHelper.obtenerInstancia().consultar(consulta);
        }



        public bool Create(Es_Empleado oEmpleado)
        {
           

            string consulta = "INSERT INTO Empleado (TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, Nro_Calle, Barrio, Localidad, Perfil ,Contraseña, Estado)" +
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
                            "'" + oEmpleado.Perfil.IdPerfil + "'" + "," +
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
                             " Perfil=" + "'" + oEmpleadoSeleccionado.Perfil.IdPerfil + "'" + "," +
                             " Contraseña=" + "'" + oEmpleadoSeleccionado.Contraseña + "'" +  "," +
                             " Estado=" + "'" + oEmpleadoSeleccionado.Estado +  "'" + 
                             " WHERE ID=" +  oEmpleadoSeleccionado.ID ;



            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idEmpleado)
        {
            string consulta = "SELECT e.ID, t.Descripcion as TipoDoc, e.NroDoc, e.Nombre, e.Apellido, e.Telefono, e.Calle, e.Nro_Calle, b.Nombre as Barrio, l.Nombre as Localidad, e.Contraseña, e.Estado, p.Descripcion as Perfil" +
            " FROM Empleado e " +
           "  JOIN TipoDoc t ON(t.ID = e.TipoDoc) " +
            " JOIN Barrio b ON(b.ID = e.Barrio) " +
           "  JOIN Localidad l ON(l.ID = e.Localidad) " +
           "  JOIN Perfil p ON(p.ID = e.Perfil) " +
           "  WHERE e.ID =" +
              idEmpleado;


            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Empleado oEmpleadoSeleccionado)
        {
            

            string consulta = "UPDATE Empleado " +
                            "SET Estado= '0'" +
                            " WHERE ID=" + oEmpleadoSeleccionado.ID;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

    }
}
