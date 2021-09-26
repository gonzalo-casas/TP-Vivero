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
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //frmInicio fi;
            //fi = new frmInicio();
            //fi.MdiParent = this;
            //fi.Show();
            //fi.Dock = DockStyle.Fill;
            //fi.WindowState = FormWindowState.Minimized;
            //fi.WindowState = FormWindowState.Maximized;

            FrmLogin fl;
            fl = new FrmLogin();
            fl.ShowDialog();

            if (string.IsNullOrEmpty(fl.MiUsuario.Nombre))
                this.Close();
            else
            {
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
                this.LblNombreUsuario.Text = fl.MiUsuario.Nombre;

                if (fl.MiUsuario.Perfil.IdPerfil.Equals(1)) // si es administrador...
                    habilitarOpciones(true);
                else
                    habilitarOpciones(false);

            }
                

            fl.Dispose();
        }

        private void habilitarOpciones(bool x)
        {
            btnClientes.Enabled = x;
            BtnProveedor.Enabled = x;
            btnEmpleados.Enabled = x;
            btnProductos.Enabled = x;
            btnPlantas.Enabled = x;
            btnCatalogos.Enabled = x;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<C_Empleados>();
            btnEmpleados.BackColor = Color.FromArgb(205, 241, 231);
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
            AbrirFormulario<C_Proveedores>();
            BtnProveedor.BackColor = Color.FromArgb(205, 241, 231);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["C_Empleados"] == null)
                btnEmpleados.BackColor = Color.FromArgb(135, 181, 168);
            if (Application.OpenForms["C_Proveedores"] == null)
                BtnProveedor.BackColor = Color.FromArgb(135, 181, 168);
            //if (Application.OpenForms["Form3"] == null)
            //    button3.BackColor = Color.FromArgb(4, 41, 68);
        }
    }
}