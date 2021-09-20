
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.Plantas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 672);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnSalir);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 605);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 67);
            this.panel4.TabIndex = 1;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblNombreUsuario);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 72);
            this.panel2.TabIndex = 0;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(82, 25);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(115, 24);
            this.LblNombreUsuario.TabIndex = 1;
            this.LblNombreUsuario.Text = "Bienvenido";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(81, 72);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 430);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClientes);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 70);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnProveedor);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 70);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnEmpleados);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 70);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnProductos);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 210);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 70);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Plantas);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 280);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 70);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnCatalogos);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 350);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 70);
            this.panel11.TabIndex = 5;
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCatalogos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogos.Image = global::Vivero.Properties.Resources.icons8_catalog_49;
            this.btnCatalogos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.Location = new System.Drawing.Point(12, 0);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(188, 70);
            this.btnCatalogos.TabIndex = 3;
            this.btnCatalogos.Text = "Catalogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogos.UseVisualStyleBackColor = true;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // Plantas
            // 
            this.Plantas.Dock = System.Windows.Forms.DockStyle.Right;
            this.Plantas.FlatAppearance.BorderSize = 0;
            this.Plantas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plantas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plantas.Image = global::Vivero.Properties.Resources.icons8_plant_60;
            this.Plantas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plantas.Location = new System.Drawing.Point(12, 0);
            this.Plantas.Name = "Plantas";
            this.Plantas.Size = new System.Drawing.Size(188, 70);
            this.Plantas.TabIndex = 2;
            this.Plantas.Text = "Plantas";
            this.Plantas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Plantas.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = global::Vivero.Properties.Resources.icons8_cleaning_products_64;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(12, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(188, 70);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::Vivero.Properties.Resources.icons8_employee_64;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(12, 0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(188, 70);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.Image = global::Vivero.Properties.Resources.icons8_truck_64;
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(12, 0);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(188, 70);
            this.btnProveedor.TabIndex = 4;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::Vivero.Properties.Resources.icons8_customer_64;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(188, 70);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Vivero.Properties.Resources.icons8_exit_60;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnSalir.Location = new System.Drawing.Point(12, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(188, 67);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "      Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Vivero.Properties.Resources.icons8_user_40;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 672);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}

