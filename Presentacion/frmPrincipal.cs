using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivero.Presentacion;
using Vivero.Presentacion.Empleados;

namespace Vivero
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin fl;
            fl = new FrmLogin();
            fl.ShowDialog();

            if (!fl.LoginOk)
                this.Close();
            else
                this.Text += "- Usuario: " + fl.MiUsuario.Id_usuario;

            fl.Dispose();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ABMC_Empleados fl;
            fl = new ABMC_Empleados();
            fl.ShowDialog();
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}