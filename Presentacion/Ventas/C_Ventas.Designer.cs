namespace Vivero.Presentacion.Ventas
{
    partial class C_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_NroFactura = new System.Windows.Forms.TextBox();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Empleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_SalirVenta = new Vivero.Presentacion.BotonRedondeado();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.btn_ConsultarVentas = new Vivero.Presentacion.BotonRedondeado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_DetalleFactura = new System.Windows.Forms.DataGridView();
            this.colNroItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.AnularBoton = new Vivero.Presentacion.BotonRedondeado();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.btn_AgregarVenta = new Vivero.Presentacion.BotonRedondeado();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetalleFactura)).BeginInit();
            this.panel11.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.panelEliminar.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NroFactura
            // 
            this.txt_NroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NroFactura.Location = new System.Drawing.Point(192, 22);
            this.txt_NroFactura.Name = "txt_NroFactura";
            this.txt_NroFactura.Size = new System.Drawing.Size(127, 26);
            this.txt_NroFactura.TabIndex = 4;
            this.txt_NroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NroFactura_KeyPress);
            // 
            // txt_Documento
            // 
            this.txt_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Documento.Location = new System.Drawing.Point(192, 55);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(127, 26);
            this.txt_Documento.TabIndex = 5;
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // txt_Empleado
            // 
            this.txt_Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empleado.Location = new System.Drawing.Point(192, 88);
            this.txt_Empleado.Name = "txt_Empleado";
            this.txt_Empleado.Size = new System.Drawing.Size(127, 26);
            this.txt_Empleado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "N° Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Empleado:";
            // 
            // dgv_Ventas
            // 
            this.dgv_Ventas.AllowUserToAddRows = false;
            this.dgv_Ventas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            this.dgv_Ventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.colNumero,
            this.colDocumento,
            this.colFecha,
            this.colEmpleado,
            this.colMonto,
            this.colPuntos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ventas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ventas.Enabled = false;
            this.dgv_Ventas.Location = new System.Drawing.Point(100, 0);
            this.dgv_Ventas.Name = "dgv_Ventas";
            this.dgv_Ventas.ReadOnly = true;
            this.dgv_Ventas.RowHeadersVisible = false;
            this.dgv_Ventas.RowHeadersWidth = 51;
            this.dgv_Ventas.RowTemplate.Height = 40;
            this.dgv_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ventas.Size = new System.Drawing.Size(811, 214);
            this.dgv_Ventas.TabIndex = 11;
            this.dgv_Ventas.SelectionChanged += new System.EventHandler(this.dgv_Ventas_SelectionChanged);
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.MinimumWidth = 6;
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Numero";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colDocumento
            // 
            this.colDocumento.HeaderText = "Doc Cliente";
            this.colDocumento.MinimumWidth = 6;
            this.colDocumento.Name = "colDocumento";
            this.colDocumento.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colEmpleado
            // 
            this.colEmpleado.HeaderText = "Empleado";
            this.colEmpleado.MinimumWidth = 6;
            this.colEmpleado.Name = "colEmpleado";
            this.colEmpleado.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.MinimumWidth = 6;
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colPuntos
            // 
            this.colPuntos.HeaderText = "Puntos";
            this.colPuntos.Name = "colPuntos";
            this.colPuntos.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 814);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 73);
            this.panel1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SalirVenta);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(764, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 73);
            this.panel4.TabIndex = 4;
            // 
            // btn_SalirVenta
            // 
            this.btn_SalirVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SalirVenta.BorderRadius = 20;
            this.btn_SalirVenta.BorderSize = 0;
            this.btn_SalirVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirVenta.FlatAppearance.BorderSize = 0;
            this.btn_SalirVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirVenta.ForeColor = System.Drawing.Color.White;
            this.btn_SalirVenta.Location = new System.Drawing.Point(49, 16);
            this.btn_SalirVenta.Name = "btn_SalirVenta";
            this.btn_SalirVenta.Size = new System.Drawing.Size(153, 40);
            this.btn_SalirVenta.TabIndex = 17;
            this.btn_SalirVenta.Text = "Cerrar";
            this.btn_SalirVenta.TextColor = System.Drawing.Color.White;
            this.btn_SalirVenta.UseVisualStyleBackColor = false;
            this.btn_SalirVenta.Click += new System.EventHandler(this.btn_SalirVenta_Click);
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
            this.panel3.Controls.Add(this.chk_Inactivos);
            this.panel3.Controls.Add(this.chk_Activos);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTituloVentas);
            this.panel3.Controls.Add(this.btn_ConsultarVentas);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_NroFactura);
            this.panel3.Controls.Add(this.txt_Documento);
            this.panel3.Controls.Add(this.txt_Empleado);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 165);
            this.panel3.TabIndex = 16;
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Inactivos.Location = new System.Drawing.Point(497, 22);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(95, 24);
            this.chk_Inactivos.TabIndex = 22;
            this.chk_Inactivos.Text = "Anuladas";
            this.chk_Inactivos.UseVisualStyleBackColor = true;
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.Checked = true;
            this.chk_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Activos.Location = new System.Drawing.Point(373, 21);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(118, 24);
            this.chk_Activos.TabIndex = 21;
            this.chk_Activos.Text = "Confirmadas";
            this.chk_Activos.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(192, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.ShowCheckBox = true;
            this.dtpFecha.Size = new System.Drawing.Size(127, 26);
            this.dtpFecha.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha:";
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Font = new System.Drawing.Font("Berlin Sans FB", 44.25F);
            this.lblTituloVentas.Location = new System.Drawing.Point(726, 25);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(240, 65);
            this.lblTituloVentas.TabIndex = 17;
            this.lblTituloVentas.Text = "Facturas";
            // 
            // btn_ConsultarVentas
            // 
            this.btn_ConsultarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarVentas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ConsultarVentas.BorderRadius = 20;
            this.btn_ConsultarVentas.BorderSize = 0;
            this.btn_ConsultarVentas.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarVentas.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultarVentas.Location = new System.Drawing.Point(373, 74);
            this.btn_ConsultarVentas.Name = "btn_ConsultarVentas";
            this.btn_ConsultarVentas.Size = new System.Drawing.Size(150, 40);
            this.btn_ConsultarVentas.TabIndex = 16;
            this.btn_ConsultarVentas.Text = "Consultar";
            this.btn_ConsultarVentas.TextColor = System.Drawing.Color.White;
            this.btn_ConsultarVentas.UseVisualStyleBackColor = false;
            this.btn_ConsultarVentas.Click += new System.EventHandler(this.btn_ConsultarVentas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Ventas);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.dgv_DetalleFactura);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 649);
            this.panel2.TabIndex = 17;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(100, 214);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(811, 40);
            this.panel16.TabIndex = 15;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.label5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(378, 40);
            this.panel17.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Detalle de factura";
            // 
            // dgv_DetalleFactura
            // 
            this.dgv_DetalleFactura.AllowUserToAddRows = false;
            this.dgv_DetalleFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            this.dgv_DetalleFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroItem,
            this.colTipoItem,
            this.colNombreItem,
            this.colCantidad,
            this.colPrecio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DetalleFactura.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DetalleFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DetalleFactura.Location = new System.Drawing.Point(100, 254);
            this.dgv_DetalleFactura.Name = "dgv_DetalleFactura";
            this.dgv_DetalleFactura.ReadOnly = true;
            this.dgv_DetalleFactura.RowHeadersVisible = false;
            this.dgv_DetalleFactura.RowHeadersWidth = 51;
            this.dgv_DetalleFactura.RowTemplate.Height = 40;
            this.dgv_DetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DetalleFactura.Size = new System.Drawing.Size(811, 295);
            this.dgv_DetalleFactura.TabIndex = 16;
            // 
            // colNroItem
            // 
            this.colNroItem.HeaderText = "N° Item";
            this.colNroItem.Name = "colNroItem";
            this.colNroItem.ReadOnly = true;
            // 
            // colTipoItem
            // 
            this.colTipoItem.HeaderText = "Tipo";
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.ReadOnly = true;
            // 
            // colNombreItem
            // 
            this.colNombreItem.HeaderText = "Nombre Item";
            this.colNombreItem.Name = "colNombreItem";
            this.colNombreItem.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panelBotones);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(100, 549);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(811, 100);
            this.panel11.TabIndex = 14;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.panelEliminar);
            this.panelBotones.Controls.Add(this.panelAgregar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(0, 0);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(811, 100);
            this.panelBotones.TabIndex = 15;
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.AnularBoton);
            this.panelEliminar.Controls.Add(this.panel20);
            this.panelEliminar.Controls.Add(this.panel21);
            this.panelEliminar.Controls.Add(this.panel22);
            this.panelEliminar.Controls.Add(this.panel23);
            this.panelEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEliminar.Location = new System.Drawing.Point(200, 0);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(200, 100);
            this.panelEliminar.TabIndex = 16;
            // 
            // AnularBoton
            // 
            this.AnularBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.AnularBoton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.AnularBoton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AnularBoton.BorderRadius = 30;
            this.AnularBoton.BorderSize = 0;
            this.AnularBoton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnularBoton.FlatAppearance.BorderSize = 0;
            this.AnularBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnularBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularBoton.ForeColor = System.Drawing.Color.White;
            this.AnularBoton.Location = new System.Drawing.Point(40, 20);
            this.AnularBoton.Name = "AnularBoton";
            this.AnularBoton.Size = new System.Drawing.Size(120, 60);
            this.AnularBoton.TabIndex = 18;
            this.AnularBoton.Text = "Anular";
            this.AnularBoton.TextColor = System.Drawing.Color.White;
            this.AnularBoton.UseVisualStyleBackColor = false;
            this.AnularBoton.Click += new System.EventHandler(this.AnularBoton_Click);
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(40, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(120, 20);
            this.panel20.TabIndex = 4;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel21.Location = new System.Drawing.Point(40, 80);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(120, 20);
            this.panel21.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel22.Location = new System.Drawing.Point(160, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(40, 100);
            this.panel22.TabIndex = 2;
            // 
            // panel23
            // 
            this.panel23.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(40, 100);
            this.panel23.TabIndex = 1;
            // 
            // panelAgregar
            // 
            this.panelAgregar.Controls.Add(this.btn_AgregarVenta);
            this.panelAgregar.Controls.Add(this.panel15);
            this.panelAgregar.Controls.Add(this.panel14);
            this.panelAgregar.Controls.Add(this.panel13);
            this.panelAgregar.Controls.Add(this.panel12);
            this.panelAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAgregar.Location = new System.Drawing.Point(0, 0);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(200, 100);
            this.panelAgregar.TabIndex = 14;
            // 
            // btn_AgregarVenta
            // 
            this.btn_AgregarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AgregarVenta.BorderRadius = 30;
            this.btn_AgregarVenta.BorderSize = 0;
            this.btn_AgregarVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AgregarVenta.FlatAppearance.BorderSize = 0;
            this.btn_AgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarVenta.Location = new System.Drawing.Point(40, 20);
            this.btn_AgregarVenta.Name = "btn_AgregarVenta";
            this.btn_AgregarVenta.Size = new System.Drawing.Size(120, 60);
            this.btn_AgregarVenta.TabIndex = 17;
            this.btn_AgregarVenta.Text = "Agregar";
            this.btn_AgregarVenta.TextColor = System.Drawing.Color.White;
            this.btn_AgregarVenta.UseVisualStyleBackColor = false;
            this.btn_AgregarVenta.Click += new System.EventHandler(this.btn_AgregarProveedor_Click);
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(40, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(120, 20);
            this.panel15.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(40, 80);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 20);
            this.panel14.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(160, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(40, 100);
            this.panel13.TabIndex = 2;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(40, 100);
            this.panel12.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(911, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 649);
            this.panel10.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 649);
            this.panel9.TabIndex = 12;
            // 
            // C_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1011, 887);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "C_Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.C_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetalleFactura)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.panelEliminar.ResumeLayout(false);
            this.panelAgregar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NroFactura;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.TextBox txt_Empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Ventas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private BotonRedondeado btn_ConsultarVentas;
        private BotonRedondeado btn_SalirVenta;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPuntos;
        private System.Windows.Forms.DataGridView dgv_DetalleFactura;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panelAgregar;
        private BotonRedondeado btn_AgregarVenta;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private BotonRedondeado AnularBoton;
        private System.Windows.Forms.CheckBox chk_Inactivos;
        private System.Windows.Forms.CheckBox chk_Activos;
    }
}