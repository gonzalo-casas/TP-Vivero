
using System;

namespace Vivero.Presentacion.Catalogos
{
    partial class C_Catalogo
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
            this.Puntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NumeroID = new System.Windows.Forms.TextBox();
            this.txt_puntos = new System.Windows.Forms.TextBox();
            this.btn_AgregarCatalogo = new Vivero.Presentacion.BotonRedondeado();
            this.btn_SalirCatalogo = new Vivero.Presentacion.BotonRedondeado();
            this.btn_ConsultarCatalogo = new Vivero.Presentacion.BotonRedondeado();
            this.lblTituloCatalogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btn_EliminarCatalogo = new Vivero.Presentacion.BotonRedondeado();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btn_EditarCatalogo = new Vivero.Presentacion.BotonRedondeado();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dgv_Catalogos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Punt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogos)).BeginInit();
            this.SuspendLayout();
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Puntos.Location = new System.Drawing.Point(118, 66);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(63, 20);
            this.Puntos.TabIndex = 1;
            this.Puntos.Text = "Puntos:";
            this.Puntos.Click += new System.EventHandler(this.Puntos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero ID :";
            // 
            // txt_NumeroID
            // 
            this.txt_NumeroID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NumeroID.Location = new System.Drawing.Point(189, 23);
            this.txt_NumeroID.Name = "txt_NumeroID";
            this.txt_NumeroID.Size = new System.Drawing.Size(100, 26);
            this.txt_NumeroID.TabIndex = 4;
            // 
            // txt_puntos
            // 
            this.txt_puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_puntos.Location = new System.Drawing.Point(189, 60);
            this.txt_puntos.Name = "txt_puntos";
            this.txt_puntos.Size = new System.Drawing.Size(100, 26);
            this.txt_puntos.TabIndex = 5;
            // 
            // btn_AgregarCatalogo
            // 
            this.btn_AgregarCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarCatalogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AgregarCatalogo.BorderRadius = 30;
            this.btn_AgregarCatalogo.BorderSize = 0;
            this.btn_AgregarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AgregarCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarCatalogo.Location = new System.Drawing.Point(40, 20);
            this.btn_AgregarCatalogo.Name = "btn_AgregarCatalogo";
            this.btn_AgregarCatalogo.Size = new System.Drawing.Size(120, 60);
            this.btn_AgregarCatalogo.TabIndex = 5;
            this.btn_AgregarCatalogo.Text = "Agregar";
            this.btn_AgregarCatalogo.TextColor = System.Drawing.Color.White;
            this.btn_AgregarCatalogo.UseVisualStyleBackColor = false;
            this.btn_AgregarCatalogo.Click += new System.EventHandler(this.btn_AgregarCatalogo_Click);
            // 
            // btn_SalirCatalogo
            // 
            this.btn_SalirCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirCatalogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SalirCatalogo.BorderRadius = 20;
            this.btn_SalirCatalogo.BorderSize = 0;
            this.btn_SalirCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_SalirCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SalirCatalogo.ForeColor = System.Drawing.Color.White;
            this.btn_SalirCatalogo.Location = new System.Drawing.Point(49, 16);
            this.btn_SalirCatalogo.Name = "btn_SalirCatalogo";
            this.btn_SalirCatalogo.Size = new System.Drawing.Size(152, 40);
            this.btn_SalirCatalogo.TabIndex = 16;
            this.btn_SalirCatalogo.Text = "Cerrar";
            this.btn_SalirCatalogo.TextColor = System.Drawing.Color.White;
            this.btn_SalirCatalogo.UseVisualStyleBackColor = false;
            this.btn_SalirCatalogo.Click += new System.EventHandler(this.btn_SalirCatalogo_Click);
            // 
            // btn_ConsultarCatalogo
            // 
            this.btn_ConsultarCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarCatalogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ConsultarCatalogo.BorderRadius = 20;
            this.btn_ConsultarCatalogo.BorderSize = 0;
            this.btn_ConsultarCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultarCatalogo.Location = new System.Drawing.Point(366, 66);
            this.btn_ConsultarCatalogo.Name = "btn_ConsultarCatalogo";
            this.btn_ConsultarCatalogo.Size = new System.Drawing.Size(150, 40);
            this.btn_ConsultarCatalogo.TabIndex = 15;
            this.btn_ConsultarCatalogo.Text = "Consultar";
            this.btn_ConsultarCatalogo.TextColor = System.Drawing.Color.White;
            this.btn_ConsultarCatalogo.UseVisualStyleBackColor = false;
            this.btn_ConsultarCatalogo.Click += new System.EventHandler(this.btn_ConsultarCatalogo_Click);
            // 
            // lblTituloCatalogo
            // 
            this.lblTituloCatalogo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloCatalogo.AutoSize = true;
            this.lblTituloCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.lblTituloCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F);
            this.lblTituloCatalogo.Location = new System.Drawing.Point(571, 33);
            this.lblTituloCatalogo.Name = "lblTituloCatalogo";
            this.lblTituloCatalogo.Size = new System.Drawing.Size(296, 67);
            this.lblTituloCatalogo.TabIndex = 16;
            this.lblTituloCatalogo.Text = "Catalogos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 50);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 50);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chk_Inactivos);
            this.panel3.Controls.Add(this.chk_Activos);
            this.panel3.Controls.Add(this.lblTituloCatalogo);
            this.panel3.Controls.Add(this.btn_ConsultarCatalogo);
            this.panel3.Controls.Add(this.txt_NumeroID);
            this.panel3.Controls.Add(this.Puntos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_puntos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(963, 175);
            this.panel3.TabIndex = 16;
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Inactivos.Location = new System.Drawing.Point(443, 3);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(91, 24);
            this.chk_Inactivos.TabIndex = 13;
            this.chk_Inactivos.Text = "Inactivos";
            this.chk_Inactivos.UseVisualStyleBackColor = true;
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.Checked = true;
            this.chk_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Activos.Location = new System.Drawing.Point(350, 3);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(79, 24);
            this.chk_Activos.TabIndex = 12;
            this.chk_Activos.Text = "Activos";
            this.chk_Activos.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 342);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 564);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(963, 73);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_SalirCatalogo);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(716, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 73);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(49, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 17);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(49, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(152, 16);
            this.panel8.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(201, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(46, 73);
            this.panel9.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(49, 73);
            this.panel10.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 225);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(100, 339);
            this.panel11.TabIndex = 17;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel23);
            this.panel12.Controls.Add(this.panel18);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(100, 464);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(863, 100);
            this.panel12.TabIndex = 18;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.btn_EliminarCatalogo);
            this.panel23.Controls.Add(this.panel27);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Controls.Add(this.panel25);
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Location = new System.Drawing.Point(397, 0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(200, 100);
            this.panel23.TabIndex = 2;
            // 
            // btn_EliminarCatalogo
            // 
            this.btn_EliminarCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EliminarCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EliminarCatalogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_EliminarCatalogo.BorderRadius = 30;
            this.btn_EliminarCatalogo.BorderSize = 0;
            this.btn_EliminarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EliminarCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EliminarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarCatalogo.Location = new System.Drawing.Point(40, 20);
            this.btn_EliminarCatalogo.Name = "btn_EliminarCatalogo";
            this.btn_EliminarCatalogo.Size = new System.Drawing.Size(120, 60);
            this.btn_EliminarCatalogo.TabIndex = 19;
            this.btn_EliminarCatalogo.Text = "Eliminar";
            this.btn_EliminarCatalogo.TextColor = System.Drawing.Color.White;
            this.btn_EliminarCatalogo.UseVisualStyleBackColor = false;
            this.btn_EliminarCatalogo.Click += new System.EventHandler(this.btn_EliminarCatalogo_Click);
            // 
            // panel27
            // 
            this.panel27.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel27.Location = new System.Drawing.Point(40, 80);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(120, 20);
            this.panel27.TabIndex = 3;
            // 
            // panel26
            // 
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(40, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(120, 20);
            this.panel26.TabIndex = 2;
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel25.Location = new System.Drawing.Point(160, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(40, 100);
            this.panel25.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(40, 100);
            this.panel24.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_EditarCatalogo);
            this.panel18.Controls.Add(this.panel22);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel20);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Location = new System.Drawing.Point(198, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(200, 100);
            this.panel18.TabIndex = 1;
            // 
            // btn_EditarCatalogo
            // 
            this.btn_EditarCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EditarCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EditarCatalogo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_EditarCatalogo.BorderRadius = 30;
            this.btn_EditarCatalogo.BorderSize = 0;
            this.btn_EditarCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EditarCatalogo.FlatAppearance.BorderSize = 0;
            this.btn_EditarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarCatalogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EditarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btn_EditarCatalogo.Location = new System.Drawing.Point(40, 20);
            this.btn_EditarCatalogo.Name = "btn_EditarCatalogo";
            this.btn_EditarCatalogo.Size = new System.Drawing.Size(120, 60);
            this.btn_EditarCatalogo.TabIndex = 19;
            this.btn_EditarCatalogo.Text = "Editar";
            this.btn_EditarCatalogo.TextColor = System.Drawing.Color.White;
            this.btn_EditarCatalogo.UseVisualStyleBackColor = false;
            this.btn_EditarCatalogo.Click += new System.EventHandler(this.btn_EditarCatalogo_Click);
            // 
            // panel22
            // 
            this.panel22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel22.Location = new System.Drawing.Point(40, 80);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(120, 20);
            this.panel22.TabIndex = 3;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(40, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(120, 20);
            this.panel21.TabIndex = 2;
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel20.Location = new System.Drawing.Point(160, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(40, 100);
            this.panel20.TabIndex = 1;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(40, 100);
            this.panel19.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_AgregarCatalogo);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Location = new System.Drawing.Point(-1, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 100);
            this.panel13.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(40, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(120, 20);
            this.panel15.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(40, 80);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 20);
            this.panel14.TabIndex = 6;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(160, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(40, 100);
            this.panel17.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(40, 100);
            this.panel16.TabIndex = 8;
            // 
            // panel28
            // 
            this.panel28.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel28.Location = new System.Drawing.Point(863, 225);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(100, 239);
            this.panel28.TabIndex = 19;
            // 
            // dgv_Catalogos
            // 
            this.dgv_Catalogos.AllowUserToAddRows = false;
            this.dgv_Catalogos.AllowUserToDeleteRows = false;
            this.dgv_Catalogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Catalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Catalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_Planta,
            this.Punt});
            this.dgv_Catalogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Catalogos.Location = new System.Drawing.Point(100, 225);
            this.dgv_Catalogos.Name = "dgv_Catalogos";
            this.dgv_Catalogos.ReadOnly = true;
            this.dgv_Catalogos.RowHeadersVisible = false;
            this.dgv_Catalogos.RowHeadersWidth = 51;
            this.dgv_Catalogos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Catalogos.Size = new System.Drawing.Size(763, 239);
            this.dgv_Catalogos.TabIndex = 11;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_Planta
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Planta.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID_Planta.HeaderText = "ID_Planta";
            this.ID_Planta.Name = "ID_Planta";
            this.ID_Planta.ReadOnly = true;
            // 
            // Punt
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punt.DefaultCellStyle = dataGridViewCellStyle3;
            this.Punt.HeaderText = "puntos";
            this.Punt.Name = "Punt";
            this.Punt.ReadOnly = true;
            // 
            // C_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(963, 637);
            this.Controls.Add(this.dgv_Catalogos);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "C_Catalogo";
            this.Text = "Catalogos";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catalogos)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NumeroID;
        private System.Windows.Forms.TextBox txt_puntos;
        private BotonRedondeado btn_AgregarCatalogo;
        private BotonRedondeado btn_SalirCatalogo;
        private BotonRedondeado btn_ConsultarCatalogo;
        private System.Windows.Forms.Label lblTituloCatalogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel23;
        private BotonRedondeado btn_EliminarCatalogo;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel24;
        private BotonRedondeado btn_EditarCatalogo;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView dgv_Catalogos;
        private System.Windows.Forms.CheckBox chk_Activos;
        private System.Windows.Forms.CheckBox chk_Inactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Punt;
    }
}