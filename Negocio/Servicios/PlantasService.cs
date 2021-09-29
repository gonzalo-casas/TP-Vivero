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
    class PlantasService
    {
        //BDHelper _BD = new BDHelper();
        private IPlanta dao;
        public PlantasService() // cto tab tab genera constructor automaticamente
        {
            dao = new PlantaDao();
        }
        public DataTable Plantas_Activas()
        {
            
            return dao.Plantas_Activas();
        }
        public DataTable Plantas_Inactivas()
        {
            
            return dao.Plantas_Inactivas();
        }
        public DataTable Todas_las_Plantas()
        {
           
            return dao.Todas_las_Plantas();
        }
        public string NuevoId()
        {
          
            return dao.NuevoId();
        }
        public DataTable Recuperar_Planta(string Codigo)
        {

            return dao.Recuperar_Planta(Codigo);
        }
        public DataTable Buscar_Planta(string Codigo, string NombreComun)
        {
            return dao.Buscar_Planta(Codigo,NombreComun);

            //string sql = "SELECT * FROM Plantas WHERE Codigo LIKE '%" + Codigo + "%' AND NombreComun LIKE '%" + NombreComun + "%'";
            //DataTable tabla = new DataTable();
            //return BDHelper.obtenerInstancia().consultar(sql);
        }
        public bool EliminarPlanta(Es_Planta datos)
        {


            return dao.Eliminar(datos);


        }

        public bool Crear(Es_Planta datos)
        {

           
            return dao.Insertar(datos);

           
        }
        public bool Actualizar(Es_Planta datos)
        {


            return dao.Update(datos);


        }
    }
}   
