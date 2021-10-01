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
        public DataTable Buscar_Catalogo(string Nombre,string puntos, string estado)
        {

            string consulta = "  select c.ID,c.Nombre,pl.NombreComun as Planta,dt.Puntos_Necesarios as Puntos from DetalleCatalogo dt join Catalogo c on (dt.ID_Catalogo = c.ID) JOIN Planta pl on(dt.Id_Planta = pl.Codigo) WHERE c.Estado in  " + estado;

            if (!String.IsNullOrEmpty(Nombre))
            {
                consulta += " AND Nombre LIKE " + "'" + Nombre + "'" ;

            }
            if (!String.IsNullOrEmpty(puntos))
            {
                consulta += " AND Puntos_Necesarios LIKE " + puntos ;

            }
            return BDHelper.obtenerInstancia().consultar(consulta);
        }



        public bool Create(Es_Catalogo oCatalogo)
        {
            string consulta = "INSERT INTO Catalogo (Nombre, Estado) " +
                " VALUES (" +
                            "'" + oCatalogo.Nombre + "' , 1)";
                           

            /*string consulta = "INSERT INTO Catalogo  (ID,Id_Planta,Puntos_Necesarios, Estado)" +
                            " VALUES (" +
                            "'" + oCatalogo.ID + "'" + "," +
                           "'" + oCatalogo.Id_Planta + "'" + "," +
                           //"'" + oPlanta.NombreComun + "'" + "," +
                            "'" + oCatalogo.Puntos_Necesarios + "' , 1)";*/


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }


        public bool Update(Es_Catalogo oCatalogoSeleccionado)
        {
            string consulta = "UPDATE Catalogo " +
                             "SET Nombre =" + "'" + oCatalogoSeleccionado.Nombre + "'" + "," +
                             " Estado=" + "'" + oCatalogoSeleccionado.Estado + "'" +
                             " WHERE ID =" + oCatalogoSeleccionado.ID;
                             



            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorId(int idCatalogo)
        {
            //  string consulta = "SELECT c.ID,c.Id_Planta,c.Puntos_Necesarios,c.Estado" +
            //  " FROM Catalogo c " +
            // "  JOIN Planta pl ON(c.Id_Planta = pl.Codigo) " +
            // "  WHERE c.ID =" + idCatalogo;
            // "AND Id_Planta="+ id_Planta;

            string consulta = "SELECT c.ID, c.Nombre, c.Estado" +
           " FROM Catalogo c " +
           " WHERE ID =" +
             idCatalogo;


            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Catalogo oCatalogoSeleccionado)
        {


            string consulta = "UPDATE Catalogo " +
                            "SET Estado = '0'" +
                            " WHERE ID =" + oCatalogoSeleccionado.ID;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
        /*public DataTable Buscar_Catalogo2(string ID)
        {

            string consulta = "SELECT * FROM Catalogo c JOIN Planta p on (c.Id_Planta = p.Codigo) WHERE ID LIKE  "+ ID ;


                        
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        */
        public DataTable BuscarUnSoloCatalogo(string nom_cat)
        {
            string consulta = "SELECT TOP 1 * FROM Catalogo WHERE Nombre = '" + nom_cat+"'";
              

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Buscar_Planta(string estado)
        {
            string consulta = "SELECT NombreComun as Planta FROM Planta where Estado = "+ estado ;
            

            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable Buscar_PlantaId(string nombre) 
        {
            string consulta = "SELECT Codigo FROM Planta WHERE NombreComun ="+"'" + nombre +"'";


            return BDHelper.obtenerInstancia().consultar(consulta);


        }
        public DataTable Buscar_CatalogoId(string nombre)
        {
            string consulta = "SELECT ID FROM Catalogo WHERE Nombre =" + "'" + nombre + "'";


            return BDHelper.obtenerInstancia().consultar(consulta);


        }
    }
}
