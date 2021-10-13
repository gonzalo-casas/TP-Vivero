
namespace Vivero.Presentacion.Plantas
{
    partial class C_Planta
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
            this.dvg_Plantas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_IdPlanta = new System.Windows.Forms.TextBox();
            this.txt_NombrePlanta = new System.Windows.Forms.TextBox();
            this.lbl_IdPlanta = new System.Windows.Forms.Label();
            this.lbl_NombrePlanta = new System.Windows.Forms.Label();
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.lblTituloPlantas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_SalirPlanta = new Vivero.Presentacion.BotonRedondeado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_AgregarPlanta = new Vivero.Presentacion.BotonRedondeado();
            this.btn_EditarPlanta = new Vivero.Presentacion.BotonRedondeado();
            this.btn_EliminarPlanta = new Vivero.Presentacion.BotonRedondeado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_ConsultarPlanta = new Vivero.Presentacion.BotonRedondeado();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Plantas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg_Plantas
            // 
            this.dvg_Plantas.AllowUserToAddRows = false;
            this.dvg_Plantas.AllowUserToDeleteRows = false;
            this.dvg_Plantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvg_Plantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Plantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dvg_Plantas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvg_Plantas.Location = new System.Drawing.Point(214, 0);
            this.dvg_Plantas.Name = "dvg_Plantas";
            this.dvg_Plantas.ReadOnly = true;
            this.dvg_Plantas.RowHeadersVisible = false;
            this.dvg_Plantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_Plantas.Size = new System.Drawing.Size(853, 448);
            this.dvg_Plantas.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Científico";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Común";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txt_IdPlanta
            // 
            this.txt_IdPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_IdPlanta.Location = new System.Drawing.Point(88, 24);
            this.txt_IdPlanta.Name = "txt_IdPlanta";
            this.txt_IdPlanta.Size = new System.Drawing.Size(100, 26);
            this.txt_IdPlanta.TabIndex = 22;
            // 
            // txt_NombrePlanta
            // 
            this.txt_NombrePlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_NombrePlanta.Location = new System.Drawing.Point(88, 67);
            this.txt_NombrePlanta.Name = "txt_NombrePlanta";
            this.txt_NombrePlanta.Size = new System.Drawing.Size(100, 26);
            this.txt_NombrePlanta.TabIndex = 23;
            // 
            // lbl_IdPlanta
            // 
            this.lbl_IdPlanta.AutoSize = true;
            this.lbl_IdPlanta.Location = new System.Drawing.Point(10, 32);
            this.lbl_IdPlanta.Name = "lbl_IdPlanta";
            this.lbl_IdPlanta.Size = new System.Drawing.Size(61, 13);
            this.lbl_IdPlanta.TabIndex = 24;
            this.lbl_IdPlanta.Text = "Numero ID:";
            // 
            // lbl_NombrePlanta
            // 
            this.lbl_NombrePlanta.AutoSize = true;
            this.lbl_NombrePlanta.Location = new System.Drawing.Point(10, 75);
            this.lbl_NombrePlanta.Name = "lbl_NombrePlanta";
            this.lbl_NombrePlanta.Size = new System.Drawing.Size(47, 13);
            this.lbl_NombrePlanta.TabIndex = 25;
            this.lbl_NombrePlanta.Text = "Nombre:";
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.Checked = true;
            this.chk_Activos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Activos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Activos.Location = new System.Drawing.Point(203, 132);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(79, 24);
            this.chk_Activos.TabIndex = 26;
            this.chk_Activos.Text = "Activos";
            this.chk_Activos.UseVisualStyleBackColor = true;
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Inactivos.Location = new System.Drawing.Point(299, 132);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(91, 24);
            this.chk_Inactivos.TabIndex = 27;
            this.chk_Inactivos.Text = "Inactivos";
            this.chk_Inactivos.UseVisualStyleBackColor = true;
            // 
            // lblTituloPlantas
            // 
            this.lblTituloPlantas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTituloPlantas.AutoSize = true;
            this.lblTituloPlantas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.lblTituloPlantas.Font = new System.Drawing.Font("Berlin Sans FB", 44.25F);
            this.lblTituloPlantas.Location = new System.Drawing.Point(989, 56);
            this.lblTituloPlantas.Name = "lblTituloPlantas";
            this.lblTituloPlantas.Size = new System.Drawing.Size(212, 65);
            this.lblTituloPlantas.TabIndex = 16;
            this.lblTituloPlantas.Text = "Plantas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 719);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 121);
            this.panel1.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_SalirPlanta);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1122, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(162, 121);
            this.panel7.TabIndex = 21;
            // 
            // btn_SalirPlanta
            // 
            this.btn_SalirPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_SalirPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SalirPlanta.BorderRadius = 20;
            this.btn_SalirPlanta.BorderSize = 0;
            this.btn_SalirPlanta.FlatAppearance.BorderSize = 0;
            this.btn_SalirPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SalirPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_SalirPlanta.Location = new System.Drawing.Point(21, 37);
            this.btn_SalirPlanta.Name = "btn_SalirPlanta";
            this.btn_SalirPlanta.Size = new System.Drawing.Size(129, 52);
            this.btn_SalirPlanta.TabIndex = 20;
            this.btn_SalirPlanta.Text = "Cerrar";
            this.btn_SalirPlanta.TextColor = System.Drawing.Color.White;
            this.btn_SalirPlanta.UseVisualStyleBackColor = false;
            this.btn_SalirPlanta.Click += new System.EventHandler(this.btn_SalirPlanta_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dvg_Plantas);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 542);
            this.panel2.TabIndex = 29;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_AgregarPlanta);
            this.panel6.Controls.Add(this.btn_EditarPlanta);
            this.panel6.Controls.Add(this.btn_EliminarPlanta);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(214, 448);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(853, 94);
            this.panel6.TabIndex = 24;
            // 
            // btn_AgregarPlanta
            // 
            this.btn_AgregarPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_AgregarPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AgregarPlanta.BorderRadius = 20;
            this.btn_AgregarPlanta.BorderSize = 0;
            this.btn_AgregarPlanta.FlatAppearance.BorderSize = 0;
            this.btn_AgregarPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarPlanta.Location = new System.Drawing.Point(6, 21);
            this.btn_AgregarPlanta.Name = "btn_AgregarPlanta";
            this.btn_AgregarPlanta.Size = new System.Drawing.Size(122, 52);
            this.btn_AgregarPlanta.TabIndex = 17;
            this.btn_AgregarPlanta.Text = "Agregar";
            this.btn_AgregarPlanta.TextColor = System.Drawing.Color.White;
            this.btn_AgregarPlanta.UseVisualStyleBackColor = false;
            this.btn_AgregarPlanta.Click += new System.EventHandler(this.btn_AgregarPlanta_Click);
            // 
            // btn_EditarPlanta
            // 
            this.btn_EditarPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EditarPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EditarPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_EditarPlanta.BorderRadius = 20;
            this.btn_EditarPlanta.BorderSize = 0;
            this.btn_EditarPlanta.FlatAppearance.BorderSize = 0;
            this.btn_EditarPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EditarPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_EditarPlanta.Location = new System.Drawing.Point(257, 21);
            this.btn_EditarPlanta.Name = "btn_EditarPlanta";
            this.btn_EditarPlanta.Size = new System.Drawing.Size(133, 52);
            this.btn_EditarPlanta.TabIndex = 18;
            this.btn_EditarPlanta.Text = "Editar";
            this.btn_EditarPlanta.TextColor = System.Drawing.Color.White;
            this.btn_EditarPlanta.UseVisualStyleBackColor = false;
            this.btn_EditarPlanta.Click += new System.EventHandler(this.btn_EditarPlanta_Click);
            // 
            // btn_EliminarPlanta
            // 
            this.btn_EliminarPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EliminarPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_EliminarPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_EliminarPlanta.BorderRadius = 20;
            this.btn_EliminarPlanta.BorderSize = 0;
            this.btn_EliminarPlanta.FlatAppearance.BorderSize = 0;
            this.btn_EliminarPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EliminarPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarPlanta.Location = new System.Drawing.Point(536, 21);
            this.btn_EliminarPlanta.Name = "btn_EliminarPlanta";
            this.btn_EliminarPlanta.Size = new System.Drawing.Size(135, 52);
            this.btn_EliminarPlanta.TabIndex = 19;
            this.btn_EliminarPlanta.Text = "Eliminar";
            this.btn_EliminarPlanta.TextColor = System.Drawing.Color.White;
            this.btn_EliminarPlanta.UseVisualStyleBackColor = false;
            this.btn_EliminarPlanta.Click += new System.EventHandler(this.btn_EliminarPlanta_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 542);
            this.panel5.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1067, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 542);
            this.panel4.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.lblTituloPlantas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1284, 177);
            this.panel3.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_ConsultarPlanta);
            this.panel8.Controls.Add(this.lbl_IdPlanta);
            this.panel8.Controls.Add(this.txt_IdPlanta);
            this.panel8.Controls.Add(this.chk_Activos);
            this.panel8.Controls.Add(this.chk_Inactivos);
            this.panel8.Controls.Add(this.txt_NombrePlanta);
            this.panel8.Controls.Add(this.lbl_NombrePlanta);
            this.panel8.Location = new System.Drawing.Point(214, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(404, 174);
            this.panel8.TabIndex = 28;
            // 
            // btn_ConsultarPlanta
            // 
            this.btn_ConsultarPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_ConsultarPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ConsultarPlanta.BorderRadius = 20;
            this.btn_ConsultarPlanta.BorderSize = 0;
            this.btn_ConsultarPlanta.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ConsultarPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultarPlanta.Location = new System.Drawing.Point(13, 119);
            this.btn_ConsultarPlanta.Name = "btn_ConsultarPlanta";
            this.btn_ConsultarPlanta.Size = new System.Drawing.Size(115, 49);
            this.btn_ConsultarPlanta.TabIndex = 16;
            this.btn_ConsultarPlanta.Text = "Consultar";
            this.btn_ConsultarPlanta.TextColor = System.Drawing.Color.White;
            this.btn_ConsultarPlanta.UseVisualStyleBackColor = false;
            this.btn_ConsultarPlanta.Click += new System.EventHandler(this.btn_ConsultarPlanta_Click);
            // 
            // C_Planta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(241)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1284, 840);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "C_Planta";
            this.Text = "C_Planta";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Plantas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotonRedondeado btn_ConsultarPlanta;
        private BotonRedondeado btn_AgregarPlanta;
        private BotonRedondeado btn_EditarPlanta;
        private BotonRedondeado btn_EliminarPlanta;
        private BotonRedondeado btn_SalirPlanta;
        private System.Windows.Forms.DataGridView dvg_Plantas;
        private System.Windows.Forms.TextBox txt_IdPlanta;
        private System.Windows.Forms.TextBox txt_NombrePlanta;
        private System.Windows.Forms.Label lbl_IdPlanta;
        private System.Windows.Forms.Label lbl_NombrePlanta;
        private System.Windows.Forms.CheckBox chk_Activos;
        private System.Windows.Forms.CheckBox chk_Inactivos;
        private System.Windows.Forms.Label lblTituloPlantas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}