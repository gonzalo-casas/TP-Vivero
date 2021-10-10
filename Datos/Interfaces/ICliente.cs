using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface ICliente
    {
        bool Create(Es_Cliente oCliente);
        bool Update(Es_Cliente oClienteSeleccionado);
        bool Delete(Es_Cliente oClienteSeleccionado);
        DataTable RecuperarPorTipoDoc_NroDoc(int TipoDoc, string NroDoc);
        DataTable BuscarCliente(string TipoDoc, string NroDoc, string Nombre, string Apellido, string estado);
        DataTable traerTodo();
    }
}

