//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Vivero.Datos.Daos
//{
//    class ClienteDao
//    {

//    }
//}

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
    class ClienteDao : ICliente
    {
        public DataTable BuscarCliente(string TipoDoc, string NroDoc, string Nombre, string Apellido, string estado)
        {

            string consulta = "SELECT * FROM Cliente WHERE Estado in  " + estado;


            if (!String.IsNullOrEmpty(TipoDoc))
            {
                consulta += " AND TipoDoc LIKE " + TipoDoc;

            }
            if (!String.IsNullOrEmpty(NroDoc))
            {
                consulta += " AND NroDoc LIKE " + "'" + NroDoc + "%'";

            }


            if (!String.IsNullOrEmpty(Nombre))
            {
                consulta += " AND Nombre LIKE " + "'" + Nombre + "%'";
            }

            if (!String.IsNullOrEmpty(Apellido))
            {
                consulta += " AND Apellido LIKE " + "'" + Apellido + "%'";
            }




            return BDHelper.obtenerInstancia().consultar(consulta);
        }



        public bool Create(Es_Cliente oCliente)
        {


            string consulta = "INSERT INTO Cliente (TipoDoc, NroDoc, Nombre, Apellido, Telefono, Calle, NroCalle, Barrio, Localidad, Estado)" +
                            " VALUES (" +
                            "'" + oCliente.TipoDoc.IdTipoDoc + "'" + "," +
                            "'" + oCliente.NroDoc + "'" + "," +
                            "'" + oCliente.Nombre + "'" + "," +
                            "'" + oCliente.Apellido + "'" + "," +
                            "'" + oCliente.Telefono + "'" + "," +
                            "'" + oCliente.Calle + "'" + "," +
                            "'" + oCliente.NroCalle + "'" + "," +
                            "'" + oCliente.Barrio.IdBarrio + "'" + "," +
                            "'" + oCliente.Localidad.IdLocalidad + "' , 1)";

            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;

        }


        public bool Update(Es_Cliente oClienteSeleccionado)
        {
            string consulta = "UPDATE Cliente " +
                             " SET Nombre=" + "'" + oClienteSeleccionado.Nombre + "'" + "," +
                             " Apellido=" + "'" + oClienteSeleccionado.Apellido + "'" + "," +
                             " Telefono=" + "'" + oClienteSeleccionado.Telefono + "'" + "," +
                             " Calle=" + "'" + oClienteSeleccionado.Calle + "'" + "," +
                             " NroCalle=" + "'" + oClienteSeleccionado.NroCalle + "'" + "," +
                             " Barrio=" + "'" + oClienteSeleccionado.Barrio.IdBarrio + "'" + "," +
                             " Localidad=" + "'" + oClienteSeleccionado.Localidad.IdLocalidad + "'" + "," +
                             " Estado=" + "'" + oClienteSeleccionado.Estado + "'" +
                             " WHERE TipoDoc=" + oClienteSeleccionado.TipoDoc.IdTipoDoc +
                             " AND  NroDoc=" + oClienteSeleccionado.NroDoc;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }

        public DataTable RecuperarPorTipoDoc_NroDoc(int TipoDoc, string NroDoc)
        {
            string consulta = "SELECT  t.Descripcion as TipoDoc, c.NroDoc, c.Nombre, c.Apellido, c.Telefono, c.Calle, c.NroCalle, b.Nombre as Barrio, l.Nombre as Localidad, c.Estado" +
            " FROM Cliente c " +
           "  JOIN TipoDoc t ON(t.ID = c.TipoDoc) " +
            " JOIN Barrio b ON(b.ID = c.Barrio) " +
           "  JOIN Localidad l ON(l.ID = c.Localidad) " +
           " WHERE TipoDoc=" + TipoDoc +
           " AND  NroDoc=" + NroDoc;

            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public bool Delete(Es_Cliente oClienteSeleccionado)
        {


            string consulta = "UPDATE Cliente " +
                            "SET Estado= '0'" +
                            " WHERE TipoDoc=" + oClienteSeleccionado.TipoDoc.IdTipoDoc +
                            " AND  NroDoc=" + oClienteSeleccionado.NroDoc;


            return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        }
    }
}

