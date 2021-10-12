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
            string consulta = "SELECT tf.Nombre, Nro_Factura, f.NroDoc, f.Fecha, (e.Nombre + ' ' + e.Apellido) AS Empleado, Monto, Puntos FROM Factura f JOIN  TipoFactura tf ON (f.Tipo_Factura = tf.ID) " +
                              "JOIN Empleado e ON (e.ID = f.Id_Empleado) WHERE f.Estado in  " + estado;


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
                consulta += " AND f.Fecha = CONVERT(datetime, " +"'" + fecha.ToString() + "', " + "103)";
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
                                            "           ([fecha]         ",
                                            "           ,[NroDoc]       ",
                                            "           ,[TipoDoc]    ",
                                            "           ,[Tipo_Factura]   ",
                                            "           ,[Monto]    ",
                                            "           ,[Id_Empleado]    ",
                                            //"           ,[descuento]    ",
                                            "           ,[Estado])      ",
                                            "     VALUES                 ",
                                            "           (@fecha          ",
                                            "           ,@NroDoc        ",
                                            "           ,@TipoDoc",
                                            "           ,@Tipo_Factura    ",
                                            "           ,@Monto     ",
                                              "           ,@Id_Empleado     ",
                                            //"           ,@descuento     ",
                                            "           ,@Estado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("fecha", factura.Fecha);
                parametros.Add("NroDoc", factura.Cliente.NroDoc);
                parametros.Add("TipoDoc", factura.Cliente.TipoDoc.IdTipoDoc);
                parametros.Add("Tipo_Factura", factura.Tipo_Factura.ID);
                parametros.Add("Monto", factura.Monto);
                parametros.Add("Id_Empleado", factura.Id_Empleado.ID);
                //parametros.Add("descuento", factura.Descuento);
                parametros.Add("Estado", 1); // ni idea pq pone false
                dm.EjecutarSQLCONPARAMETROS(sql, parametros);

                var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY");
                factura.Numero_Factura = Convert.ToInt32(newId);


                foreach (var itemFactura in factura.FacturaDetalle)
                {
                    string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DetalleFactura] ",
                                                        "           ([Nro_Factura]           ",
                                                       "           ,[Tipo_Factura]          ",
                                                        "           ,[Id_Planta]          ",
                                                        "           ,[Id_Producto]      ",
                                                        "           ,[Precio]             ",
                                                          "          ,[NroItem]             ",
                                                        "           ,[Cantidad])             ",
                                                        "     VALUES                        ",
                                                        "           (@Nro_Factura            ",
                                                        "           ,@Id_Planta           ",
                                                          "           ,@Tipo_Factura           ",
                                                        "           ,@Id_Producto       ",
                                                        "           ,@Precio              ",
                                                        "          ,@NroItem              ",
                                                        "           ,@Cantidad)           ");

                    

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("Nro_Factura", factura.Numero_Factura);
                    paramDetalle.Add("Tipo_Factura", factura.Tipo_Factura.ID);

                    if (itemFactura.TipoItem) // si es planta
                    {
                       
                        paramDetalle.Add("Id_Planta", itemFactura.Planta.Codigo);
                        paramDetalle.Add("Id_Producto", DBNull.Value);
                    }

                       
                    else  // entonces es producto
                    {
                        paramDetalle.Add("Id_Producto", itemFactura.Producto.Codigo);
                        paramDetalle.Add("Id_Planta", DBNull.Value);
                    }
                      

                    paramDetalle.Add("Precio", itemFactura.Precio);
                    paramDetalle.Add("Cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("NroItem", itemFactura.NroItem);

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

