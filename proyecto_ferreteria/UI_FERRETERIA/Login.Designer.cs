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
            this.PnlLogin = new System.Windows.Forms.Panel();
            this.PIconoInisio = new System.Windows.Forms.PictureBox();
            this.lblIniciarSesion = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUusario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIconoInisio)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogin
            // 
            this.PnlLogin.BackColor = System.Drawing.Color.White;
            this.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlLogin.Controls.Add(this.PIconoInisio);
            this.PnlLogin.Controls.Add(this.lblIniciarSesion);
            this.PnlLogin.Controls.Add(this.txtContrasena);
            this.PnlLogin.Controls.Add(this.lblContraseña);
            this.PnlLogin.Controls.Add(this.lblUusario);
            this.PnlLogin.Controls.Add(this.txtUsuario);
            this.PnlLogin.Location = new System.Drawing.Point(115, 64);
            this.PnlLogin.Name = "PnlLogin";
            this.PnlLogin.Size = new System.Drawing.Size(322, 307);
            this.PnlLogin.TabIndex = 4;
            // 
            // PIconoInisio
            // 
            this.PIconoInisio.Location = new System.Drawing.Point(96, 27);
            this.PIconoInisio.Name = "PIconoInisio";
            this.PIconoInisio.Size = new System.Drawing.Size(124, 63);
            this.PIconoInisio.TabIndex = 9;
            this.PIconoInisio.TabStop = false;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Silver;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(107, 254);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(87, 33);
            this.lblIniciarSesion.TabIndex = 8;
            this.lblIniciarSesion.Text = "iniciar sesion";
            this.lblIniciarSesion.UseVisualStyleBackColor = false;
            this.lblIniciarSesion.Click += new System.EventHandler(this.lblIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(162, 179);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtContrasena.TabIndex = 7;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(31, 179);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(92, 21);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUusario
            // 
            this.lblUusario.AutoSize = true;
            this.lblUusario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUusario.Location = new System.Drawing.Point(31, 143);
            this.lblUusario.Name = "lblUusario";
            this.lblUusario.Size = new System.Drawing.Size(65, 21);
            this.lblUusario.TabIndex = 5;
            this.lblUusario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(162, 144);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.PnlLogin);
            this.Name = "Login";
            this.Text = "Pantalla Principal";
            this.PnlLogin.ResumeLayout(false);
            this.PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIconoInisio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlLogin;
        private System.Windows.Forms.Button lblIniciarSesion;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUusario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox PIconoInisio;
    }
}

