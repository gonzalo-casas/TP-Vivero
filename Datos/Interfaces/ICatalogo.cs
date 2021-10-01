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
        DataTable Buscar_Planta(string estado);
        DataTable Buscar_PlantaId(string id_Planta);
        DataTable Buscar_Catalogo(string Nombre,string puntos, string estado);
        bool Create(Es_Catalogo oCatalogo);
        bool Update(Es_Catalogo oCatalogoSeleccionado);
        bool Delete(Es_Catalogo oCatalogo);
        DataTable RecuperarPorId(int idCatalogo);
       // DataTable Buscar_Catalogo2(string ID);
        DataTable BuscarUnSoloCatalogo(string nom_cat);
        DataTable Buscar_CatalogoId(string nombre);
    }
}
