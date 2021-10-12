using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;

namespace Vivero.Datos.Daos
{
    class FacturaDao : IFactura
    {


        public DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado)
        {
            string consulta = "SELECT * FROM Factura f JOIN  TipoFactura tf ON (f.Tipo_Factura = tf.ID) WHERE f.Estado in  " + estado;


            if (!String.IsNullOrEmpty(nro_factura))
            {
                consulta += " AND f.Nro_Factura LIKE " + nro_factura;

            }

            if (!String.IsNullOrEmpty(nro_doc))
            {
                consulta += " AND f.NroDoc LIKE "  + nro_doc ;
            }

            if (!String.IsNullOrEmpty(id_empleado))
            {
                consulta += " AND f.Id_Empleado LIKE " + id_empleado;
            }
            if (!String.IsNullOrEmpty(fecha.ToString()))
            {
                consulta += " AND f.Fecha = CONVERT(datetime, " +"'" + fecha.ToString() + "', " + "101)";
            }

          
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable Buscar_Todas_Facturas()
        {
            string sql = "SELECT * FROM Factura WHERE Tipo_Factura > 0";
            DataTable tabla = new DataTable();
            return BDHelper.obtenerInstancia().consultar(sql);
        }



        public DataTable RecuperarCliente(string dni)
        {
            string sql = "SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'";
            return BDHelper.obtenerInstancia().consultar(sql);


        }
        public DataTable RecuperarTipoDoc(string dni)
        {

            string sql = "SELECT * FROM Cliente WHERE NroDoc = '" + dni + "'";
            return BDHelper.obtenerInstancia().consultar(sql);

        }

        public DataTable RecuperarEmp(string ID)
        {

            string sql = ("SELECT * FROM Empleado WHERE ID = " + ID);
            return BDHelper.obtenerInstancia().consultar(sql);
            //ojo capaz aca a la izquierda del ID le falte + "'"

        }
        public string NuevoId()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM Factura";
            tabla = BDHelper.obtenerInstancia().consultar(sql);
            int id = tabla.Rows.Count;
            int NuevaId = id;
            return NuevaId.ToString();
        }

        public  bool Create(Es_Factura factura)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[Factura] ",
                                            "           ([Nro_factura]   ",
                                            "           ,[fecha]         ",
                                            "           ,[NroDoc]       ",
                                            "           ,[Tipo_Factura]   ",
                                            "           ,[Monto]    ",
                                            //"           ,[descuento]    ",
                                            "           ,[Estado])      ",
                                            "     VALUES                 ",
                                            "           (@nro_factura   ",
                                            "           ,@fecha          ",
                                            "           ,@cliente        ",
                                            "           ,@tipoFactura    ",
                                            "           ,@subtotal     ",
                                            "           ,@descuento     ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("Nro_factura", factura.Numero_Factura);
                parametros.Add("fecha", factura.Fecha);
                parametros.Add("NroDoc", factura.Cliente.NroDoc);
                parametros.Add("Tipo_Factura", factura.Tipo_Factura.ID);
                parametros.Add("Monto", factura.Monto);
                //parametros.Add("descuento", factura.Descuento);
                parametros.Add("Estado", 1); // ni idea pq pone false
                dm.EjecutarSQLCONPARAMETROS(sql, parametros);

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.Numero_Factura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.FacturaDetalle)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[FacturasDetalle] ",
                                                        "           ([id_factura]           ",
                                                        "           ,[id_producto]          ",
                                                        "           ,[precio_unitario]      ",
                                                        "           ,[cantidad]             ",
                                                        "           ,[borrado])             ",
                                                        "     VALUES                        ",
                                                        "           (@id_factura            ",
                                                        "           ,@id_producto           ",
                                                        "           ,@precio_unitario       ",
                                                        "           ,@cantidad              ",
                                                        "           ,@borrado)               ");

                    

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("id_factura", factura.Numero_Factura);

                    if (itemFactura.TipoItem) // si es planta
                    {
                       
                        paramDetalle.Add("id_producto", itemFactura.Planta.Codigo);
                        paramDetalle.Add("id_producto", null);
                    }

                       
                    else  // entonces es producto
                    {
                        paramDetalle.Add("id_producto", itemFactura.Producto.Codigo);
                        paramDetalle.Add("id_producto", null);
                    }
                      

                    paramDetalle.Add("precio", itemFactura.Precio);
                    paramDetalle.Add("cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("borrado", false);

                    dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);
                }



                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
            return true;
        }

        
    }




}

