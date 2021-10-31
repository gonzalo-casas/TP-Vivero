﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Negocio.Servicios
{
    class FacturaService
    {
        private IFactura dao;

        public FacturaService() // cto tab tab genera constructor automaticamente
        {
            dao = new FacturaDao();
        }

        public DataTable BuscarDetalle(string tipo_factura, string nro_factura)
        {
            return dao.BuscarDetalle(tipo_factura, nro_factura);
        }


       public DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado)
        {
            return dao.BuscarFactura(nro_factura, nro_doc, id_empleado, fecha, estado);
        }

 
        internal bool ValidarDatos(Es_Factura factura)
        {
            if (factura.FacturaDetalle.Count == 0)
            {
                throw new Exception("Debe ingresar al menos un item de factura.");
            }

            return true;
        }

        internal bool Crear(Es_Factura factura)
        {
            return dao.Create(factura);
        }

        internal bool Anular(Es_Factura facturaSeleccionada)
        {
            return dao.Delete(facturaSeleccionada);
        }

        internal DataTable RecuperarTipoFactura(string tipoFactura)
        {
            return dao.RecuperarTipoFactura(tipoFactura);
        }
    }
   
}
