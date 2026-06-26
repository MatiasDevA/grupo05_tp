using System.Windows.Forms;

namespace UI_FERRETERIA
{
    partial class GestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            this.panelBotones = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBusquedas = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.paneldvgCliente = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCentralVacio = new System.Windows.Forms.Panel();
            this.lblMensajeVacio = new System.Windows.Forms.Label();
            this.lblTituloVacio = new System.Windows.Forms.Label();
            this.piVacio = new System.Windows.Forms.PictureBox();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.Button();
            this.txtCuil = new System.Windows.Forms.Button();
            this.txtDirreccion = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRazonSocial = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.panelBotones.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelBusquedas.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.paneldvgCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelCentralVacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piVacio)).BeginInit();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotones.Controls.Add(this.button2);
            this.panelBotones.Controls.Add(this.button1);
            this.panelBotones.Controls.Add(this.btnBajaCliente);
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotones.Location = new System.Drawing.Point(10, 55);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1389, 39);
            this.panelBotones.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(360, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(239, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaCliente.Image")));
            this.btnBajaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaCliente.Location = new System.Drawing.Point(131, 9);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(102, 24);
            this.btnBajaCliente.TabIndex = 2;
            this.btnBajaCliente.Text = "Baja Cliente";
            this.btnBajaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(23, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 24);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo Cliente";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitulo.Controls.Add(this.lblBuscar);
            this.panelTitulo.Controls.Add(this.btnBuscar);
            this.panelTitulo.Controls.Add(this.TxtBuscar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(10, 94);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Padding = new System.Windows.Forms.Padding(10);
            this.panelTitulo.Size = new System.Drawing.Size(1389, 50);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(75, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(281, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(101, 13);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(162, 20);
            this.TxtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferreteria Industrial - Gestion de Clientes";
            // 
            // panelBusquedas
            // 
            this.panelBusquedas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBusquedas.Controls.Add(this.label1);
            this.panelBusquedas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusquedas.Location = new System.Drawing.Point(10, 10);
            this.panelBusquedas.Name = "panelBusquedas";
            this.panelBusquedas.Size = new System.Drawing.Size(1389, 45);
            this.panelBusquedas.TabIndex = 4;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.Controls.Add(this.panelCentralVacio);
            this.panelCentral.Controls.Add(this.paneldvgCliente);
            this.panelCentral.Controls.Add(this.panelCliente);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(10, 144);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1389, 685);
            this.panelCentral.TabIndex = 5;
            // 
            // paneldvgCliente
            // 
            this.paneldvgCliente.Controls.Add(this.dataGridView1);
            this.paneldvgCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldvgCliente.Location = new System.Drawing.Point(0, 0);
            this.paneldvgCliente.Name = "paneldvgCliente";
            this.paneldvgCliente.Size = new System.Drawing.Size(1389, 685);
            this.paneldvgCliente.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUIL,
            this.RazonSocial,
            this.Telefono,
            this.ID_Cliente,
            this.Direccion});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1389, 685);
            this.dataGridView1.TabIndex = 0;
            // 
            // CUIL
            // 
            this.CUIL.HeaderText = "CUIL";
            this.CUIL.Name = "CUIL";
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "Id_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // panelCentralVacio
            // 
            this.panelCentralVacio.CausesValidation = false;
            this.panelCentralVacio.Controls.Add(this.lblMensajeVacio);
            this.panelCentralVacio.Controls.Add(this.lblTituloVacio);
            this.panelCentralVacio.Controls.Add(this.piVacio);
            this.panelCentralVacio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentralVacio.Location = new System.Drawing.Point(0, 0);
            this.panelCentralVacio.Name = "panelCentralVacio";
            this.panelCentralVacio.Size = new System.Drawing.Size(1389, 685);
            this.panelCentralVacio.TabIndex = 0;
            // 
            // lblMensajeVacio
            // 
            this.lblMensajeVacio.AutoSize = true;
            this.lblMensajeVacio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeVacio.Location = new System.Drawing.Point(572, 431);
            this.lblMensajeVacio.Name = "lblMensajeVacio";
            this.lblMensajeVacio.Size = new System.Drawing.Size(236, 17);
            this.lblMensajeVacio.TabIndex = 2;
            this.lblMensajeVacio.Text = "Seleccione una acción para comenzar";
            // 
            // lblTituloVacio
            // 
            this.lblTituloVacio.AutoSize = true;
            this.lblTituloVacio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVacio.Location = new System.Drawing.Point(519, 371);
            this.lblTituloVacio.Name = "lblTituloVacio";
            this.lblTituloVacio.Size = new System.Drawing.Size(335, 30);
            this.lblTituloVacio.TabIndex = 1;
            this.lblTituloVacio.Text = "No hayinformacion para mostrar";
            // 
            // piVacio
            // 
            this.piVacio.Enabled = false;
            this.piVacio.ErrorImage = null;
            this.piVacio.Image = ((System.Drawing.Image)(resources.GetObject("piVacio.Image")));
            this.piVacio.Location = new System.Drawing.Point(604, 195);
            this.piVacio.Name = "piVacio";
            this.piVacio.Size = new System.Drawing.Size(190, 147);
            this.piVacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piVacio.TabIndex = 0;
            this.piVacio.TabStop = false;
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.Controls.Add(this.textBox5);
            this.panelCliente.Controls.Add(this.txtIdCliente);
            this.panelCliente.Controls.Add(this.txtCuil);
            this.panelCliente.Controls.Add(this.txtDirreccion);
            this.panelCliente.Controls.Add(this.button4);
            this.panelCliente.Controls.Add(this.btnRazonSocial);
            this.panelCliente.Controls.Add(this.textBox4);
            this.panelCliente.Controls.Add(this.textBox3);
            this.panelCliente.Controls.Add(this.txtTelefono);
            this.panelCliente.Controls.Add(this.txtRazonSocial);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(1389, 685);
            this.panelCliente.TabIndex = 3;
            this.panelCliente.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(403, 256);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 20);
            this.textBox5.TabIndex = 10;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(256, 253);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(127, 23);
            this.txtIdCliente.TabIndex = 9;
            this.txtIdCliente.Text = "ID_Cliente";
            this.txtIdCliente.UseVisualStyleBackColor = true;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(256, 207);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(127, 23);
            this.txtCuil.TabIndex = 8;
            this.txtCuil.Text = "CUIL";
            this.txtCuil.UseVisualStyleBackColor = true;
            // 
            // txtDirreccion
            // 
            this.txtDirreccion.Location = new System.Drawing.Point(256, 149);
            this.txtDirreccion.Name = "txtDirreccion";
            this.txtDirreccion.Size = new System.Drawing.Size(127, 27);
            this.txtDirreccion.TabIndex = 7;
            this.txtDirreccion.Text = "Dirreccion";
            this.txtDirreccion.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Telefono";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRazonSocial
            // 
            this.btnRazonSocial.Location = new System.Drawing.Point(256, 69);
            this.btnRazonSocial.Name = "btnRazonSocial";
            this.btnRazonSocial.Size = new System.Drawing.Size(124, 23);
            this.btnRazonSocial.TabIndex = 5;
            this.btnRazonSocial.Text = "Razon Social";
            this.btnRazonSocial.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(403, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(403, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 20);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(401, 69);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(197, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1409, 839);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelBusquedas);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GestionClientes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormVendedor";
            this.panelBotones.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelBusquedas.ResumeLayout(false);
            this.panelBusquedas.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.paneldvgCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelCentralVacio.ResumeLayout(false);
            this.panelCentralVacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piVacio)).EndInit();
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelBusquedas;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panelCentral;
        private Panel panelCentralVacio;
        private PictureBox piVacio;
        private Label lblMensajeVacio;
        private Label lblTituloVacio;
        private Panel panelCliente;
        private TextBox textBox5;
        private Button txtIdCliente;
        private Button txtCuil;
        private Button txtDirreccion;
        private Button button4;
        private Button btnRazonSocial;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txtTelefono;
        private TextBox txtRazonSocial;
        private Panel paneldvgCliente;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CUIL;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn ID_Cliente;
        private DataGridViewTextBoxColumn Direccion;
    }
}