using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Daos
{
    class DetalleCatalogoDao : IDetalleCatalogo
    {
        public bool Create(Es_DetalleCatalogo oDetalleCatalogo)
        {
            string consulta = "INSERT INTO DetalleCatalogo(ID_Catalogo, id_Planta, Puntos_Necesarios)" +
                 " VALUES (" +
                            "'" + oDetalleCatalogo.ID_Catalogo + "'" + "," +
                            "'" + oDetalleCatalogo.Id_Planta + "'" + "," +
                            "'" + oDetalleCatalogo.Puntos_Necesarios + "' )";

            //"SELECT " + oDetalleCatalogo.ID_Catalogo +  oDetalleCatalogo.Id_Planta+ oDetalleCatalogo.Puntos_Necesarios + " FROM Planta WHERE NombreComun = '" + oDetalleCatalogo.Id_Planta + "'";
            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public bool Delete(Es_DetalleCatalogo oDetalleCatalogo)
        {
            string consulta = "DELETE FROM DetalleCatalogo WHERE ID_Catalogo = " + oDetalleCatalogo.ID_Catalogo;
            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }

        public DataTable RecuperarPorId(int id_Catalogo)
        {
            string consulta = "SELECT pl.Codigo,pl.NombreComun as Planta, Puntos_Necesarios as Puntos  FROM DetalleCatalogo dc JOIN Planta pl ON(dc.id_Planta = pl.Codigo) WHERE ID_Catalogo = " + id_Catalogo;
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
    }
}
