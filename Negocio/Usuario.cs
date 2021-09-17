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

        public int validarUsuario(string Id_Usuario, string Contrasena)
        {
            string consulta = "SELECT * FROM Empleado WHERE ID='" + Id_Usuario + "' AND contraseña='" + Contrasena + "'";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
    }
}
