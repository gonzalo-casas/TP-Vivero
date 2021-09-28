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
    class ComposicionDao : IComposicion
    {
        public bool Create(Es_Composicion oComposicion)
        {

            string consulta = "INSERT INTO Composicion(Cod_Prod_Compuesto, Cod_Prod_Componente, Cant_Componente) SELECT " + oComposicion.Cod_Prod_Compuesto + " AS Compuesto, Codigo AS Componente, " + oComposicion.Cant_Componente + "AS Cantidad FROM Producto WHERE Nombre = '" + oComposicion.Cod_Prod_Componente + "'";
            //string consulta = "INSERT INTO Composicion (Cod_Prod_Compuesto, Cod_Prod_Componente, Cant_Componente)" +
            //                " VALUES (" +
            //                "'" + oComposicion.Cod_Prod_Compuesto + "'" + "," +
            //                "'" + oComposicion.Cod_Prod_Componente + "'" + "," +
            //                "'" + oComposicion.Cant_Componente + "')";

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }

        public DataTable RecuperarPorCod(int CodCompuesto)
        {
            string consulta = "SELECT p.Nombre AS Componente, Cant_Componente FROM Composicion c JOIN Producto p ON(c.Cod_Prod_Componente = p.Codigo) WHERE Cod_Prod_Compuesto = " + CodCompuesto;
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Composicion oComposicion)
        {
            string consulta = "DELETE FROM Composicion WHERE Cod_Prod_Compuesto = " + oComposicion.Cod_Prod_Compuesto;
            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }
    }
}
