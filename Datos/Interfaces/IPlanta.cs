using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IPlanta
    {

        DataTable Buscar_Planta(string Codigo, string NombreComun);
        DataTable Recuperar_Planta(string Codigo);

        DataTable Todas_las_Plantas();

        DataTable Plantas_Inactivas();

        DataTable Plantas_Activas();
        string NuevoId();

        DataTable Eliminar(string Codigo);

        bool Insertar(Es_Planta datos);
        bool Update(Es_Planta datos);
        bool Eliminar(Es_Planta datos);




        //bool Create(Es_Planta oPlanta);
        //bool Update(Es_Planta oPlantaSeleccionado);
        //bool Delete(Es_Planta oPlanta);





    }
}
