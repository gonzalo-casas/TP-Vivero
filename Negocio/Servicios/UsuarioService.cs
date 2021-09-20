using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos;

namespace Vivero.Negocio
{
    class Usuario
    {
        public int Id_usuario { get; set; }
        public int Tipo_doc { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Nro_calle { get; set; }
        public string Barrio { get; set; }
        public int Localidad { get; set; }
        public string Contrasena { get; set; }
        public bool Estado { get; set; }

        public string ValidarUsuario(int Id_Usuario, string Contrasena)
        {
            string consulta = "SELECT * FROM Empleado WHERE ID=" + Id_Usuario + " AND contraseña='" + Contrasena + "'";



            DataTable tabla = BDHelper.obtenerInstancia().consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (string)tabla.Rows[0][3];
            else
                return string.Empty;
        }
    }
}
