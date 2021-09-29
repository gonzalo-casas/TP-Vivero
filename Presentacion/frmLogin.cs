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

        Image ojo = (Image)Properties.Resources.ojo;
        Image ojoPintado = (Image)Properties.Resources.ojo_pintado;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '\0';
            txtContrasena.UseSystemPasswordChar = false;

            pbOjo.Image = ojo;


        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Ingrese su usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtContrasena.Text))
            {
                MessageBox.Show("Ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtContrasena.Focus();
                return;
            }

            this.miUsuario.ID = int.Parse(this.txtUsuario.Text);
            this.miUsuario.Contraseña = this.txtContrasena.Text;
            Array arrayUsuario = this.oUsuario.ValidarUsuario(miUsuario.ID, miUsuario.Contraseña);
            this.miUsuario.Nombre = arrayUsuario.GetValue(0).ToString();
            

            if (this.miUsuario.Nombre != string.Empty)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miUsuario.Perfil = new Es_Perfil();
                this.miUsuario.Perfil.IdPerfil = int.Parse(arrayUsuario.GetValue(1).ToString());
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

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = string.Empty;
                txtContrasena.ForeColor = Color.White;
                txtContrasena.PasswordChar = '\u25CF';
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void pbOjo_Click(object sender, EventArgs e)
        {
            
            
            if (pbOjo.Image == ojo)
            {
                pbOjo.Image = ojoPintado;
                txtContrasena.PasswordChar = '\0';
                txtContrasena.UseSystemPasswordChar = false;

            }
            else
            {
                pbOjo.Image = ojo;
                if (txtContrasena.Text != "Contraseña")
                {
                    txtContrasena.PasswordChar = '\u25CF';
                    txtContrasena.UseSystemPasswordChar = true;
                }
            }

        }
    }
}
