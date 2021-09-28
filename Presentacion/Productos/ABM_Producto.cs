using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Negocio;
using Vivero.Negocio.Entidades;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Producto
{
    public partial class ABM_Producto : Form
    {

        public ABM_Producto(int CodProducto)
        {
            InitializeComponent();
            this.CodProducto = CodProducto;
            oProductoService = new ProductoService();
            oTipoProductoService = new TipoProductoService();
            oComposicionService = new ComposicionService();
        }

        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly ProductoService oProductoService;
        private readonly TipoProductoService oTipoProductoService;
        private readonly ComposicionService oComposicionService;
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
        private int CodProducto;
        private int EstadoActual;

        public ABM_Producto()
        {
            InitializeComponent();
            oProductoService = new ProductoService();
            oTipoProductoService = new TipoProductoService();
            oComposicionService = new ComposicionService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }



        private void ALTA_Producto_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipo, oTipoProductoService.TraerTodo(), "Nombre", "ID");
            this.gbComposicion.Visible = false;

            //switch para actualizar titulo y habilitar  txt y cbo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Producto";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Producto";
                        // Recuperar usuario seleccionado en la grilla 

                        actualizarCampos();
                        txtNombreProducto.Enabled = true;
                        txtStockProducto.Enabled = true;
                        numericUpDownCosto.Enabled = true;
                        numericUpDownPrecio.Enabled = true;
                        cboTipo.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Deshabilitar Producto";
                        actualizarCampos();
                        txtNombreProducto.Enabled = false;
                        txtStockProducto.Enabled = false;
                        numericUpDownCosto.Enabled = false;
                        numericUpDownPrecio.Enabled = false;
                        cboTipo.Enabled = false;
                        gbComposicion.Enabled = false;
                        break;
                    }
            }


        }


        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            ProductoService oProductoSeleccionado = new ProductoService();
            tabla = oProductoSeleccionado.RecuperarPorCod(CodProducto);

            txtNombreProducto.Text = tabla.Rows[0]["Nombre"].ToString();
            txtStockProducto.Text = tabla.Rows[0]["Stock"].ToString();
            cboTipo.Text = tabla.Rows[0]["Tipo"].ToString();
            numericUpDownCosto.Value = Convert.ToInt32(tabla.Rows[0]["Costo"]);
            numericUpDownPrecio.Value = Convert.ToInt32(tabla.Rows[0]["Precio"]);
            EstadoActual = Convert.ToInt32(tabla.Rows[0]["Estado"]);

            DataTable tablaComposicion = new DataTable();
            ComposicionService oComposicion = new ComposicionService();
            tablaComposicion = oComposicion.RecuperarPorCod(CodProducto);
            if (tablaComposicion.Rows.Count !=0)
            {
                cboTipo.SelectedIndex = 3;
                for (int i = 0; i < tablaComposicion.Rows.Count; i++)
                {
                    dgv_Componentes.Rows.Add();
                    dgv_Componentes.Rows[i].Cells[0].Value = tablaComposicion.Rows[i]["Componente"].ToString();
                    //cmb.ValueMember = tablaComposicion.Rows[i]["Componente"].ToString();
                    //cmb.DefaultCellStyle.NullValue = tablaComposicion.Rows[i]["Componente"].ToString();
                    dgv_Componentes.Rows[i].Cells[1].Value = tablaComposicion.Rows[i]["Cant_Componente"].ToString();



                }
            }


            tabla.Clear();


        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }


        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese nombre del Producto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreProducto.BackColor = Color.Red;
                txtNombreProducto.Focus();
                return false;
            }
            else
                txtNombreProducto.BackColor = Color.White;

            if (txtStockProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Stock por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockProducto.BackColor = Color.Red;
                txtStockProducto.Focus();
                return false;
            }
            else
                txtStockProducto.BackColor = Color.White;

            if (numericUpDownCosto.Value == 0)
            {
                MessageBox.Show("Ingrese el costo del producto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownCosto.BackColor = Color.Red;
                numericUpDownCosto.Focus();
                return false;
            }
            else
                txtStockProducto.BackColor = Color.White;

            if (numericUpDownPrecio.Value == 0)
            {
                MessageBox.Show("Ingrese el precio del producto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownPrecio.BackColor = Color.Red;
                numericUpDownPrecio.Focus();
                return false;
            }
            else
                txtStockProducto.BackColor = Color.White;

            if (cboTipo.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Seleccione un tipo de producto por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cboTipo.SelectedIndex == 3)
            {
                if (!ValidarCamposCompuesto())
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidarCamposCompuesto()
        {
            int sumaComponentes = 0;
            var filas = dgv_Componentes.Rows.Count;
            if (filas == 0)
            {
                MessageBox.Show("Agregue componentes al producto compuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            List<string> componentes = new List<string> { };
            for (int i = 0; i < filas; i++)
            {
                componentes.Add(dgv_Componentes[0, i].Value.ToString());
                sumaComponentes += Convert.ToInt32(dgv_Componentes[1, i].Value);
                if (dgv_Componentes[0, i].Value == null)
                {
                    MessageBox.Show("Seleccione el producto componente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (dgv_Componentes[1, i].Value == null)
                {
                    MessageBox.Show("Escriba la cantidad de componentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv_Componentes[1, i].Style.BackColor = Color.Red;
                    return false;
                }
                else
                {
                    dgv_Componentes[1, i].Style.BackColor = Color.White;

                }

            }

            if (componentes.Distinct().Count() != componentes.Count())
            {
                MessageBox.Show("No puedes ingresar varias veces el mismo componente, intenta escribirlo en una sola fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (sumaComponentes != 100)
            {
                MessageBox.Show("La suma de las cantidades de cada componente no es igual al 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv_Componentes.Columns[1].DefaultCellStyle.BackColor = Color.Red;
                return false;
            }
            else
            {
                dgv_Componentes.Columns[1].DefaultCellStyle.BackColor = Color.White;
            }
            return true;
        }

        public void SeleccionarOpcion(FormMode op)
        {
            formMode = op;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:

                    if (ValidarCampos())
                    {

                        var oProducto = new Es_Producto();
                        oProducto.Nombre = txtNombreProducto.Text;
                        oProducto.Stock = txtStockProducto.Text;
                        oProducto.Costo = numericUpDownCosto.Value.ToString();
                        oProducto.Precio = numericUpDownPrecio.Value.ToString();
                        oProducto.Tipo = new Es_TipoProducto();
                        oProducto.Tipo.ID = (int)cboTipo.SelectedValue;
                        oProducto.Estado = 1;

                        if (oProductoService.CrearProducto(oProducto))
                        {
                            bool composicion = true;
                            if (cboTipo.SelectedIndex == 3)
                            {
                                for (int i = 0; i < dgv_Componentes.Rows.Count; i++)
                                {
                                    var oComposicion = new Es_Composicion();
                                    oComposicion.Cod_Prod_Compuesto = oProductoService.BuscarUnSoloProducto(oProducto.Nombre,oProducto.Tipo.ID, oProducto.Stock, oProducto.Costo, oProducto.Precio).Rows[0][0].ToString();
                                    oComposicion.Cod_Prod_Componente = dgv_Componentes[0, i].Value.ToString();
                                    oComposicion.Cant_Componente = dgv_Componentes[1, i].Value.ToString();

                                    if (!oComposicionService.CrearComposicion(oComposicion))
                                    {
                                        MessageBox.Show("Error al crear la composicion del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        composicion = false;
                                        break;
                                    }
                                }
                            }
                            if (composicion)
                            {
                                MessageBox.Show("Producto creado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                           
                        }
                        else 
                        { 
                            MessageBox.Show("Error al crear el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        }
                    }


                    break;

                case FormMode.update:

                    if (ValidarCampos())
                    {
                        //actualizo los datos del producto seleccionado

                        Es_Producto oProductoSeleccionado = new Es_Producto();
                        oProductoSeleccionado.Codigo = CodProducto;
                        oProductoSeleccionado.Nombre = txtNombreProducto.Text;
                        oProductoSeleccionado.Stock = txtStockProducto.Text;
                        oProductoSeleccionado.Costo = numericUpDownCosto.Value.ToString();
                        oProductoSeleccionado.Precio = numericUpDownPrecio.Value.ToString();
                        oProductoSeleccionado.Tipo = new Es_TipoProducto();
                        oProductoSeleccionado.Tipo.ID = (int)cboTipo.SelectedValue;
                        oProductoSeleccionado.Estado = 1;

                        if (oProductoService.ActualizarProducto(oProductoSeleccionado))
                        {
                            bool composicion = true;
                            if (cboTipo.SelectedIndex == 3)
                            {
                                var oComposicion = new Es_Composicion();
                                oComposicion.Cod_Prod_Compuesto = CodProducto.ToString();
                                oComposicionService.Delete(oComposicion);
                                for (int i = 0; i < dgv_Componentes.Rows.Count; i++)
                                {
                                    
                                    //oComposicion.Cod_Prod_Compuesto = oProductoService.BuscarUnSoloProducto(oProductoSeleccionado.Nombre, oProductoSeleccionado.Tipo.ID, oProductoSeleccionado.Stock, oProductoSeleccionado.Costo, oProductoSeleccionado.Precio).Rows[0][0].ToString();
                                    oComposicion.Cod_Prod_Componente = dgv_Componentes[0, i].Value.ToString();
                                    //oComposicion.Cod_Prod_Componente = cmb.
                                    oComposicion.Cant_Componente = dgv_Componentes[1, i].Value.ToString();

                                    if (!oComposicionService.CrearComposicion(oComposicion))
                                    {
                                        MessageBox.Show("Error al actualizar la composicion del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        composicion = false;
                                        break;
                                    }
                                }
                            }
                            if (composicion)
                            {
                                MessageBox.Show("Producto actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    break;


                case FormMode.delete:
                    if (MessageBox.Show("Seguro que desea deshabilitar el producto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {


                        Es_Producto oProductoSeleccionado = new Es_Producto();

                        oProductoSeleccionado.Codigo = CodProducto;

                        if (oProductoService.ModificarEstadoProducto(oProductoSeleccionado))
                        {
                            MessageBox.Show("Producto Deshabilitado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Error al actualizar el producto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgv_Componentes.Rows.Add();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_Componentes.SelectedRows)
            {
                dgv_Componentes.Rows.RemoveAt(fila.Index);
            }
        }

        private void dgv_Componentes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_Componentes.CurrentCell.ColumnIndex == 1)
            {
                DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
                tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
                e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
            }
            
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //when i press enter,bellow code never run?
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }

        private void dgv_Componentes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //no hacer nada
        }

        private void cboTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 3)
            {
                this.Size = new Size(600, 750);
                this.gbComposicion.Location = new Point(12, 286);
                this.gbComposicion.Visible = true;
                this.dgv_Componentes.RowTemplate.Height = 29;

                cmb.HeaderText = "Componente";
                cmb.Name = "cmb";
                cmb.MaxDropDownItems = 4;
                DataTable tablaProductos = oProductoService.Buscar_producto(null, null, 0, 0, "(1)");
                DataRow filaDefault = tablaProductos.NewRow();
                filaDefault[1] = "Seleccionar";
                filaDefault[4] = 0;
                filaDefault[5] = 0;
                filaDefault[6] = 0;
                tablaProductos.Rows.Add(filaDefault);
                cmb.DataSource = tablaProductos;
                cmb.DisplayMember = "Nombre";
                cmb.DisplayIndex = 0;
                cmb.ValueMember = "Nombre";
                for (int i = 0; i < tablaProductos.Rows.Count; i++)
                {
                    if (tablaProductos.Rows[i]["Nombre"].ToString() == "Seleccionar")
                    {
                        cmb.DefaultCellStyle.NullValue = tablaProductos.Rows[i]["Nombre"];
                    }
                }
                if (dgv_Componentes.ColumnCount != 2)
                {
                    dgv_Componentes.Columns.Insert(0, cmb);
                }
            }
            else
            {
                this.Size = new Size(500, 510);
                this.gbComposicion.Visible = false;
            }
        }
    }
}
