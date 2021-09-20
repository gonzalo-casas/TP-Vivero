using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos;

namespace Vivero.Negocio
{
    class UsuarioService
    {
       

        public bool ValidarUsuario(int Id_Usuario, string Contrasena)
        {
            string consulta = "SELECT * FROM Empleado WHERE ID=" + Id_Usuario + " AND contraseña='" + Contrasena + "'";

   
          
            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
