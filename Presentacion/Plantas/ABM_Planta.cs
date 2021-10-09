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
using Vivero.Negocio.EstructuraNegocio;
using Vivero.Negocio.Servicios;

namespace Vivero.Presentacion.Plantas
{
    public partial class ABM_Planta : Form
    {
        
        //PlantasService planta = new PlantasService();
        public ABM_Planta(int idPlanta)
        {
            InitializeComponent();
            this.idPlanta = idPlanta;
            
            oTipoPlantaService = new TipoPlantaService();
            oEstadoPlantaService = new EstadoPlantaService();
            oPlantasService = new PlantasService(); 
        }

        public ABM_Planta()
        {
            InitializeComponent();
            
            oTipoPlantaService = new TipoPlantaService();
            oEstadoPlantaService = new EstadoPlantaService();
            oPlantasService = new PlantasService();
        }
        private FormMode formMode = FormMode.insert;
        private readonly PlantasService oPlantasService;
        private readonly TipoPlantaService oTipoPlantaService;
        private readonly EstadoPlantaService oEstadoPlantaService;
        private int idPlanta;
        internal string Codigo;

      

        
        public enum FormMode
        {
            insert,
            update,
            delete
        }
        public void SeleccionarOpcion(FormMode op)
        {
            formMode = op;

        }

        private void ABM_Planta_Load(object sender, EventArgs e)
        {
            LlenarCombo(cmb_TipoPlanta, oTipoPlantaService.traerTode(), "Nombre", "ID");
            LlenarCombo(cmb_EstadoPlanta, oEstadoPlantaService.traerTode(), "Descripcion", "ID");    // lleno los combos

            

            //switch para actualizar titulo y habilitar  txt y cbo

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Planta";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Planta";
                        // Recuperar usuario seleccionado en la grilla 
                        actualizarCampos();
                        
                        txt_NCientPlanta.Enabled = true;
                        txt_NomComPlanta.Enabled = true;
                        cmb_EstadoPlanta.Enabled = true;
                        cmb_TipoPlanta.Enabled = true;
                        txt_PrecioPlanta.Enabled = true;
                        txt_StockPlanta.Enabled = true;
                       

                        break;
                    }

                case FormMode.delete:
                    {
                        actualizarCampos();
                        this.Text = "Deshabilitar Planta";
                        
                        txt_NCientPlanta.Enabled = false;
                        txt_NomComPlanta.Enabled = false;
                        cmb_EstadoPlanta.Enabled = false;
                        cmb_TipoPlanta.Enabled = false;
                        txt_PrecioPlanta.Enabled = false;
                        txt_StockPlanta.Enabled = false;
                        break;
                    }

            }



        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }





        private void btn_RegistrarPlanta_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {

                        if (1==1)
                        {
                            var _ep = new Es_Planta();
                            //_ep.Codigo = txt_CodPlanta.Text;
                            //_ep.Codigo = oPlantasService.NuevoId();
                            _ep.NombreCientifico = txt_NCientPlanta.Text;
                            _ep.NombreComun = txt_NomComPlanta.Text;
                            _ep.Precio = txt_PrecioPlanta.Text;
                            _ep.Stock = txt_StockPlanta.Text;
                            _ep.Estado = 1;
                            _ep.Tipo= new Es_TipoPlanta();
                            _ep.Tipo.Id = (int)cmb_TipoPlanta.SelectedValue;
                            if (oPlantasService.Crear(_ep))
                            {

                                MessageBox.Show("Planta registrada correctamente");
                                this.Close();
                            }
                            //else { MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }




                        }
                    break;
                    }
                case FormMode.update:
                    {
                        if (1 == 1)
                        {
                            //actualizo los datos dela planta seleccionado

                            Es_Planta _ep = new Es_Planta();
                            _ep.Codigo = idPlanta.ToString();
                            _ep.NombreCientifico = txt_NCientPlanta.Text;
                            _ep.NombreComun = txt_NomComPlanta.Text;
                            _ep.Precio = txt_PrecioPlanta.Text;
                            _ep.Stock = txt_StockPlanta.Text;
                            _ep.Estado = 1;
                            _ep.Tipo = new Es_TipoPlanta();
                            _ep.Tipo.Id = (int)cmb_TipoPlanta.SelectedValue;



                            if (oPlantasService.Actualizar(_ep))
                            {
                                MessageBox.Show("Planta actualizada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la Planta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro/a que desea deshabilitar la planta seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {


                            Es_Planta _ep = new Es_Planta();

                            _ep.Codigo = idPlanta.ToString();

                            if (oPlantasService.EliminarPlanta(_ep))
                            {
                                MessageBox.Show("Planta Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar La Planta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    }



            }
        }
        private void actualizarCampos()
        {
            DataTable tabla = new DataTable();
            PlantasService _ep = new PlantasService();
            tabla = _ep.Recuperar_Planta(idPlanta.ToString());
            txt_NCientPlanta.Text = tabla.Rows[0]["NombreCientifico"].ToString();
            txt_NomComPlanta.Text = tabla.Rows[0]["NombreComun"].ToString();
            cmb_EstadoPlanta.Text = tabla.Rows[0]["Estado"].ToString();
            cmb_TipoPlanta.Text = tabla.Rows[0]["Tipo"].ToString();
            txt_PrecioPlanta.Text = tabla.Rows[0]["Precio"].ToString();
            txt_StockPlanta.Text = tabla.Rows[0]["Precio"].ToString();
            

            tabla.Clear();


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





