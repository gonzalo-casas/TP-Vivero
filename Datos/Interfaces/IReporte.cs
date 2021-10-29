using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivero.Datos.Interfaces
{
    interface IReporte
    {
        DataTable GenerarReporteProductosVendidos(string Desde, string Hasta);
    }
}
