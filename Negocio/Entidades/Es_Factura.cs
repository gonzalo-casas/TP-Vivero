using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio.Entidades
{
    class Es_Factura
    {
        public int Tipo_Factura { get; set; }
        public int Numero_Factura { get; set; }
        public Es_TipoDoc  Tipo_Doc { get; set; }
        public string Numero_Doc { get; set; }
        public DateTime Fecha { get; set; }
        public Es_Empleado ID { get; set; }
        public decimal Monto { get; set; }
        public int Puntos { get; set; }
    }
}
