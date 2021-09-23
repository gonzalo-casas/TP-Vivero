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
        public DataTable Buscar_proveedor(string ID_proveedor, string nom_proveedor, string rs_proveedor, string estado)
        {

            string consulta = "SELECT * FROM Proveedor WHERE Estado in  " + estado;


            if (!String.IsNullOrEmpty(ID_proveedor))
            {
                consulta += " AND ID LIKE " + ID_proveedor;

            }

            if (!String.IsNullOrEmpty(nom_proveedor))
            {
                consulta += " AND Nombre LIKE " + "'" + nom_proveedor + "'";
            }

            if (!String.IsNullOrEmpty(rs_proveedor))
            {
                consulta += " AND Razon_Social LIKE " + "'" + rs_proveedor + "'";
            }
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
               
        



        public DataTable Todos_Los_Proveedores()
        {
            string consulta = "SELECT * FROM Proveedor WHERE Estado = 1 or Estado = 0";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }


        public bool Create(Es_Proveedor oProveedor)
        {
           

            string consulta = "INSERT INTO Proveedor (Nombre, Calle, Nro_Calle, Barrio, Localidad, Telefono, Razon_Social, Estado)" +
                            " VALUES (" +
                            "'" + oProveedor.Nombre + "'" + "," +
                            "'" + oProveedor.Calle + "'" + "," +
                            "'" + oProveedor.Nro_Calle + "'" + "," +
                            "'" + oProveedor.Barrio.IdBarrio + "'" + "," +
                            "'" + oProveedor.Localidad.IdLocalidad + "'" + "," +
                            "'" + oProveedor.Telefono + "'" + "," +
                            "'" + oProveedor.Razon_Social + "' , 1)";


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }

      

        public bool Update(Es_Proveedor oProveedorSeleccionado)
        {
            string consulta = "UPDATE Proveedor " +
                             "SET Nombre=" + "'" + oProveedorSeleccionado.Nombre + "'" + "," +
                             " Calle=" + "'" + oProveedorSeleccionado.Calle + "'" + "," +
                             " Nro_Calle=" + "'" + oProveedorSeleccionado.Nro_Calle + "'" + "," +
                             " Barrio=" + "'" + oProveedorSeleccionado.Barrio.IdBarrio + "'" + "," +
                             " Localidad=" + "'" + oProveedorSeleccionado.Localidad.IdLocalidad + "'" + "," +
                             " Telefono=" + "'" + oProveedorSeleccionado.Telefono + "'" +  "," +
                             " Razon_Social=" + "'" + oProveedorSeleccionado.Razon_Social + "'" + "," +
                             " Estado=" + "'" + oProveedorSeleccionado.Estado +  "'" + 
                             " WHERE ID=" + oProveedorSeleccionado.ID ;

          

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idProveedor)
        {
            string consulta = "SELECT p.ID, p.Nombre, p.Calle, p.Nro_Calle, b.Nombre AS Barrio, l.Nombre AS Localidad, p.Telefono, p.Razon_Social, p.Estado" +
            " FROM Proveedor p " +
            " JOIN Barrio b ON(b.ID = p.Barrio) " +
           "  JOIN Localidad l ON(l.ID = p.Localidad) " +
           "  WHERE p.ID =" +
              idProveedor;

   
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public bool Delete(Es_Proveedor oProveedorSeleccionado)
        {
            string consulta = "UPDATE Proveedor " +
                             "SET Estado= '0'" +
                             " WHERE ID=" + oProveedorSeleccionado.ID;

          

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
    }
}
