using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface ICatalogo
    {
        DataTable Buscar_Planta();
        DataTable Buscar_Catalogo(string ID, string Puntos_Necesarios, string estado);
        bool Create(Es_Catalogo oCatalogo);
        bool Update(Es_Catalogo oCatalogoSeleccionado);
        bool Delete(Es_Catalogo oCatalogo);
        DataTable RecuperarPorId(int idCatalogo, int id_Planta);
    }
}
