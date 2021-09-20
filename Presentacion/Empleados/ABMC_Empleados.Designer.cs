
namespace Vivero.Presentacion.Empleados
{
    partial class ABMC_Empleados
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
            this.btn_AgregarEmpleado = new System.Windows.Forms.Button();
            this.btn_EditarEmpleado = new System.Windows.Forms.Button();
            this.btn_EliminarEmpleado = new System.Windows.Forms.Button();
            this.btn_SalirEmpleado = new System.Windows.Forms.Button();
            this.txt_IdEmpleado = new System.Windows.Forms.TextBox();
            this.txt_NombreEmpleado = new System.Windows.Forms.TextBox();
            this.txt_ApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.btn_ConsultarEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Empleados = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(223, 273);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarEmpleado.TabIndex = 0;
            this.btn_AgregarEmpleado.Text = "Agregar";
            this.btn_AgregarEmpleado.UseVisualStyleBackColor = true;
            this.btn_AgregarEmpleado.Click += new System.EventHandler(this.btn_AgregarEmpleado_Click);
            // 
            // btn_EditarEmpleado
            // 
            this.btn_EditarEmpleado.Location = new System.Drawing.Point(513, 273);
            this.btn_EditarEmpleado.Name = "btn_EditarEmpleado";
            this.btn_EditarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_EditarEmpleado.TabIndex = 1;
            this.btn_EditarEmpleado.Text = "Editar";
            this.btn_EditarEmpleado.UseVisualStyleBackColor = true;
            this.btn_EditarEmpleado.Click += new System.EventHandler(this.btn_EditarEmpleado_Click);
            // 
            // btn_EliminarEmpleado
            // 
            this.btn_EliminarEmpleado.Location = new System.Drawing.Point(793, 273);
            this.btn_EliminarEmpleado.Name = "btn_EliminarEmpleado";
            this.btn_EliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarEmpleado.TabIndex = 2;
            this.btn_EliminarEmpleado.Text = "Eliminar";
            this.btn_EliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btn_SalirEmpleado
            // 
            this.btn_SalirEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SalirEmpleado.Location = new System.Drawing.Point(49, 16);
            this.btn_SalirEmpleado.Name = "btn_SalirEmpleado";
            this.btn_SalirEmpleado.Size = new System.Drawing.Size(153, 40);
            this.btn_SalirEmpleado.TabIndex = 3;
            this.btn_SalirEmpleado.Text = "Cerrar";
            this.btn_SalirEmpleado.UseVisualStyleBackColor = true;
            this.btn_SalirEmpleado.Click += new System.EventHandler(this.btn_SalirEmpleado_Click);
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Location = new System.Drawing.Point(119, 20);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_IdEmpleado.TabIndex = 4;
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(119, 53);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreEmpleado.TabIndex = 5;
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(119, 83);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoEmpleado.TabIndex = 6;
            // 
            // btn_ConsultarEmpleado
            // 
            this.btn_ConsultarEmpleado.Location = new System.Drawing.Point(144, 120);
            this.btn_ConsultarEmpleado.Name = "btn_ConsultarEmpleado";
            this.btn_ConsultarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarEmpleado.TabIndex = 7;
            this.btn_ConsultarEmpleado.Text = "Consultar";
            this.btn_ConsultarEmpleado.UseVisualStyleBackColor = true;
            this.btn_ConsultarEmpleado.Click += new System.EventHandler(this.btn_ConsultarEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido:";
            // 
            // dgv_Empleados
            // 
            this.dgv_Empleados.AllowUserToAddRows = false;
            this.dgv_Empleados.AllowUserToDeleteRows = false;
            this.dgv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colApellido,
            this.colTelefono,
            this.colCalle,
            this.colNumCalle});
            this.dgv_Empleados.Location = new System.Drawing.Point(223, 22);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.Size = new System.Drawing.Size(645, 192);
            this.dgv_Empleados.TabIndex = 11;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colCalle
            // 
            this.colCalle.HeaderText = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.ReadOnly = true;
            // 
            // colNumCalle
            // 
            this.colNumCalle.HeaderText = "NumeroCalle";
            this.colNumCalle.Name = "colNumCalle";
            this.colNumCalle.ReadOnly = true;
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.Location = new System.Drawing.Point(276, 53);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(61, 17);
            this.chk_Activos.TabIndex = 12;
            this.chk_Activos.Text = "Activos";
            this.chk_Activos.UseVisualStyleBackColor = true;
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.Location = new System.Drawing.Point(276, 85);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(69, 17);
            this.chk_Inactivos.TabIndex = 13;
            this.chk_Inactivos.Text = "Inactivos";
            this.chk_Inactivos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 73);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_IdEmpleado);
            this.panel3.Controls.Add(this.txt_NombreEmpleado);
            this.panel3.Controls.Add(this.chk_Inactivos);
            this.panel3.Controls.Add(this.txt_ApellidoEmpleado);
            this.panel3.Controls.Add(this.chk_Activos);
            this.panel3.Controls.Add(this.btn_ConsultarEmpleado);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 176);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AgregarEmpleado);
            this.panel2.Controls.Add(this.btn_EditarEmpleado);
            this.panel2.Controls.Add(this.btn_EliminarEmpleado);
            this.panel2.Controls.Add(this.dgv_Empleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 388);
            this.panel2.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_SalirEmpleado);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(760, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 73);
            this.panel4.TabIndex = 4;
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
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(49, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 16);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(49, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(153, 17);
            this.panel7.TabIndex = 10;
            // 
            // ABMC_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1007, 637);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABMC_Empleados";
            this.ShowInTaskbar = false;
            this.Text = "ABMC_Empleados";
            this.Load += new System.EventHandler(this.ABMC_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarEmpleado;
        private System.Windows.Forms.Button btn_EditarEmpleado;
        private System.Windows.Forms.Button btn_EliminarEmpleado;
        private System.Windows.Forms.Button btn_SalirEmpleado;
        private System.Windows.Forms.TextBox txt_IdEmpleado;
        private System.Windows.Forms.TextBox txt_NombreEmpleado;
        private System.Windows.Forms.TextBox txt_ApellidoEmpleado;
        private System.Windows.Forms.Button btn_ConsultarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Empleados;
        private System.Windows.Forms.CheckBox chk_Activos;
        private System.Windows.Forms.CheckBox chk_Inactivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCalle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}