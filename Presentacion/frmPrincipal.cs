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
            frmInicio fi;
            fi = new frmInicio();
            fi.MdiParent = this;
            fi.Show();
            fi.Dock = DockStyle.Fill;
            fi.WindowState = FormWindowState.Minimized;
            fi.WindowState = FormWindowState.Maximized;

            FrmLogin fl;
            fl = new FrmLogin();
            fl.ShowDialog();

            if (string.IsNullOrEmpty(fl.MiUsuario.Nombre))
                this.Close();
            else
            {
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
                this.LblNombreUsuario.Text = fl.MiUsuario.Nombre;
            }
                

            fl.Dispose();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null && ActiveMdiChild.GetType() != C_Empleados)
                ActiveMdiChild.Close();
            C_Empleados fl;
            fl = new C_Empleados();
            fl.MdiParent = this;
            fl.Show();
            fl.Dock = DockStyle.Fill;
            fl.WindowState = FormWindowState.Minimized;
            fl.WindowState = FormWindowState.Maximized;
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

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ABMC_Proveedores fl;
            fl = new ABMC_Proveedores();
            fl.MdiParent = this;
            fl.Show();
            fl.Dock = DockStyle.Fill;
            fl.WindowState = FormWindowState.Minimized;
            fl.WindowState = FormWindowState.Maximized;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}