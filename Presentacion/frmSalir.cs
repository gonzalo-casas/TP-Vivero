using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vivero
{
    public partial class FrmSalir : Form
    {
        public FrmSalir()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
                Application.Restart();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
