namespace UI_FERRETERIA
{
    partial class MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVendedor));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pimagen = new System.Windows.Forms.PictureBox();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.pnlInferiror = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(76, 34);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(314, 55);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Gestion Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(76, 191);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(314, 55);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrra Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.pnlSuperior.Controls.Add(this.lblTitulo3);
            this.pnlSuperior.Controls.Add(this.lblTitulo2);
            this.pnlSuperior.Controls.Add(this.lblTitulo1);
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1045, 100);
            this.pnlSuperior.TabIndex = 2;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.ForeColor = System.Drawing.Color.White;
            this.lblTitulo3.Location = new System.Drawing.Point(151, 71);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(232, 15);
            this.lblTitulo3.TabIndex = 3;
            this.lblTitulo3.Text = "Herramientas y materiales de construccíon";
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(149, 41);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(131, 30);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "INDUSTRIAL";
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.Color.White;
            this.lblTitulo1.Location = new System.Drawing.Point(148, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(143, 32);
            this.lblTitulo1.TabIndex = 1;
            this.lblTitulo1.Text = "FERRETERÍA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.pimagen);
            this.pnlMenu.Controls.Add(this.btnNuevaVenta);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1045, 392);
            this.pnlMenu.TabIndex = 3;
            // 
            // pimagen
            // 
            this.pimagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pimagen.Image = ((System.Drawing.Image)(resources.GetObject("pimagen.Image")));
            this.pimagen.Location = new System.Drawing.Point(577, 25);
            this.pimagen.Name = "pimagen";
            this.pimagen.Size = new System.Drawing.Size(233, 235);
            this.pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pimagen.TabIndex = 3;
            this.pimagen.TabStop = false;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.Image")));
            this.btnNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.Location = new System.Drawing.Point(76, 112);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(314, 55);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // pnlInferiror
            // 
            this.pnlInferiror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.pnlInferiror.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferiror.Location = new System.Drawing.Point(0, 447);
            this.pnlInferiror.Name = "pnlInferiror";
            this.pnlInferiror.Size = new System.Drawing.Size(1045, 45);
            this.pnlInferiror.TabIndex = 4;
            // 
            // MenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 492);
            this.Controls.Add(this.pnlInferiror);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "MenuVendedor";
            this.Text = "Menu Principal - Vendedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuVendedor_FormClosed);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlInferiror;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox pimagen;
    }
}