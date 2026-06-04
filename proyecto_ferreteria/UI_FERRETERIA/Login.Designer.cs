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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(491, 386);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(78, 20);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Location = new System.Drawing.Point(491, 356);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(78, 24);
            this.btnGerente.TabIndex = 1;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(143, 239);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(78, 25);
            this.btnVendedor.TabIndex = 2;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(491, 417);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(78, 21);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.White;
            this.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogin.Controls.Add(this.btnVendedor);
            this.PnlLogin.Location = new System.Drawing.Point(115, 64);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(350, 307);
            this.PnlLogin.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.PnlLogin);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnAdmin);
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
        private System.Windows.Forms.Panel PnlLogin;
    }
}

