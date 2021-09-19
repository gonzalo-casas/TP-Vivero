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

            if (fl.MiUsuario.Id_usuario == 0)
                this.Close();
            else
                this.Text += "- Usuario: " + fl.MiUsuario.Nombre;

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
    }
}
//hola