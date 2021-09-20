using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.EstructuraNegocio
{
    class Es_Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Es_TipoDoc TipoDoc { get; set; }
        public string Nro_Doc { get; set; }
        public string Telefono  { get; set; }
        public string Calle { get; set; }
        public int Nro_Calle { get; set; }
        public int Barrio { get; set; }
        public int Localidad { get; set; }
        public string Contraseña { get; set; }
        public int Estado { get; set; }
    }
}
