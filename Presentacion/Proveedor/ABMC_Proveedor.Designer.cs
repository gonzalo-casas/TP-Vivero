
namespace Vivero.Presentacion.Proveedor
{
    partial class ABMC_Proveedor
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
            this.btn_ConsultarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdProveedor = new System.Windows.Forms.TextBox();
            this.txt_RazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ConsultarProveedor
            // 
            this.btn_ConsultarProveedor.Location = new System.Drawing.Point(247, 193);
            this.btn_ConsultarProveedor.Name = "btn_ConsultarProveedor";
            this.btn_ConsultarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btn_ConsultarProveedor.TabIndex = 0;
            this.btn_ConsultarProveedor.Text = "Consultar";
            this.btn_ConsultarProveedor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razon Social:";
            // 
            // txt_IdProveedor
            // 
            this.txt_IdProveedor.Location = new System.Drawing.Point(150, 47);
            this.txt_IdProveedor.Name = "txt_IdProveedor";
            this.txt_IdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_IdProveedor.TabIndex = 4;
            // 
            // txt_RazonSocialProveedor
            // 
            this.txt_RazonSocialProveedor.Location = new System.Drawing.Point(151, 122);
            this.txt_RazonSocialProveedor.Name = "txt_RazonSocialProveedor";
            this.txt_RazonSocialProveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_RazonSocialProveedor.TabIndex = 5;
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.Location = new System.Drawing.Point(150, 81);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_NombreProveedor.TabIndex = 6;
            // 
            // ABMC_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_NombreProveedor);
            this.Controls.Add(this.txt_RazonSocialProveedor);
            this.Controls.Add(this.txt_IdProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConsultarProveedor);
            this.Name = "ABMC_Proveedor";
            this.Text = "ABMC_Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConsultarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdProveedor;
        private System.Windows.Forms.TextBox txt_RazonSocialProveedor;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
    }
}