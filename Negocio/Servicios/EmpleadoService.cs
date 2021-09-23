using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos;
using Vivero.Datos.Daos;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Negocio
{
    class EmpleadoService
    {

        private IEmpleado dao;
        public EmpleadoService() // cto tab tab genera constructor automaticamente
        {
            dao = new EmpleadoDao();
        }

        public string ValidarUsuario(int Id_Usuario, string Contrasena)
        {
            return dao.ValidarUsuario(Id_Usuario, Contrasena);
        }

        internal bool ActualizarEmpleado(Es_Empleado oEmpleadoSeleccionado)
        {
            return dao.Update(oEmpleadoSeleccionado);
        }

        public DataTable BuscarEmpleado(string ID_emp, string nom_emp, string ap_emp, string estado)
        {
            return dao.BuscarEmpleado( ID_emp,  nom_emp,  ap_emp,  estado);
        }


        internal bool CrearEmpleado(Es_Empleado oEmpleado)
        {
            return dao.Create(oEmpleado);
        }

        public DataTable RecuperarPorId(int idEmpleado)
        {
            return dao.RecuperarPorId(idEmpleado);
        }

        public bool ModificarEstadoEmpleado(Es_Empleado oEmpleado)
        {
            return dao.Delete(oEmpleado);
        }

    }
}
