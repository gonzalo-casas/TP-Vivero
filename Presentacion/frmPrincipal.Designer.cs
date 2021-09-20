
namespace Vivero
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.Plantas = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Location = new System.Drawing.Point(858, 88);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(1048, 88);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(75, 23);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // Plantas
            // 
            this.Plantas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plantas.Location = new System.Drawing.Point(858, 150);
            this.Plantas.Name = "Plantas";
            this.Plantas.Size = new System.Drawing.Size(75, 23);
            this.Plantas.TabIndex = 2;
            this.Plantas.Text = "Plantas";
            this.Plantas.UseVisualStyleBackColor = true;
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Location = new System.Drawing.Point(1048, 160);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(75, 23);
            this.btnCatalogos.TabIndex = 3;
            this.btnCatalogos.Text = "Catalogos";
            this.btnCatalogos.UseVisualStyleBackColor = true;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Location = new System.Drawing.Point(858, 231);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(87, 23);
            this.btnProveedor.TabIndex = 4;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(1058, 231);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 72);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vivero.Properties.Resources.icons8_user_64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 72);
            this.panel3.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnCatalogos);
            this.Controls.Add(this.Plantas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button Plantas;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

