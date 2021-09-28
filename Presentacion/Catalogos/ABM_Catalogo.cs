using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            oCatalogoService = new CatalogoService();           
        }
        //declaro los objetos
        private FormMode formMode = FormMode.insert;
        private readonly CatalogoService oCatalogoService;
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
        private int idCatalogo;
        private int EstadoActual;
        public ABM_Catalogo()
        {
            InitializeComponent();
            oCatalogoService = new CatalogoService();
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

            cmb.HeaderText = "Componente";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 4;
            DataTable tablaCatalogo = oCatalogoService.Buscar_Planta();
            DataRow filaDefault = tablaCatalogo.NewRow();
            filaDefault[1] = "Seleccionar";
            filaDefault[4] = 0;
            filaDefault[5] = 0;
            filaDefault[6] = 0;
            tablaCatalogo.Rows.Add(filaDefault);
            cmb.DataSource = tablaCatalogo;
            cmb.DisplayMember = "Nombre";
            cmb.DisplayIndex = 0;
            cmb.ValueMember = "Nombre";
            for (int i = 0; i < tablaCatalogo.Rows.Count; i++)
            {
                if (tablaCatalogo.Rows[i]["Nombre"].ToString() == "Seleccionar")
                {
                    cmb.DefaultCellStyle.NullValue = tablaCatalogo.Rows[i]["Nombre"];
                }
            }
            if (dgv_Planta.ColumnCount != 2)
            {
                dgv_Planta.Columns.Insert(0, cmb);
            }
        
            else
            {
                this.Size = new Size(500, 510);
                this.gbPlantas.Visible = false;
            }

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
                        txtNumeroId.Enabled = true;
                        //txtNombreComun.Enabled = true;
                        txtPuntos.Enabled = true;
                        

                        break;
                    }

                case FormMode.delete:
                    {
                        actualizarCampos();
                        this.Text = "Deshabilitar Catalogo";
                        txtNumeroId.Enabled = false;
                        //txtNombreComun.Enabled = false;
                        txtPuntos.Enabled = false;
                        
                        break;
                    }
            }


        }
        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            CatalogoService oCatalogoSeleccionado = new CatalogoService();
           // tabla = oCatalogoSeleccionado.RecuperarPorId(idCatalogo);

            txtNumeroId.Text = tabla.Rows[0]["Nombre"].ToString();
            //txtNombreComun.Text = tabla.Rows[0]["Razon_Social"].ToString();
            txtPuntos.Text = tabla.Rows[0]["Telefono"].ToString();
            EstadoActual = Convert.ToInt32(tabla.Rows[0]["Estado"]);




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
            if (txtNumeroId.Text == string.Empty)
            {
                MessageBox.Show("Ingrese numero del ID por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroId.BackColor = Color.Red;
                txtNumeroId.Focus();
                return false;
            }
            else
                txtNumeroId.BackColor = Color.White;

            if (txtPuntos.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Puntos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPuntos.BackColor = Color.Red;
                txtPuntos.Focus();
                return false;
            }
            else
                txtPuntos.BackColor = Color.White;


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
                    {


                        if (ValidarCampos())
                        {
                            var oCatalogo = new Es_Catalogo();
                            oCatalogo.ID = txtNumeroId.Text;
                           // oCatalogo.Id_Planta = .Text;
                            oCatalogo.Puntos_Necesarios = txtPuntos.Text;
                            //oCatalogo.Estado = 1;

                            if (oCatalogoService.CrearCatalogo(oCatalogo))
                            {
                                MessageBox.Show("Catalogo insertado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }


                        break;
                    }

                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {
                            //actualizo los datos del proveedor seleccionado

                            Es_Catalogo oCatalogoSeleccionado = new Es_Catalogo();

                            oCatalogoSeleccionado.ID =txtNumeroId.Text;
                            oCatalogoSeleccionado.Puntos_Necesarios = txtPuntos.Text;
                           // oProveedorSeleccionado.Razon_Social = txtRSProv.Text;
                            //oCatalogoSeleccionado.Estado = EstadoActual;


                            if (oCatalogoService.ActualizarCatalogo(oCatalogoSeleccionado))
                            {
                                MessageBox.Show("Catalogo actualizado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Catalogo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar el Catalogo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {


                            Es_Catalogo oCatalogoSeleccionado = new Es_Catalogo();

                            oCatalogoSeleccionado.ID = txtNumeroId.Text;

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
        private void txtNumeroId_KeyPress(object sender, KeyPressEventArgs e)
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

        
    }
}