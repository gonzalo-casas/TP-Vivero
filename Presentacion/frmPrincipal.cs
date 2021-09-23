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
using Vivero.Presentacion.Proveedor;

namespace Vivero
{
    public partial class FrmPrincipal : Form
    {
        private readonly C_Empleados FrmC_Empleados = new C_Empleados();
        private readonly ABMC_Proveedores FrmC_Proveedores = new ABMC_Proveedores();
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmC_Empleados.MdiParent = this;
            FrmC_Proveedores.MdiParent = this;
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
            if (ActiveMdiChild!= FrmC_Empleados)
            {
                
                FrmC_Empleados.Dock = DockStyle.Fill;
                FrmC_Empleados.WindowState = FormWindowState.Minimized;
                FrmC_Empleados.WindowState = FormWindowState.Maximized;
                FrmC_Empleados.Show();
            }
                
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
            if (ActiveMdiChild != FrmC_Proveedores)
            {
                FrmC_Proveedores.Dock = DockStyle.Fill;
                FrmC_Proveedores.WindowState = FormWindowState.Minimized;
                FrmC_Proveedores.WindowState = FormWindowState.Maximized;
                FrmC_Proveedores.Show();
            }
                
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}