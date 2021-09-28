
namespace Vivero.Presentacion.Catalogos
{
    partial class ABM_Catalogo
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
            this.txt_Numero_ID = new System.Windows.Forms.Label();
            this.txt_Puntos = new System.Windows.Forms.Label();
            this.gbPlantas = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new Vivero.Presentacion.BotonRedondeado();
            this.btnAgregar = new Vivero.Presentacion.BotonRedondeado();
            this.dgv_Componentes = new System.Windows.Forms.DataGridView();
            this.colPlantas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroId = new System.Windows.Forms.TextBox();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new Vivero.Presentacion.BotonRedondeado();
            this.btnCancelar = new Vivero.Presentacion.BotonRedondeado();
            this.gbPlantas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Componentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Numero_ID
            // 
            this.txt_Numero_ID.AutoSize = true;
            this.txt_Numero_ID.Location = new System.Drawing.Point(12, 17);
            this.txt_Numero_ID.Name = "txt_Numero_ID";
            this.txt_Numero_ID.Size = new System.Drawing.Size(64, 13);
            this.txt_Numero_ID.TabIndex = 14;
            this.txt_Numero_ID.Text = "Numero ID :";
            // 
            // txt_Puntos
            // 
            this.txt_Puntos.AutoSize = true;
            this.txt_Puntos.Location = new System.Drawing.Point(12, 62);
            this.txt_Puntos.Name = "txt_Puntos";
            this.txt_Puntos.Size = new System.Drawing.Size(46, 13);
            this.txt_Puntos.TabIndex = 15;
            this.txt_Puntos.Text = "Puntos :";
            this.txt_Puntos.Click += new System.EventHandler(this.txt_Puntos_Click);
            // 
            // gbPlantas
            // 
            this.gbPlantas.Controls.Add(this.btnEliminar);
            this.gbPlantas.Controls.Add(this.btnAgregar);
            this.gbPlantas.Controls.Add(this.dgv_Componentes);
            this.gbPlantas.Location = new System.Drawing.Point(15, 86);
            this.gbPlantas.Name = "gbPlantas";
            this.gbPlantas.Size = new System.Drawing.Size(574, 230);
            this.gbPlantas.TabIndex = 26;
            this.gbPlantas.TabStop = false;
            this.gbPlantas.Text = "Plantas/s";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(33, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 43);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(33, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 43);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgv_Componentes
            // 
            this.dgv_Componentes.AllowUserToAddRows = false;
            this.dgv_Componentes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            this.dgv_Componentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Componentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Componentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Componentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Componentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPlantas});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(122)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Componentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Componentes.Location = new System.Drawing.Point(209, 38);
            this.dgv_Componentes.Name = "dgv_Componentes";
            this.dgv_Componentes.RowHeadersWidth = 51;
            this.dgv_Componentes.RowTemplate.Height = 40;
            this.dgv_Componentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Componentes.Size = new System.Drawing.Size(312, 164);
            this.dgv_Componentes.TabIndex = 12;
            // 
            // colPlantas
            // 
            this.colPlantas.HeaderText = "Planta/s";
            this.colPlantas.Name = "colPlantas";
            // 
            // txtNumeroId
            // 
            this.txtNumeroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroId.Location = new System.Drawing.Point(92, 9);
            this.txtNumeroId.Name = "txtNumeroId";
            this.txtNumeroId.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroId.TabIndex = 28;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntos.Location = new System.Drawing.Point(92, 54);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 26);
            this.txtPuntos.TabIndex = 29;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(118, 349);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 43);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(389, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 43);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ABM_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 422);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.txtNumeroId);
            this.Controls.Add(this.gbPlantas);
            this.Controls.Add(this.txt_Puntos);
            this.Controls.Add(this.txt_Numero_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABM_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Catalogo";
            this.gbPlantas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Componentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_Numero_ID;
        private System.Windows.Forms.Label txt_Puntos;
        private System.Windows.Forms.GroupBox gbPlantas;
        private BotonRedondeado btnEliminar;
        private BotonRedondeado btnAgregar;
        private System.Windows.Forms.DataGridView dgv_Componentes;
        private System.Windows.Forms.TextBox txtNumeroId;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlantas;
        private BotonRedondeado btnAceptar;
        private BotonRedondeado btnCancelar;
    }
}