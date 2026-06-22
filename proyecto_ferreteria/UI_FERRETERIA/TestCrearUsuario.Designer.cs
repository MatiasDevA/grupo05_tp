namespace UI_FERRETERIA
{
    partial class TestCrearUsuario
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
            this.btnCrearAdministrador = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAdministrador
            // 
            this.btnCrearAdministrador.Location = new System.Drawing.Point(12, 12);
            this.btnCrearAdministrador.Name = "btnCrearAdministrador";
            this.btnCrearAdministrador.Size = new System.Drawing.Size(161, 55);
            this.btnCrearAdministrador.TabIndex = 0;
            this.btnCrearAdministrador.Text = "CrearAdministrador";
            this.btnCrearAdministrador.UseVisualStyleBackColor = true;
            this.btnCrearAdministrador.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(179, 12);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(161, 55);
            this.btnCrearVendedor.TabIndex = 1;
            this.btnCrearVendedor.Text = "CrearVendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // TestCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearAdministrador);
            this.Name = "TestCrearUsuario";
            this.Text = "TestCrearUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAdministrador;
        private System.Windows.Forms.Button btnCrearVendedor;
    }
}