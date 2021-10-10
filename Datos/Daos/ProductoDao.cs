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
    class ProductoDao : IProducto
    {
        public DataTable Buscar_producto(string codigo, string nom_prod, decimal precio_min, decimal precio_max, string estado)
        {

            string consulta = "SELECT * FROM Producto WHERE Estado in  " + estado;


            if (!String.IsNullOrEmpty(codigo))
            {
                consulta += " AND Codigo LIKE " + codigo;

            }

            if (!String.IsNullOrEmpty(nom_prod))
            {
                consulta += " AND Nombre LIKE " + "'" + nom_prod + "'";
            }

            if (precio_min != 0 && precio_max != 0)
            {
                consulta += "AND Precio BETWEEN " + precio_min + "AND" + precio_max;
            }
            else
            {
                if (precio_min !=0)
                {
                    consulta += "AND Precio >=" + precio_min;
                }
                if (precio_max !=0)
                {
                    consulta += "AND Precio <=" + precio_max;
                }
            }

            //if (!String.IsNullOrEmpty(rs_proveedor))
            //{
            //    consulta += " AND Razon_Social LIKE " + "'" + rs_proveedor + "'";
            //}
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable BuscarUnSoloProducto(string nom_prod, int tipo, string stock, string costo, string precio)
        {
            string consulta = "SELECT TOP 1 * FROM Producto WHERE Nombre = '" + nom_prod
                + "' AND Tipo = " + tipo + " AND Stock = " + stock + " AND Costo = " + costo + " AND Precio = " + precio;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Create(Es_Producto oProducto)
        {


            string consulta = "INSERT INTO Producto (Nombre, Tipo, Stock, Costo, Precio, Estado)" +
                            " VALUES (" +
                            "'" + oProducto.Nombre + "'" + "," +
                            "'" + oProducto.Tipo.ID + "'" + "," +
                            "'" + oProducto.Stock + "'" + "," +
                            "'" + oProducto.Costo + "'" + "," +
                            "'" + oProducto.Precio + "' , 1)";

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }

        public bool Update(Es_Producto oProductoSeleccionado)
        {
            string consulta = "UPDATE Producto " +
                             "SET Nombre=" + "'" + oProductoSeleccionado.Nombre + "'" + "," +
                             " Tipo=" + "'" + oProductoSeleccionado.Tipo.ID + "'" + "," +
                             " Stock=" + "'" + oProductoSeleccionado.Stock + "'" + "," +
                             " Costo=" + "'" + oProductoSeleccionado.Costo + "'" + "," +
                             " Precio=" + "'" + oProductoSeleccionado.Precio + "'" + "," +
                             " Estado=" + "'" + oProductoSeleccionado.Estado + "'" +
                             " WHERE Codigo=" + oProductoSeleccionado.Codigo;

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public bool Delete(Es_Producto oProductoSeleccionado)
        {
            string consulta = "UPDATE Producto " +
                             "SET Estado= '0'" +
                             " WHERE Codigo=" + oProductoSeleccionado.Codigo;

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorCod(int CodProducto)
        {
            string consulta = "SELECT p.Codigo, p.Nombre, tp.Nombre AS Tipo, p.Stock, p.Costo, p.Precio, p.Estado" +
            " FROM Producto p " +
            " JOIN TipoProducto tp ON (tp.ID = p.Tipo) " +
            " WHERE Codigo =" +
              CodProducto;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable traerTodo()
        {
            string consulta = "SELECT * FROM Producto ";

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        //falta recuperar Composicion de producto
    }
}
