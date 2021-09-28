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
    class CatalogoDao : ICatalogo
    {
        public DataTable Buscar_Planta()
        {
            string consulta = "SELECT NombreComun FROM Planta WHERE Estado = 1 ";
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable Buscar_Catalogo(string ID, string Puntos_Necesarios, string estado)
        {

            string consulta = "SELECT * FROM Catalogo c JOIN Planta p on (c.Id_Planta = p.Codigo) WHERE c.Estado in  " + estado;


            if (!String.IsNullOrEmpty(ID))
            {
                consulta += " AND ID LIKE " + ID;

            }


            if (!String.IsNullOrEmpty(Puntos_Necesarios))
            {
                consulta += " AND Puntos_Necesarios LIKE " + "'" + Puntos_Necesarios + "'";
            }
           
            return BDHelper.obtenerInstancia().consultar(consulta);
        }



        public bool Create(Es_Catalogo oCatalogo)
        {


            string consulta = "INSERT INTO Catalogo  (ID,Puntos_Necesarios, Estado)" +
                            " VALUES (" +
                            "'" + oCatalogo.ID + "'" + "," +
                           "'" + oCatalogo.Id_Planta + "'" + "," +
                           //"'" + oPlanta.NombreComun + "'" + "," +
                            "'" + oCatalogo.Puntos_Necesarios + "' , 1)";


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }


        public bool Update(Es_Catalogo oCatalogoSeleccionado)
        {
            string consulta = "UPDATE Catalogo " +
                             "SET Puntos_Necesarios =" + "'" + oCatalogoSeleccionado.Puntos_Necesarios + "'" + "," +
                             " Estado=" + "'" + oCatalogoSeleccionado.Estado + "'" +
                             " WHERE ID =" + oCatalogoSeleccionado.ID +
                             " and Id_Planta ="+ oCatalogoSeleccionado.Id_Planta;



            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idCatalogo,int id_Planta)
        {
            string consulta = "SELECT c.ID,c.Id_Planta,c.Puntos_Necesarios,c.Estado" +
            " FROM Catalogo c " +
           "  JOIN Planta pl ON(c.Id_Planta = pl.Codigo) " +
           "  WHERE c.ID ="+ idCatalogo +
              "AND Id_Planta="+ id_Planta;


            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Catalogo oCatalogoSeleccionado)
        {


            string consulta = "UPDATE Catalogo " +
                            "SET Estado= '0'" +
                            " WHERE ID=" + oCatalogoSeleccionado.ID;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
    }
}
