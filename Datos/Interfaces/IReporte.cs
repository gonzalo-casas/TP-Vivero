﻿using System;
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

        DataTable GenerarReporteVentaEmpleados(string Desde, string Hasta);

        DataTable GenerarReporteComprasClientes(string Desde, string Hasta, string valueCbo);
    }
}
