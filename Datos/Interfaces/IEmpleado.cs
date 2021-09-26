using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Interfaces
{
    interface IEmpleado
    {
        Array ValidarUsuario(int Id_Usuario, string Contrasena);
        bool Create(Es_Empleado oEmpleado);
        bool Update(Es_Empleado oEmpleadoSeleccionado);
        bool Delete(Es_Empleado oEmpleado);
        DataTable RecuperarPorId(int idEmpleado);
        DataTable BuscarEmpleado(string ID_emp, string nom_emp, string ap_emp, string estado, string Perfil);

    }
}
