﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Interfaces
{
    interface IFactura
    {
        DataTable BuscarDetalle(string tipo_factura, string nro_factura);
        DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado);
        bool Create(Es_Factura factura);
        bool Delete(Es_Factura facturaSeleccionada);
        DataTable RecuperarTipoFactura(string tipoFactura);
    }
}
