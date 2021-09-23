using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.EstructuraNegocio
{
    class Es_Proveedor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string Nro_Calle { get; set; }
        public Es_Barrio Barrio { get; set; }
        public Es_Localidad Localidad { get; set; }
        public string Telefono { get; set; }
        public string Razon_Social { get; set; }
        public int Estado { get; set; }
    }
}
