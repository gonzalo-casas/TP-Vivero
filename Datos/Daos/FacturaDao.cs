using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vivero.Datos.Interfaces;
using Vivero.Negocio.Entidades;
using Vivero.Negocio.EstructuraNegocio;

namespace Vivero.Datos.Daos
{
    class FacturaDao : IFactura
    {

        public DataTable BuscarDetalle(string tipo_factura, string nro_factura)
        {
            string consulta = "SELECT pl.NombreComun AS Nombre_Planta, p.Nombre AS Nombre_Producto, df.NroItem, df.Cantidad, df.Precio FROM DetalleFactura df JOIN TipoFactura tf ON (tf.ID = df.Tipo_Factura) LEFT JOIN Producto p ON (p.Codigo = df.Id_Producto) LEFT JOIN Planta pl ON (pl.Codigo = df.Id_Planta) WHERE tf.Nombre = '" + tipo_factura + "' AND Nro_Factura = " + nro_factura;
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable BuscarFactura(string nro_factura, string nro_doc, string id_empleado, string fecha, string estado)
        {
            string consulta = "SELECT tf.Nombre, Nro_Factura, f.NroDoc, f.Fecha, (e.Nombre + ' ' + e.Apellido) AS Empleado, Monto, Puntos FROM Factura f JOIN  TipoFactura tf ON (f.Tipo_Factura = tf.ID) " +
                              "JOIN Empleado e ON (e.ID = f.Id_Empleado) WHERE f.Estado in  " + estado ;


            if (!String.IsNullOrEmpty(nro_factura))
            {
                consulta += " AND f.Nro_Factura LIKE '" + nro_factura + "%'";

            }

            if (!String.IsNullOrEmpty(nro_doc))
            {
                consulta += " AND f.NroDoc LIKE '"  + nro_doc + "%'";
            }

            if (!String.IsNullOrEmpty(id_empleado))
            {
                consulta += " AND f.Id_Empleado LIKE '" + id_empleado + "%'";
            }
            if (!String.IsNullOrEmpty(fecha.ToString()))
            {
                consulta += " AND f.Fecha = CONVERT(datetime, " +"'" + fecha.ToString() + "', " + "103)";
            }

            consulta += " ORDER BY Nro_Factura";


            return BDHelper.obtenerInstancia().consultar(consulta);
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
                                                        "           ,@Tipo_Factura           ",
                                                          "           ,@Id_Planta           ",
                                                        "           ,@Id_Producto       ",
                                                        "           ,@Precio              ",
                                                        "          ,@NroItem              ",
                                                        "           ,@Cantidad)           ");

                    

                    var paramDetalle = new Dictionary<string, object>();
                    paramDetalle.Add("Nro_Factura", factura.Numero_Factura);
                    paramDetalle.Add("Tipo_Factura", factura.Tipo_Factura.ID);

                    string SQLStock = "UPDATE ";
                    string CodigoStock = string.Empty;

                    if (itemFactura.TipoItem) // si es planta
                    {
                       
                        paramDetalle.Add("Id_Planta", itemFactura.Planta.Codigo);
                        paramDetalle.Add("Id_Producto", DBNull.Value);
                        SQLStock += "Planta ";
                        CodigoStock = itemFactura.Planta.Codigo;

                    }

                       
                    else  // entonces es producto
                    {
                        paramDetalle.Add("Id_Producto", itemFactura.Producto.Codigo);
                        paramDetalle.Add("Id_Planta", DBNull.Value);
                        SQLStock += "Producto ";
                        CodigoStock = itemFactura.Producto.Codigo.ToString();
                    }
                      

                    paramDetalle.Add("Precio", itemFactura.Precio);
                    paramDetalle.Add("Cantidad", itemFactura.Cantidad);
                    paramDetalle.Add("NroItem", itemFactura.NroItem);
                    SQLStock += "SET Stock = Stock - " + itemFactura.Cantidad.ToString() + " WHERE Codigo = " + CodigoStock;
                    dm.EjecutarSQL(SQLStock);
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

        //public bool Delete(Es_Factura facturaSeleccionada)
        //{


        //    string consulta = "UPDATE Factura " +
        //                    "SET Estado= '0'" +
        //                    " WHERE Tipo_Factura=" + facturaSeleccionada.Tipo_Factura.ID +
        //                    " AND  Nro_Factura=" + facturaSeleccionada.Numero_Factura;


        //    return BDHelper.obtenerInstancia().EjecutarSQL(consulta) == 1;
        //}

        //public List<Es_DetalleFactura> DetallesFactura = new List<Es_DetalleFactura>();
        public bool Delete(Es_Factura facturaSeleccionada)
        {
            DataManager dm = new DataManager();
            try
            {
                dm.Open();

                string recuperarDetalle = @"SELECT df.Id_Planta, df.Id_Producto, df.Cantidad
                                            FROM DetalleFactura df 
                                            where df.Tipo_Factura = " + facturaSeleccionada.Tipo_Factura.ID + " AND df.Nro_Factura = " + facturaSeleccionada.Numero_Factura;
                DataTable tablaDetalle = dm.ConsultaSQL(recuperarDetalle); 
                
                dm.BeginTransaction();

                string consulta = "UPDATE Factura " +
                                   "SET Estado= '0'" +
                                   " WHERE Tipo_Factura=" + facturaSeleccionada.Tipo_Factura.ID +
                                   " AND  Nro_Factura=" + facturaSeleccionada.Numero_Factura;


                dm.EjecutarSQL(consulta);

                for (int i = 0; i < tablaDetalle.Rows.Count; i++)
                {

                    string restablecerStock;
                    string idStock;

                    if (tablaDetalle.Rows[i]["Id_Producto"] == DBNull.Value)
                    {
                        restablecerStock = "UPDATE Planta ";
                        idStock = "WHERE Codigo = " + tablaDetalle.Rows[i]["Id_Planta"].ToString();
                    }
                    else
                    {
                        restablecerStock = "UPDATE Producto ";
                        idStock = "WHERE Codigo = " + tablaDetalle.Rows[i]["Id_Producto"].ToString();
                    }
                    restablecerStock += "SET Stock = Stock + " + tablaDetalle.Rows[i]["Cantidad"].ToString() + idStock;
                    dm.EjecutarSQL(restablecerStock);
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

        public DataTable RecuperarTipoFactura (string tipoFactura)
        {
            string sql = "SELECT * FROM Factura f JOIN TipoFactura tp ON (f.Tipo_Factura = tp.ID) WHERE tp.nombre LIKE " + "'" + tipoFactura + "'";
            return BDHelper.obtenerInstancia().consultar(sql);
            //ojo capaz aca a la izquierda del ID le falte + "'"
        }


    }




}

