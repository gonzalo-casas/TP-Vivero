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

namespace Vivero.Presentacion
{
    public partial class FrmLogin : Form
    {
        private Es_Empleado miUsuario = new Es_Empleado();
        EmpleadoService oUsuario = new EmpleadoService();
        internal Es_Empleado MiUsuario { get => miUsuario; set => miUsuario = value; }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Ingrese su usuario","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtContrasena.Focus();
                return;
            }

            this.miUsuario.ID = int.Parse(this.txtUsuario.Text);
            this.miUsuario.Contraseña = this.txtContrasena.Text;
            this.miUsuario.Nombre = this.oUsuario.ValidarUsuario(miUsuario.ID, miUsuario.Contraseña);

            if (this.oUsuario.ValidarUsuario(miUsuario.ID, miUsuario.Contraseña) != String.Empty)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = string.Empty;
                this.txtContrasena.Text = string.Empty;
                this.txtUsuario.Focus();
                return;
            }
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                LblIngresoCaracteres.Text = "Solo puedes ingresar numeros";
            }
        }
    }
}
