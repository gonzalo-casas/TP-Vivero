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
    class PlantaDao : IPlanta
    {
        public DataTable Buscar_Planta(string Codigo, string NombreComun)
        {
            string sql = "SELECT * FROM Planta WHERE Codigo LIKE '%" + Codigo + "%' AND NombreComun LIKE '%" + NombreComun + "%'";
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }
        public DataTable Recuperar_Planta(string Codigo)
        {
            string sql = ("SELECT * FROM Planta WHERE Codigo = " + Codigo);
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Planta";
            BDHelper.obtenerInstancia().consultar(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }
        public DataTable Plantas_Activas()
        {
            string sql = "SELECT * FROM Planta WHERE Estado = 1";
            DataTable tabla = new DataTable();
            //tabla = _BD.Consulta(sql);
            return BDHelper.obtenerInstancia().consultar(sql);
        }
        public DataTable Plantas_Inactivas()
        {
            string sql = "SELECT * FROM Planta WHERE Estado = 0";
            DataTable tabla = new DataTable();

            return BDHelper.obtenerInstancia().consultar(sql);
        }
        public DataTable Todas_las_Plantas()
        {
            string sql = "SELECT * FROM Planta";
            DataTable tabla = new DataTable();

            return BDHelper.obtenerInstancia().consultar(sql);
        }
        public DataTable Eliminar(string Codigo)
        {
            string sqlEliminar = "UPDATE Planta SET Estado = 0 WHERE Codigo = " + Codigo;
            return BDHelper.obtenerInstancia().consultar(sqlEliminar);

          

        }


        public bool Insertar(Es_Planta datos)
        {
            string consulta = "INSERT INTO Planta (NombreCientifico, NombreComun, Tipo, Precio, Stock,Estado)" +
                            " VALUES (" +
                            "'" + datos.NombreCientifico + "'" + "," +
                            "'" + datos.NombreComun + "'" + "," +
                            "'" + datos.Tipo.Id + "'" + "," +
                            "'" + datos.Precio + "'" + "," +
                            "'" + datos.Stock + "' , 1)";


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta)==1;



        }



        public bool Update(Es_Planta datos)
        {
            string consulta = "UPDATE Planta " +
                             "SET NombreCientifico=" + "'" + datos.NombreCientifico + "'" + "," +
                             " NombreComun=" + "'" + datos.NombreComun + "'" + "," +
                             " Tipo=" + "'" + datos.Tipo.Id + "'" + "," +
                             " Precio=" + "'" + datos.Precio + "'" + "," +
                             " Stock=" + "'" + datos.Stock + "'" + "," +

                             " Estado=" + "'" + datos.Estado + "'" +
                             " WHERE Codigo=" + datos.Codigo;



            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }



        public bool Eliminar(Es_Planta datos)
        {


            string consulta = "UPDATE Planta " +
                            "SET Estado= '0'" +
                            " WHERE Codigo=" + datos.Codigo;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
       







    }
}
