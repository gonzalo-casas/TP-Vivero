
namespace Vivero.Presentacion.Reportes
{
    partial class ReportViewer
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
            this.components = new System.ComponentModel.Container();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentas = new Vivero.Reportes.DSVentas();
            this.rpvProductos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Generar = new Vivero.Presentacion.BotonRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productoTableAdapter = new Vivero.Reportes.DSVentasTableAdapters.ProductoTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_SalirReporte = new Vivero.Presentacion.BotonRedondeado();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSVentasBindingSource;
            // 
            // dSVentasBindingSource
            // 
            this.dSVentasBindingSource.DataSource = this.dSVentas;
            this.dSVentasBindingSource.Position = 0;
            // 
            // dSVentas
            // 
            this.dSVentas.DataSetName = "DSVentas";
            this.dSVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvProductos
            // 
            this.rpvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvProductos.LocalReport.ReportEmbeddedResource = "Vivero.Presentacion.Reportes.R_Ventas.rdlc";
            this.rpvProductos.Location = new System.Drawing.Point(0, 126);
            this.rpvProductos.Name = "rpvProductos";
            this.rpvProductos.ServerReport.BearerToken = null;
            this.rpvProductos.Size = new System.Drawing.Size(1158, 413);
            this.rpvProductos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Generar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 126);
            this.panel1.TabIndex = 1;
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_Generar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_Generar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Generar.BorderRadius = 20;
            this.btn_Generar.BorderSize = 0;
            this.btn_Generar.FlatAppearance.BorderSize = 0;
            this.btn_Generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generar.ForeColor = System.Drawing.Color.White;
            this.btn_Generar.Location = new System.Drawing.Point(922, 41);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(150, 40);
            this.btn_Generar.TabIndex = 17;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.TextColor = System.Drawing.Color.White;
            this.btn_Generar.UseVisualStyleBackColor = false;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "yyyy/MM/dd";
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(582, 41);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(199, 26);
            this.dtpHasta.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(81, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Fecha desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "yyyy/MM/dd";
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(212, 42);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(199, 26);
            this.dtpDesde.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 539);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 73);
            this.panel2.TabIndex = 2;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SalirReporte);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(911, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 73);
            this.panel4.TabIndex = 5;
            // 
            // btn_SalirReporte
            // 
            this.btn_SalirReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SalirReporte.BorderRadius = 20;
            this.btn_SalirReporte.BorderSize = 0;
            this.btn_SalirReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirReporte.FlatAppearance.BorderSize = 0;
            this.btn_SalirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirReporte.ForeColor = System.Drawing.Color.White;
            this.btn_SalirReporte.Location = new System.Drawing.Point(49, 16);
            this.btn_SalirReporte.Name = "btn_SalirReporte";
            this.btn_SalirReporte.Size = new System.Drawing.Size(153, 40);
            this.btn_SalirReporte.TabIndex = 17;
            this.btn_SalirReporte.Text = "Cerrar";
            this.btn_SalirReporte.TextColor = System.Drawing.Color.White;
            this.btn_SalirReporte.UseVisualStyleBackColor = false;
            this.btn_SalirReporte.Click += new System.EventHandler(this.btn_SalirReporte_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(49, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 17);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(49, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 16);
            this.panel6.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(202, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 73);
            this.panel5.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(49, 73);
            this.panel8.TabIndex = 8;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1158, 612);
            this.Controls.Add(this.rpvProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvProductos;
        private System.Windows.Forms.BindingSource dSVentasBindingSource;
        private Vivero.Reportes.DSVentas dSVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Panel panel2;
        private BotonRedondeado btn_Generar;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private Vivero.Reportes.DSVentasTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private BotonRedondeado btn_SalirReporte;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
    }
}