
namespace Vivero.Presentacion.Reportes
{
    partial class frmReportes
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
            this.panelReportes = new System.Windows.Forms.Panel();
            this.btn_CatalogosSeleccionados = new Vivero.Presentacion.BotonRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VentaEmpleados = new Vivero.Presentacion.BotonRedondeado();
            this.btn_ProductosVendidos = new Vivero.Presentacion.BotonRedondeado();
            this.btn_VentasPorAño = new Vivero.Presentacion.BotonRedondeado();
            this.panelReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReportes
            // 
            this.panelReportes.Controls.Add(this.btn_VentasPorAño);
            this.panelReportes.Controls.Add(this.btn_CatalogosSeleccionados);
            this.panelReportes.Controls.Add(this.label1);
            this.panelReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReportes.Location = new System.Drawing.Point(0, 0);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(1151, 646);
            this.panelReportes.TabIndex = 19;
            // 
            // btn_CatalogosSeleccionados
            // 
            this.btn_CatalogosSeleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_CatalogosSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_CatalogosSeleccionados.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CatalogosSeleccionados.BorderRadius = 10;
            this.btn_CatalogosSeleccionados.BorderSize = 0;
            this.btn_CatalogosSeleccionados.FlatAppearance.BorderSize = 0;
            this.btn_CatalogosSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CatalogosSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CatalogosSeleccionados.ForeColor = System.Drawing.Color.White;
            this.btn_CatalogosSeleccionados.Location = new System.Drawing.Point(130, 386);
            this.btn_CatalogosSeleccionados.Name = "btn_CatalogosSeleccionados";
            this.btn_CatalogosSeleccionados.Size = new System.Drawing.Size(200, 100);
            this.btn_CatalogosSeleccionados.TabIndex = 19;
            this.btn_CatalogosSeleccionados.Text = "Catalogos Seleccionados";
            this.btn_CatalogosSeleccionados.TextColor = System.Drawing.Color.White;
            this.btn_CatalogosSeleccionados.UseVisualStyleBackColor = false;
            this.btn_CatalogosSeleccionados.Click += new System.EventHandler(this.btn_CatalogosSeleccionados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el reporte que desea generar";
            // 
            // btn_VentaEmpleados
            // 
            this.btn_VentaEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_VentaEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_VentaEmpleados.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_VentaEmpleados.BorderRadius = 10;
            this.btn_VentaEmpleados.BorderSize = 0;
            this.btn_VentaEmpleados.FlatAppearance.BorderSize = 0;
            this.btn_VentaEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VentaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VentaEmpleados.ForeColor = System.Drawing.Color.White;
            this.btn_VentaEmpleados.Location = new System.Drawing.Point(130, 248);
            this.btn_VentaEmpleados.Name = "btn_VentaEmpleados";
            this.btn_VentaEmpleados.Size = new System.Drawing.Size(200, 100);
            this.btn_VentaEmpleados.TabIndex = 18;
            this.btn_VentaEmpleados.Text = "Venta Empleados";
            this.btn_VentaEmpleados.TextColor = System.Drawing.Color.White;
            this.btn_VentaEmpleados.UseVisualStyleBackColor = false;
            this.btn_VentaEmpleados.Click += new System.EventHandler(this.btn_VentaEmpleados_Click);
            // 
            // btn_ProductosVendidos
            // 
            this.btn_ProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ProductosVendidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ProductosVendidos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ProductosVendidos.BorderRadius = 10;
            this.btn_ProductosVendidos.BorderSize = 0;
            this.btn_ProductosVendidos.FlatAppearance.BorderSize = 0;
            this.btn_ProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.btn_ProductosVendidos.Location = new System.Drawing.Point(130, 108);
            this.btn_ProductosVendidos.Name = "btn_ProductosVendidos";
            this.btn_ProductosVendidos.Size = new System.Drawing.Size(200, 100);
            this.btn_ProductosVendidos.TabIndex = 17;
            this.btn_ProductosVendidos.Text = "Productos Vendidos";
            this.btn_ProductosVendidos.TextColor = System.Drawing.Color.White;
            this.btn_ProductosVendidos.UseVisualStyleBackColor = false;
            this.btn_ProductosVendidos.Click += new System.EventHandler(this.btn_ProductosVendidos_Click);
            // 
            // btn_VentasPorAño
            // 
            this.btn_VentasPorAño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_VentasPorAño.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_VentasPorAño.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_VentasPorAño.BorderRadius = 10;
            this.btn_VentasPorAño.BorderSize = 0;
            this.btn_VentasPorAño.FlatAppearance.BorderSize = 0;
            this.btn_VentasPorAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VentasPorAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VentasPorAño.ForeColor = System.Drawing.Color.White;
            this.btn_VentasPorAño.Location = new System.Drawing.Point(573, 386);
            this.btn_VentasPorAño.Name = "btn_VentasPorAño";
            this.btn_VentasPorAño.Size = new System.Drawing.Size(200, 100);
            this.btn_VentasPorAño.TabIndex = 20;
            this.btn_VentasPorAño.Text = "Ventas Por Año";
            this.btn_VentasPorAño.TextColor = System.Drawing.Color.White;
            this.btn_VentasPorAño.UseVisualStyleBackColor = false;
            this.btn_VentasPorAño.Click += new System.EventHandler(this.btn_VentasPorAño_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1151, 646);
            this.Controls.Add(this.btn_VentaEmpleados);
            this.Controls.Add(this.btn_ProductosVendidos);
            this.Controls.Add(this.panelReportes);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.panelReportes.ResumeLayout(false);
            this.panelReportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BotonRedondeado btn_ProductosVendidos;
        private BotonRedondeado btn_VentaEmpleados;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Label label1;
        private BotonRedondeado btn_CatalogosSeleccionados;
        private BotonRedondeado btn_VentasPorAño;
    }
}