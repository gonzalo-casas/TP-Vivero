
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
            this.chk_Activos = new System.Windows.Forms.CheckBox();
            this.chk_Inactivos = new System.Windows.Forms.CheckBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarEmpleado
            // 
            this.btn_AgregarEmpleado.Location = new System.Drawing.Point(26, 401);
            this.btn_AgregarEmpleado.Name = "btn_AgregarEmpleado";
            this.btn_AgregarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarEmpleado.TabIndex = 0;
            this.btn_AgregarEmpleado.Text = "Agregar";
            this.btn_AgregarEmpleado.UseVisualStyleBackColor = true;
            this.btn_AgregarEmpleado.Click += new System.EventHandler(this.btn_AgregarEmpleado_Click);
            // 
            // btn_EditarEmpleado
            // 
            this.btn_EditarEmpleado.Location = new System.Drawing.Point(123, 401);
            this.btn_EditarEmpleado.Name = "btn_EditarEmpleado";
            this.btn_EditarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_EditarEmpleado.TabIndex = 1;
            this.btn_EditarEmpleado.Text = "Editar";
            this.btn_EditarEmpleado.UseVisualStyleBackColor = true;
            this.btn_EditarEmpleado.Click += new System.EventHandler(this.btn_EditarEmpleado_Click);
            // 
            // btn_EliminarEmpleado
            // 
            this.btn_EliminarEmpleado.Location = new System.Drawing.Point(227, 401);
            this.btn_EliminarEmpleado.Name = "btn_EliminarEmpleado";
            this.btn_EliminarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_EliminarEmpleado.TabIndex = 2;
            this.btn_EliminarEmpleado.Text = "Eliminar";
            this.btn_EliminarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btn_SalirEmpleado
            // 
            this.btn_SalirEmpleado.Location = new System.Drawing.Point(677, 401);
            this.btn_SalirEmpleado.Name = "btn_SalirEmpleado";
            this.btn_SalirEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btn_SalirEmpleado.TabIndex = 3;
            this.btn_SalirEmpleado.Text = "Salir";
            this.btn_SalirEmpleado.UseVisualStyleBackColor = true;
            this.btn_SalirEmpleado.Click += new System.EventHandler(this.btn_SalirEmpleado_Click);
            // 
            // txt_IdEmpleado
            // 
            this.txt_IdEmpleado.Location = new System.Drawing.Point(107, 27);
            this.txt_IdEmpleado.Name = "txt_IdEmpleado";
            this.txt_IdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_IdEmpleado.TabIndex = 4;
            // 
            // txt_NombreEmpleado
            // 
            this.txt_NombreEmpleado.Location = new System.Drawing.Point(107, 60);
            this.txt_NombreEmpleado.Name = "txt_NombreEmpleado";
            this.txt_NombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreEmpleado.TabIndex = 5;
            // 
            // txt_ApellidoEmpleado
            // 
            this.txt_ApellidoEmpleado.Location = new System.Drawing.Point(107, 90);
            this.txt_ApellidoEmpleado.Name = "txt_ApellidoEmpleado";
            this.txt_ApellidoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txt_ApellidoEmpleado.TabIndex = 6;
            // 
            // btn_ConsultarEmpleado
            // 
            this.btn_ConsultarEmpleado.Location = new System.Drawing.Point(132, 125);
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
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Numero ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 97);
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
            this.dgv_Empleados.Location = new System.Drawing.Point(12, 169);
            this.dgv_Empleados.Name = "dgv_Empleados";
            this.dgv_Empleados.ReadOnly = true;
            this.dgv_Empleados.Size = new System.Drawing.Size(645, 192);
            this.dgv_Empleados.TabIndex = 11;
            // 
            // chk_Activos
            // 
            this.chk_Activos.AutoSize = true;
            this.chk_Activos.Location = new System.Drawing.Point(254, 117);
            this.chk_Activos.Name = "chk_Activos";
            this.chk_Activos.Size = new System.Drawing.Size(61, 17);
            this.chk_Activos.TabIndex = 12;
            this.chk_Activos.Text = "Activos";
            this.chk_Activos.UseVisualStyleBackColor = true;
            // 
            // chk_Inactivos
            // 
            this.chk_Inactivos.AutoSize = true;
            this.chk_Inactivos.Location = new System.Drawing.Point(254, 146);
            this.chk_Inactivos.Name = "chk_Inactivos";
            this.chk_Inactivos.Size = new System.Drawing.Size(69, 17);
            this.chk_Inactivos.TabIndex = 13;
            this.chk_Inactivos.Text = "Inactivos";
            this.chk_Inactivos.UseVisualStyleBackColor = true;
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
            // ABMC_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_Inactivos);
            this.Controls.Add(this.chk_Activos);
            this.Controls.Add(this.dgv_Empleados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConsultarEmpleado);
            this.Controls.Add(this.txt_ApellidoEmpleado);
            this.Controls.Add(this.txt_NombreEmpleado);
            this.Controls.Add(this.txt_IdEmpleado);
            this.Controls.Add(this.btn_SalirEmpleado);
            this.Controls.Add(this.btn_EliminarEmpleado);
            this.Controls.Add(this.btn_EditarEmpleado);
            this.Controls.Add(this.btn_AgregarEmpleado);
            this.Name = "ABMC_Empleados";
            this.Text = "ABMC_Empleados";
            this.Load += new System.EventHandler(this.ABMC_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}