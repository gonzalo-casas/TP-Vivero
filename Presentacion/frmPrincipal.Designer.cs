
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelCatalogos = new System.Windows.Forms.Panel();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.panelPlantas = new System.Windows.Forms.Panel();
            this.btnPlantas = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelEmpleados = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.BtnProveedor = new System.Windows.Forms.Button();
            this.PanelClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelCatalogos.SuspendLayout();
            this.panelPlantas.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.panelEmpleados.SuspendLayout();
            this.panelProveedores.SuspendLayout();
            this.PanelClientes.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(181)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1061);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelCatalogos);
            this.panel5.Controls.Add(this.panelPlantas);
            this.panel5.Controls.Add(this.panelProductos);
            this.panel5.Controls.Add(this.panelEmpleados);
            this.panel5.Controls.Add(this.panelProveedores);
            this.panel5.Controls.Add(this.PanelClientes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 430);
            this.panel5.TabIndex = 2;
            // 
            // panelCatalogos
            // 
            this.panelCatalogos.Controls.Add(this.btnCatalogos);
            this.panelCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogos.Location = new System.Drawing.Point(0, 350);
            this.panelCatalogos.Name = "panelCatalogos";
            this.panelCatalogos.Size = new System.Drawing.Size(200, 70);
            this.panelCatalogos.TabIndex = 5;
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
            // panelPlantas
            // 
            this.panelPlantas.Controls.Add(this.btnPlantas);
            this.panelPlantas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlantas.Location = new System.Drawing.Point(0, 280);
            this.panelPlantas.Name = "panelPlantas";
            this.panelPlantas.Size = new System.Drawing.Size(200, 70);
            this.panelPlantas.TabIndex = 4;
            // 
            // btnPlantas
            // 
            this.btnPlantas.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlantas.FlatAppearance.BorderSize = 0;
            this.btnPlantas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantas.Image = global::Vivero.Properties.Resources.icons8_plant_60;
            this.btnPlantas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantas.Location = new System.Drawing.Point(12, 0);
            this.btnPlantas.Name = "btnPlantas";
            this.btnPlantas.Size = new System.Drawing.Size(188, 70);
            this.btnPlantas.TabIndex = 2;
            this.btnPlantas.Text = "Plantas";
            this.btnPlantas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlantas.UseVisualStyleBackColor = true;
            this.btnPlantas.Click += new System.EventHandler(this.btnPlantas_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.Controls.Add(this.btnProductos);
            this.panelProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductos.Location = new System.Drawing.Point(0, 210);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(200, 70);
            this.panelProductos.TabIndex = 3;
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
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelEmpleados
            // 
            this.panelEmpleados.Controls.Add(this.btnEmpleados);
            this.panelEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleados.Location = new System.Drawing.Point(0, 140);
            this.panelEmpleados.Name = "panelEmpleados";
            this.panelEmpleados.Size = new System.Drawing.Size(200, 70);
            this.panelEmpleados.TabIndex = 2;
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
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panelProveedores
            // 
            this.panelProveedores.Controls.Add(this.BtnProveedor);
            this.panelProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedores.Location = new System.Drawing.Point(0, 70);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(200, 70);
            this.panelProveedores.TabIndex = 1;
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedor.Image = global::Vivero.Properties.Resources.icons8_truck_64;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(12, 0);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Size = new System.Drawing.Size(188, 70);
            this.BtnProveedor.TabIndex = 4;
            this.BtnProveedor.Text = "Proveedores";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProveedor.UseVisualStyleBackColor = false;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // PanelClientes
            // 
            this.PanelClientes.Controls.Add(this.btnClientes);
            this.PanelClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelClientes.Location = new System.Drawing.Point(0, 0);
            this.PanelClientes.Name = "PanelClientes";
            this.PanelClientes.Size = new System.Drawing.Size(200, 70);
            this.PanelClientes.TabIndex = 0;
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
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnSalir);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 994);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 67);
            this.panel4.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(87)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.lblRolUsuario);
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
            this.LblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.LblNombreUsuario.Location = new System.Drawing.Point(69, 9);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(115, 24);
            this.LblNombreUsuario.TabIndex = 1;
            this.LblNombreUsuario.Text = "Bienvenido";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.panelForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelForms.Controls.Add(this.pictureBox2);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(200, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(984, 1061);
            this.panelForms.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::Vivero.Properties.Resources.ImagenInicio;
            this.pictureBox2.Location = new System.Drawing.Point(263, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(737, 1086);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolUsuario.ForeColor = System.Drawing.Color.White;
            this.lblRolUsuario.Location = new System.Drawing.Point(71, 33);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(113, 24);
            this.lblRolUsuario.TabIndex = 2;
            this.lblRolUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 1061);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelCatalogos.ResumeLayout(false);
            this.panelPlantas.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.panelEmpleados.ResumeLayout(false);
            this.panelProveedores.ResumeLayout(false);
            this.PanelClientes.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPlantas;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Button BtnProveedor;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelCatalogos;
        private System.Windows.Forms.Panel panelPlantas;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Panel panelEmpleados;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Panel PanelClientes;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRolUsuario;
    }
}

