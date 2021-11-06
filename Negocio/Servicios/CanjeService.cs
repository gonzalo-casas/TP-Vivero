using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.Servicios
{
    class CanjeService
    {
        private ICanje dao;

        public CanjeService()
        {
            dao = new CanjeDao();
        }

        public DataTable BuscarCanje(string nombre, string nro_doc, string nombreComun, string fecha, string estado)
        {
            return dao.BuscarCanje(nombre,  nro_doc, nombreComun, fecha, estado);
        }

        public bool Create(Es_Canje canje)
        {
            return dao.Create(canje);
        }

        public bool Anular( string idCanje)
        {
            return dao.Delete(idCanje);
        }
    }
}
