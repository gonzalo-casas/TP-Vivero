using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Interfaces
{
    interface ICanje
    {

        DataTable BuscarCanje(string nombre, string nro_doc, string nombreComun, string fecha, string estado);
        bool Create(Es_Canje canje);
        bool Delete(string idCanje);
        //bool Delete(Es_Canje canjeSeleccionada);


        string ObtenerPuntosCliente(int idTipoDoc, string nroDoc);

        //DataTable RecuperarTipoFactura(string tipoFactura);
    }
}
