using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Negocio.EstructuraNegocio
{
   public  class Es_Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Es_TipoProducto Tipo { get; set; }
        public string Stock { get; set; }
        public string Costo { get; set; }
        public string Precio { get; set; }
        public string Composicion { get; set; }
        public int Estado { get; set; }
        

    }
}
