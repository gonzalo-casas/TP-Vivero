
namespace Vivero.Presentacion.Reportes
{
    partial class frmComprasClientes
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
            this.dSVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSVentas = new Vivero.Reportes.DSVentas();
            this.rpvVentaEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboLocalidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Generar = new Vivero.Presentacion.BotonRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_SalirReporte = new Vivero.Presentacion.BotonRedondeado();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // rpvVentaEmpleados
            // 
            this.rpvVentaEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.rpvVentaEmpleados.LocalReport.ReportEmbeddedResource = "Vivero.Presentacion.Reportes.ComprasClientes.ComprasClientes.rdlc";
            this.rpvVentaEmpleados.Location = new System.Drawing.Point(100, 126);
            this.rpvVentaEmpleados.Name = "rpvVentaEmpleados";
            this.rpvVentaEmpleados.ServerReport.BearerToken = null;
            this.rpvVentaEmpleados.Size = new System.Drawing.Size(814, 413);
            this.rpvVentaEmpleados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLocalidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
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
            // cboLocalidad
            // 
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(763, 80);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(118, 28);
            this.cboLocalidad.TabIndex = 20;
            this.cboLocalidad.Click += new System.EventHandler(this.cboLocalidad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(677, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Compras de los clientes ";
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
            this.btn_Generar.Location = new System.Drawing.Point(924, 75);
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
            this.label1.Location = new System.Drawing.Point(342, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(450, 80);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(199, 26);
            this.dtpHasta.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 85);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(106, 20);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Fecha desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(124, 80);
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
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 413);
            this.panel3.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1058, 126);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 413);
            this.panel9.TabIndex = 4;
            // 
            // frmComprasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1158, 612);
            this.Controls.Add(this.rpvVentaEmpleados);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmComprasClientes";
            this.Text = "frmVentaEmpleados";
            this.Load += new System.EventHandler(this.frmVentaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentaEmpleados;
        private System.Windows.Forms.BindingSource dSVentasBindingSource;
        private Vivero.Reportes.DSVentas dSVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Panel panel2;
        private BotonRedondeado btn_Generar;
        private System.Windows.Forms.Panel panel4;
        private BotonRedondeado btn_SalirReporte;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLocalidad;
        private System.Windows.Forms.Label label6;
    }
}