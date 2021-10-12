using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Presentacion.Ventas;

namespace Vivero.Negocio.Entidades
{
   public class Es_DetalleFactura
    {
        bool EsPlanta;

        public Es_DetalleFactura(bool flag)
        {
            EsPlanta = flag;

        }

        public int Tipo_Factura { get; set; }
        public int Nro_Factura { get; set; }
        public Es_Planta Planta { get; set; }
        public Es_Producto Producto { get; set; }
        public int NroItem { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        

        //public int IdProducto
        //{
        //    get
        //    {
        //        return Producto.IdProducto;
        //    }
        //}
        //public string ProductoDescripcion
        //{
        //    get
        //    {
        //        return Producto.Nombre;
        //    }
        //}

        public Double Importe
        {
            get
            {
                return Cantidad * Precio;
            }
        }

        public string Nombre
        {
            get
            {  
                if(EsPlanta)
                {
                    return Planta.NombreComun;
                }
                else
                {
                    return Producto.Nombre;
                }

                
            }
        }

        public string Codigo
        {
            get
            { 
                if (EsPlanta)
                {
                    return Planta.Codigo;
                }
                else
                {
                    return Producto.Codigo.ToString();

                }
            }
        }

        public string Tipo
        {
            get
            {
                if (EsPlanta)
                {
                    return "Planta";
                }
                else
                {
                    return "Producto";

                }
            }
        }

        public bool TipoItem
        {
            get
            {
                if (EsPlanta)
                {
                    return true;
                }
                 else
                {
                   return  false;
                }
            }
        }

    }
}
