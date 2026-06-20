namespace UI_FERRETERIA
{
    partial class Login
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEncargado = new System.Windows.Forms.Button();
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(655, 475);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(104, 25);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Location = new System.Drawing.Point(655, 438);
            this.btnGerente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(104, 30);
            this.btnGerente.TabIndex = 1;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(191, 294);
            this.btnVendedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(104, 31);
            this.btnVendedor.TabIndex = 2;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(655, 513);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(104, 26);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEncargado
            // 
            this.btnEncargado.Location = new System.Drawing.Point(13, 508);
            this.btnEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncargado.Name = "btnEncargado";
            this.btnEncargado.Size = new System.Drawing.Size(104, 31);
            this.btnEncargado.TabIndex = 4;
            this.btnEncargado.Text = "Encargado";
            this.btnEncargado.UseVisualStyleBackColor = true;
            this.btnEncargado.Click += new System.EventHandler(this.btnEncargado_Click);
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.White;
            this.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogin.Controls.Add(this.btnVendedor);
            this.PnlLogin.Location = new System.Drawing.Point(168, 59);
            this.PnlLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(466, 377);
            this.PnlLogin.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(797, 554);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnEncargado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEncargado;
        private System.Windows.Forms.Panel PnlLogin;
    }
}

