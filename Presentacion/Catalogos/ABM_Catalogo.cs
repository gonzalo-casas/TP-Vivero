using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Negocio.Entidades;
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Catalogos
{
    public partial class ABM_Catalogo : Form
    {
        public ABM_Catalogo(int idCatalogo)
        {
            InitializeComponent();
            this.idCatalogo = idCatalogo;
            //this.id_Planta = id_Planta;
            oCatalogoService = new CatalogoService();
            oDetalleCatalogoService = new DetalleCatalogoService();
        }
        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly CatalogoService oCatalogoService;
        private readonly DetalleCatalogoService oDetalleCatalogoService;
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
        private int idCatalogo;
       // private int id_Planta;
        private int EstadoActual;
        public ABM_Catalogo()
        {
            InitializeComponent();
            oCatalogoService = new CatalogoService();
            oDetalleCatalogoService = new DetalleCatalogoService();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }


        private void ALTA_Catalogo_Load(object sender, EventArgs e)
        {
          this.dgv_Planta.RowTemplate.Height = 29;

            cmb.HeaderText = "Planta";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            DataTable tablaCatalogo = oCatalogoService.Buscar_Planta("1");
            DataRow filaDefault = tablaCatalogo.NewRow();
            filaDefault[0] = "Seleccionar";
            //filaDefault[4] = 0;
            //filaDefault[5] = 0;
            // filaDefault[6] = 0;
            tablaCatalogo.Rows.Add(filaDefault);
            cmb.DataSource = tablaCatalogo;
            cmb.DisplayMember = "Planta";
            cmb.DisplayIndex = 0;
            cmb.ValueMember = "Planta";
            for (int i = 0; i < tablaCatalogo.Rows.Count; i++)
            {
                if (tablaCatalogo.Rows[i]["Planta"].ToString() == "Seleccionar")
                {
                    cmb.DefaultCellStyle.NullValue = tablaCatalogo.Rows[i]["Planta"];
                }
            }
            if (dgv_Planta.ColumnCount != 2)
            {
                dgv_Planta.Columns.Insert(0, cmb);
            }

            //this.gbPlantas.Visible = false;

            //switch para actualizar titulo y habilitar  txt y cbo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Catalogo";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Catalogo";
                        // Recuperar usuario seleccionado en la grilla 

                        actualizarCampos();
                        txtNombreCatalogo.Enabled = true;
                        //txtNombreComun.Enabled = true;
                        //txtPuntos.Enabled = true;
                        

                        break;
                    }

                case FormMode.delete:
                    {
                        actualizarCampos();
                        this.Text = "Deshabilitar Catalogo";
                        txtNombreCatalogo.Enabled = false;
                        //txtNombreComun.Enabled = false;
                        //txtPuntos.Enabled = false;
                        gbPlantas.Enabled = false;

                        break;
                    }
            }


        }
        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            CatalogoService oCatalogoSeleccionado = new CatalogoService();
            tabla = oCatalogoSeleccionado.RecuperarPorId(idCatalogo);

            txtNombreCatalogo.Text = tabla.Rows[0]["Nombre"].ToString();
            //txtNombreComun.Text = tabla.Rows[0]["Razon_Social"].ToString();
            //txtPuntos.Text = tabla.Rows[0]["Telefono"].ToString();
            EstadoActual = Convert.ToInt32(tabla.Rows[0]["Estado"]);
            DataTable tablaDetalleCatalogo = new DataTable();
            DetalleCatalogoService oDetalleCatalogo = new DetalleCatalogoService();
            tablaDetalleCatalogo = oDetalleCatalogo.RecuperarPorId(idCatalogo);
            if (tablaDetalleCatalogo.Rows.Count != 0)
            {
              //  List<string> lista = new List<string>();
                for (int i = 0; i < tablaDetalleCatalogo.Rows.Count; i++)
                {
                    dgv_Planta.Rows.Add();
                   // lista.Add(tablaDetalleCatalogo.Rows[i]["Codigo"].ToString());
                    dgv_Planta.Rows[i].Cells[0].Value = tablaDetalleCatalogo.Rows[i]["Planta"].ToString();
                    //cmb.ValueMember = tablaComposicion.Rows[i]["Componente"].ToString();
                    //cmb.DefaultCellStyle.NullValue = tablaComposicion.Rows[i]["Componente"].ToString();
                    dgv_Planta.Rows[i].Cells[1].Value = tablaDetalleCatalogo.Rows[i]["Puntos"].ToString();



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
     

        private void txt_Puntos_Click(object sender, EventArgs e)
        {

        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombreCatalogo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese nombre del Catalogo por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCatalogo.BackColor = Color.Red;
                txtNombreCatalogo.Focus();
                return false;
            }
            else
                txtNombreCatalogo.BackColor = Color.White;

           /* if (txtPuntos.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Puntos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPuntos.BackColor = Color.Red;
                txtPuntos.Focus();
                return false;
            }
            else
                txtPuntos.BackColor = Color.White;
           */

            return true;
        }

        private bool ValidarCamposCompuesto()
        {
            int sumaComponentes = 0;
            var filas = dgv_Planta.Rows.Count;
            if (filas == 0)
            {
                MessageBox.Show("Agregue Planta al Catalogo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            List<string> planta = new List<string> { };
            for (int i = 0; i < filas; i++)
            {
                planta.Add(dgv_Planta[0, i].Value.ToString());
                sumaComponentes += Convert.ToInt32(dgv_Planta[1, i].Value);
                if (dgv_Planta[0, i].Value == null)
                {
                    MessageBox.Show("Seleccione la planta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (dgv_Planta[1, i].Value == null)
                {
                    MessageBox.Show("Escriba los puntos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgv_Planta[1, i].Style.BackColor = Color.Red;
                    return false;
                }
                else
                {
                    dgv_Planta[1, i].Style.BackColor = Color.White;

                }

            }

            if (planta.Distinct().Count() != planta.Count())
            {
                MessageBox.Show("No puedes ingresar varias veces la misma planta, intenta escribirlo en una sola fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            /*if (sumaComponentes != 100)
            {
                MessageBox.Show("La suma de las cantidades de cada componente no es igual al 100%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgv_Planta.Columns[1].DefaultCellStyle.BackColor = Color.Red;
                return false;
            }
            else
            {
                dgv_Planta.Columns[1].DefaultCellStyle.BackColor = Color.White;
            }*/
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
                    
                    if (ValidarCampos()&& ValidarCamposCompuesto())
                    {                       
                        var oCatalogo = new Es_Catalogo();
                        oCatalogo.Nombre = txtNombreCatalogo.Text;
                        oCatalogo.Estado = 1;

                        if (oCatalogoService.CrearCatalogo(oCatalogo))
                        {
                            bool detalleCatalogo = true;
                           
                                for (int i = 0; i < dgv_Planta.Rows.Count; i++)
                                {
                                    var oDetalleCatalogo = new Es_DetalleCatalogo();
                                    oDetalleCatalogo.ID_Catalogo = oCatalogoService.BuscarUnSoloCatalogo(oCatalogo.Nombre).Rows[0][0].ToString();
                                    oDetalleCatalogo.Id_Planta = oCatalogoService.Buscar_PlantaId(dgv_Planta[0, i].Value.ToString()).Rows[0][0].ToString();
                                    oDetalleCatalogo.Puntos_Necesarios = dgv_Planta[1, i].Value.ToString();

                                    if (!oDetalleCatalogoService.CrearDetalleCatalogo(oDetalleCatalogo))
                                    {
                                        MessageBox.Show("Error al crear el detalle del Catalogo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        detalleCatalogo = false;
                                        break;
                                    }
                                }
                            
                            if (detalleCatalogo)
                            {
                                MessageBox.Show("Catalogo creado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error al crear el Catalogo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                        break;
                    

                case FormMode.update:
                    {
                        if (ValidarCampos()&& ValidarCamposCompuesto())
                        {
                            //actualizo los datos del proveedor seleccionado

                            Es_Catalogo oCatalogoSeleccionado = new Es_Catalogo();

                            oCatalogoSeleccionado.ID  = idCatalogo;
                            oCatalogoSeleccionado.Nombre = txtNombreCatalogo.Text;            
                            oCatalogoSeleccionado.Estado = 1;
                            if (oCatalogoService.ActualizarCatalogo(oCatalogoSeleccionado))
                            {
                                    bool detalleCatalogo = true;
                                
                                    var oDetalleCatalogo = new Es_DetalleCatalogo();
                                    oDetalleCatalogo.ID_Catalogo  = idCatalogo.ToString();
                                    oDetalleCatalogoService.Delete(oDetalleCatalogo);
                                    for (int i = 0; i < dgv_Planta.Rows.Count; i++)
                                    {

                                        //oComposicion.Cod_Prod_Compuesto = oProductoService.BuscarUnSoloProducto(oProductoSeleccionado.Nombre, oProductoSeleccionado.Tipo.ID, oProductoSeleccionado.Stock, oProductoSeleccionado.Costo, oProductoSeleccionado.Precio).Rows[0][0].ToString();
                                        oDetalleCatalogo.Id_Planta = oCatalogoService.Buscar_PlantaId(dgv_Planta[0, i].Value.ToString()).Rows[0][0].ToString();
                                        //oComposicion.Cod_Prod_Componente = cmb.
                                        oDetalleCatalogo.Puntos_Necesarios = dgv_Planta[1, i].Value.ToString();

                                        if (!oDetalleCatalogoService.CrearDetalleCatalogo (oDetalleCatalogo))
                                        {
                                            MessageBox.Show("Error al actualizar el detalle del catalogo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            detalleCatalogo = false;
                                            break;
                                        }
                                    }
                                
                                if (detalleCatalogo)
                                {
                                    MessageBox.Show("Catalogo actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el Catalogo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar el Catalogo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {


                            Es_Catalogo oCatalogoSeleccionado = new Es_Catalogo();

                            oCatalogoSeleccionado.ID = idCatalogo;

                            if (oCatalogoService.ModificarEstadoCatalogo(oCatalogoSeleccionado))
                            {
                                MessageBox.Show("Catalogo Deshabilitado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Catalogo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

            }
        }
        private void txtNombreCatalogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }
        private void txtPuntos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgv_Planta.Rows.Add();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgv_Planta.SelectedRows)
            {
                dgv_Planta.Rows.RemoveAt(fila.Index);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Componentes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_Planta.CurrentCell.ColumnIndex == 1)
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
    }
}