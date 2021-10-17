using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Negocio.EstructuraNegocio
{
    public class Es_Planta
    {
        //internal Es_TipoPlanta Descripcion;

        public string Codigo { get; set; }
        public string NombreCientifico { get; set; }
        public string NombreComun { get; set; }
        public Es_TipoPlanta Tipo { get; set; }
        //public string Tipo { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }
        public int Estado { get; set; }
    }
}
