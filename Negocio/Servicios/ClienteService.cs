﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio
{
    class ClienteService
    {
        private ICliente dao;
        public ClienteService() // cto tab tab genera constructor automaticamente
        {
            dao = new ClienteDao();
        }

        public DataTable traerTodo()
        {
            return dao.traerTodo();
        }

        internal bool ActualizarCliente(Es_Cliente oClienteSeleccionado)
        {
            return dao.Update(oClienteSeleccionado);
        }

        public DataTable BuscarCliente(string TipoDoc, string NroDoc, string Nombre, string Apellido, string estado)
        {
            return dao.BuscarCliente( TipoDoc,  NroDoc,  Nombre,  Apellido,  estado);
        }


        internal bool CrearCliente(Es_Cliente oCliente)
        {
            return dao.Create(oCliente);
        }

        public DataTable RecuperarPorTipoDoc_NroDoc(int tipoDoc, string NroDoc)
        {
            return dao.RecuperarPorTipoDoc_NroDoc(tipoDoc, NroDoc);
        }

        public bool ModificarEstadoCliente(Es_Cliente oCliente)
        {
            return dao.Delete(oCliente);
        }
    }
}
