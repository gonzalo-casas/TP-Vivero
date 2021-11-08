
namespace Vivero.Presentacion.Plantas
{
    partial class ABM_Planta
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
            this.txt_NCientPlanta = new System.Windows.Forms.TextBox();
            this.txt_NomComPlanta = new System.Windows.Forms.TextBox();
            this.txt_StockPlanta = new System.Windows.Forms.TextBox();
            this.txt_PrecioPlanta = new System.Windows.Forms.TextBox();
            this.cmb_TipoPlanta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new Vivero.Presentacion.BotonRedondeado();
            this.btn_RegistrarPlanta = new Vivero.Presentacion.BotonRedondeado();
            this.SuspendLayout();
            // 
            // txt_NCientPlanta
            // 
            this.txt_NCientPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NCientPlanta.Location = new System.Drawing.Point(221, 59);
            this.txt_NCientPlanta.Name = "txt_NCientPlanta";
            this.txt_NCientPlanta.Size = new System.Drawing.Size(125, 26);
            this.txt_NCientPlanta.TabIndex = 3;
            // 
            // txt_NomComPlanta
            // 
            this.txt_NomComPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomComPlanta.Location = new System.Drawing.Point(221, 97);
            this.txt_NomComPlanta.Name = "txt_NomComPlanta";
            this.txt_NomComPlanta.Size = new System.Drawing.Size(125, 26);
            this.txt_NomComPlanta.TabIndex = 4;
            // 
            // txt_StockPlanta
            // 
            this.txt_StockPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockPlanta.Location = new System.Drawing.Point(221, 211);
            this.txt_StockPlanta.Name = "txt_StockPlanta";
            this.txt_StockPlanta.Size = new System.Drawing.Size(125, 26);
            this.txt_StockPlanta.TabIndex = 5;
            this.txt_StockPlanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StockPlanta_KeyPress);
            // 
            // txt_PrecioPlanta
            // 
            this.txt_PrecioPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioPlanta.Location = new System.Drawing.Point(221, 173);
            this.txt_PrecioPlanta.Name = "txt_PrecioPlanta";
            this.txt_PrecioPlanta.Size = new System.Drawing.Size(125, 26);
            this.txt_PrecioPlanta.TabIndex = 6;
            this.txt_PrecioPlanta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PrecioPlanta_KeyPress);
            // 
            // cmb_TipoPlanta
            // 
            this.cmb_TipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TipoPlanta.FormattingEnabled = true;
            this.cmb_TipoPlanta.Location = new System.Drawing.Point(221, 135);
            this.cmb_TipoPlanta.Name = "cmb_TipoPlanta";
            this.cmb_TipoPlanta.Size = new System.Drawing.Size(125, 28);
            this.cmb_TipoPlanta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Cientifíco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre Común:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_Cancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Cancelar.BorderRadius = 25;
            this.btn_Cancelar.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(281, 381);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 51);
            this.btn_Cancelar.TabIndex = 24;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextColor = System.Drawing.Color.White;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_RegistrarPlanta
            // 
            this.btn_RegistrarPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_RegistrarPlanta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(94)))), ((int)(((byte)(75)))));
            this.btn_RegistrarPlanta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_RegistrarPlanta.BorderRadius = 25;
            this.btn_RegistrarPlanta.BorderSize = 0;
            this.btn_RegistrarPlanta.FlatAppearance.BorderSize = 0;
            this.btn_RegistrarPlanta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarPlanta.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarPlanta.Location = new System.Drawing.Point(83, 381);
            this.btn_RegistrarPlanta.Name = "btn_RegistrarPlanta";
            this.btn_RegistrarPlanta.Size = new System.Drawing.Size(99, 51);
            this.btn_RegistrarPlanta.TabIndex = 23;
            this.btn_RegistrarPlanta.Text = "Aceptar";
            this.btn_RegistrarPlanta.TextColor = System.Drawing.Color.White;
            this.btn_RegistrarPlanta.UseVisualStyleBackColor = false;
            this.btn_RegistrarPlanta.Click += new System.EventHandler(this.btn_RegistrarPlanta_Click);
            // 
            // ABM_Planta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(181)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(479, 470);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_RegistrarPlanta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TipoPlanta);
            this.Controls.Add(this.txt_PrecioPlanta);
            this.Controls.Add(this.txt_StockPlanta);
            this.Controls.Add(this.txt_NomComPlanta);
            this.Controls.Add(this.txt_NCientPlanta);
            this.Name = "ABM_Planta";
            this.Text = "ABM_Planta";
            this.Load += new System.EventHandler(this.ABM_Planta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_NCientPlanta;
        private System.Windows.Forms.TextBox txt_NomComPlanta;
        private System.Windows.Forms.TextBox txt_StockPlanta;
        private System.Windows.Forms.TextBox txt_PrecioPlanta;
        private System.Windows.Forms.ComboBox cmb_TipoPlanta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BotonRedondeado btn_Cancelar;
        private BotonRedondeado btn_RegistrarPlanta;
    }
}