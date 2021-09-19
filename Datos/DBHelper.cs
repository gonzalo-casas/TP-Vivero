using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Datos
{
    class BDHelper
    {

        private static BDHelper instancia; // patron singleton

        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private BDHelper() // constructor privado de la clase
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = @"Data Source = SQL5108.site4now.net; Initial Catalog = db_a79e23_vivero; User Id = db_a79e23_vivero_admin; Password=grupo10pav";
        }

        public static BDHelper obtenerInstancia()
        {
            if (instancia == null) // las referencias a objetos se las evalua como nulas y no empty
            {
                instancia = new BDHelper();

            }
            return instancia;
        }

        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();

            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();

            return tabla;
        }
    }
}
