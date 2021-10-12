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
        public Es_TipoFactura Tipo_Factura { get; set; }
        public int Numero_Factura { get; set; }
        public Es_Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public Es_Empleado Id_Empleado { get; set; }
        public IList<Es_DetalleFactura> FacturaDetalle { get; set; }
        public double Monto { get; set; }
        public int Puntos { get; set; }
    }
}
