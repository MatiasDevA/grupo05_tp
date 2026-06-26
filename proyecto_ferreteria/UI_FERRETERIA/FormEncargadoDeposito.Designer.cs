using System;

namespace UI_FERRETERIA
{
    partial class FormEncargadoDeposito
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnGestionProductos;
        private System.Windows.Forms.Button btnGestionOrdenes;
        private System.Windows.Forms.Button btnAlertasStock;
        private System.Windows.Forms.Button btnHistorialOrdenes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolverAtras;

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTituloAbierto;

        // Gestión Productos
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.CheckBox chkSoloAlertas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProductoEgreso;
        private System.Windows.Forms.ComboBox cboProductoEgreso;
        private System.Windows.Forms.Label lblCantidadEgreso;
        private System.Windows.Forms.TextBox txtCantidadEgreso;
        private System.Windows.Forms.Button btnRegistrarEgreso;

        // Gestión Órdenes
        private System.Windows.Forms.Panel pnlOrdenes;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Button btnRegistrarOrden;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.TextBox txtIdOrden;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnConfirmarOrden;
        private System.Windows.Forms.Button btnCancelarOrden;
        private System.Windows.Forms.Button btnVerItemsOrden;
        private System.Windows.Forms.DataGridView dgvItemsOrden;
        private System.Windows.Forms.Label lblIdOrden;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPrecio;

        // Historial / Alertas / Detalle
        private System.Windows.Forms.Panel pnlListados;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.TextBox txtFiltroProveedor;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscarHistorial;

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblProvH;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnGestionProductos = new System.Windows.Forms.Button();
            this.btnGestionOrdenes = new System.Windows.Forms.Button();
            this.btnHistorialOrdenes = new System.Windows.Forms.Button();
            this.btnAlertasStock = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblTituloAbierto = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.chkSoloAlertas = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblProductoEgreso = new System.Windows.Forms.Label();
            this.cboProductoEgreso = new System.Windows.Forms.ComboBox();
            this.lblCantidadEgreso = new System.Windows.Forms.Label();
            this.txtCantidadEgreso = new System.Windows.Forms.TextBox();
            this.btnRegistrarEgreso = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnlOrdenes = new System.Windows.Forms.Panel();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.btnRegistrarOrden = new System.Windows.Forms.Button();
            this.lblIdOrden = new System.Windows.Forms.Label();
            this.txtIdOrden = new System.Windows.Forms.TextBox();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnConfirmarOrden = new System.Windows.Forms.Button();
            this.btnCancelarOrden = new System.Windows.Forms.Button();
            this.btnVerItemsOrden = new System.Windows.Forms.Button();
            this.dgvItemsOrden = new System.Windows.Forms.DataGridView();
            this.pnlListados = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblProvH = new System.Windows.Forms.Label();
            this.txtFiltroProveedor = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlOrdenes.SuspendLayout();
            this.pnlListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.pnlMenu.Controls.Add(this.btnGestionProductos);
            this.pnlMenu.Controls.Add(this.btnGestionOrdenes);
            this.pnlMenu.Controls.Add(this.btnHistorialOrdenes);
            this.pnlMenu.Controls.Add(this.btnAlertasStock);
            this.pnlMenu.Controls.Add(this.btnVolver);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 650);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionProductos.FlatAppearance.BorderSize = 0;
            this.btnGestionProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProductos.ForeColor = System.Drawing.Color.White;
            this.btnGestionProductos.Location = new System.Drawing.Point(0, 80);
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionProductos.Size = new System.Drawing.Size(240, 60);
            this.btnGestionProductos.TabIndex = 0;
            this.btnGestionProductos.Tag = "Productos";
            this.btnGestionProductos.Text = "▶  Gestión Inventario";
            this.btnGestionProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProductos.UseVisualStyleBackColor = false;
            this.btnGestionProductos.Click += new System.EventHandler(this.btnActivarPanel_Click);
            // 
            // btnGestionOrdenes
            // 
            this.btnGestionOrdenes.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionOrdenes.FlatAppearance.BorderSize = 0;
            this.btnGestionOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionOrdenes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnGestionOrdenes.Location = new System.Drawing.Point(0, 140);
            this.btnGestionOrdenes.Name = "btnGestionOrdenes";
            this.btnGestionOrdenes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGestionOrdenes.Size = new System.Drawing.Size(240, 60);
            this.btnGestionOrdenes.TabIndex = 1;
            this.btnGestionOrdenes.Tag = "Ordenes";
            this.btnGestionOrdenes.Text = "▶  Gestión Órdenes";
            this.btnGestionOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionOrdenes.UseVisualStyleBackColor = false;
            this.btnGestionOrdenes.Click += new System.EventHandler(this.btnActivarPanel_Click);
            // 
            // btnHistorialOrdenes
            // 
            this.btnHistorialOrdenes.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorialOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialOrdenes.FlatAppearance.BorderSize = 0;
            this.btnHistorialOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialOrdenes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnHistorialOrdenes.Location = new System.Drawing.Point(0, 200);
            this.btnHistorialOrdenes.Name = "btnHistorialOrdenes";
            this.btnHistorialOrdenes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistorialOrdenes.Size = new System.Drawing.Size(240, 60);
            this.btnHistorialOrdenes.TabIndex = 2;
            this.btnHistorialOrdenes.Tag = "Historial";
            this.btnHistorialOrdenes.Text = "▶  Historial Órdenes";
            this.btnHistorialOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialOrdenes.UseVisualStyleBackColor = false;
            this.btnHistorialOrdenes.Click += new System.EventHandler(this.btnActivarPanel_Click);
            // 
            // btnAlertasStock
            // 
            this.btnAlertasStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAlertasStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertasStock.FlatAppearance.BorderSize = 0;
            this.btnAlertasStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlertasStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertasStock.ForeColor = System.Drawing.Color.White;
            this.btnAlertasStock.Location = new System.Drawing.Point(0, 260);
            this.btnAlertasStock.Name = "btnAlertasStock";
            this.btnAlertasStock.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAlertasStock.Size = new System.Drawing.Size(240, 60);
            this.btnAlertasStock.TabIndex = 3;
            this.btnAlertasStock.Tag = "Alertas";
            this.btnAlertasStock.Text = "⚠  Alertas Stock";
            this.btnAlertasStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlertasStock.UseVisualStyleBackColor = false;
            this.btnAlertasStock.Click += new System.EventHandler(this.btnActivarPanel_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(0, 590);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(240, 60);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "✖  Cerrar Sesión";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnVolverAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverAtras.FlatAppearance.BorderSize = 0;
            this.btnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAtras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAtras.ForeColor = System.Drawing.Color.White;
            this.btnVolverAtras.Location = new System.Drawing.Point(810, 25);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(150, 35);
            this.btnVolverAtras.TabIndex = 1;
            this.btnVolverAtras.Text = "← Volver Atrás";
            this.btnVolverAtras.UseVisualStyleBackColor = false;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlContenido.Controls.Add(this.lblTituloAbierto);
            this.pnlContenido.Controls.Add(this.btnVolverAtras);
            this.pnlContenido.Controls.Add(this.pnlProductos);
            this.pnlContenido.Controls.Add(this.pnlOrdenes);
            this.pnlContenido.Controls.Add(this.pnlListados);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(240, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.pnlContenido.Size = new System.Drawing.Size(983, 650);
            this.pnlContenido.TabIndex = 0;
            // 
            // lblTituloAbierto
            // 
            this.lblTituloAbierto.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAbierto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.lblTituloAbierto.Location = new System.Drawing.Point(20, 20);
            this.lblTituloAbierto.Name = "lblTituloAbierto";
            this.lblTituloAbierto.Size = new System.Drawing.Size(700, 40);
            this.lblTituloAbierto.TabIndex = 0;
            this.lblTituloAbierto.Text = "Bienvenido, Encargado";
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.lblCategoria);
            this.pnlProductos.Controls.Add(this.cboCategoria);
            this.pnlProductos.Controls.Add(this.chkSoloAlertas);
            this.pnlProductos.Controls.Add(this.btnBuscar);
            this.pnlProductos.Controls.Add(this.lblProductoEgreso);
            this.pnlProductos.Controls.Add(this.cboProductoEgreso);
            this.pnlProductos.Controls.Add(this.lblCantidadEgreso);
            this.pnlProductos.Controls.Add(this.txtCantidadEgreso);
            this.pnlProductos.Controls.Add(this.btnRegistrarEgreso);
            this.pnlProductos.Controls.Add(this.dgvProductos);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductos.Location = new System.Drawing.Point(20, 80);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(943, 550);
            this.pnlProductos.TabIndex = 2;
            this.pnlProductos.Visible = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(98, 25);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Location = new System.Drawing.Point(100, 27);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(180, 32);
            this.cboCategoria.TabIndex = 1;
            // 
            // chkSoloAlertas
            // 
            this.chkSoloAlertas.AutoSize = true;
            this.chkSoloAlertas.Location = new System.Drawing.Point(300, 28);
            this.chkSoloAlertas.Name = "chkSoloAlertas";
            this.chkSoloAlertas.Size = new System.Drawing.Size(201, 29);
            this.chkSoloAlertas.TabIndex = 2;
            this.chkSoloAlertas.Text = "Mostrar solo alertas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(543, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Productos";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblProductoEgreso
            // 
            this.lblProductoEgreso.AutoSize = true;
            this.lblProductoEgreso.Location = new System.Drawing.Point(20, 85);
            this.lblProductoEgreso.Name = "lblProductoEgreso";
            this.lblProductoEgreso.Size = new System.Drawing.Size(79, 25);
            this.lblProductoEgreso.TabIndex = 4;
            this.lblProductoEgreso.Text = "Producto:";
            // 
            // cboProductoEgreso
            // 
            this.cboProductoEgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductoEgreso.Location = new System.Drawing.Point(110, 82);
            this.cboProductoEgreso.Name = "cboProductoEgreso";
            this.cboProductoEgreso.Size = new System.Drawing.Size(200, 32);
            this.cboProductoEgreso.TabIndex = 5;
            // 
            // lblCantidadEgreso
            // 
            this.lblCantidadEgreso.AutoSize = true;
            this.lblCantidadEgreso.Location = new System.Drawing.Point(330, 85);
            this.lblCantidadEgreso.Name = "lblCantidadEgreso";
            this.lblCantidadEgreso.Size = new System.Drawing.Size(79, 25);
            this.lblCantidadEgreso.TabIndex = 6;
            this.lblCantidadEgreso.Text = "Cantidad:";
            // 
            // txtCantidadEgreso
            // 
            this.txtCantidadEgreso.Location = new System.Drawing.Point(420, 82);
            this.txtCantidadEgreso.Name = "txtCantidadEgreso";
            this.txtCantidadEgreso.Size = new System.Drawing.Size(100, 32);
            this.txtCantidadEgreso.TabIndex = 7;
            // 
            // btnRegistrarEgreso
            // 
            this.btnRegistrarEgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrarEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEgreso.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEgreso.Location = new System.Drawing.Point(540, 78);
            this.btnRegistrarEgreso.Name = "btnRegistrarEgreso";
            this.btnRegistrarEgreso.Size = new System.Drawing.Size(150, 35);
            this.btnRegistrarEgreso.TabIndex = 8;
            this.btnRegistrarEgreso.Text = "Registrar Egreso";
            this.btnRegistrarEgreso.UseVisualStyleBackColor = false;
            this.btnRegistrarEgreso.Click += new System.EventHandler(this.btnRegistrarEgreso_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 40;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location = new System.Drawing.Point(20, 160);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 35;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1473, 850);
            this.dgvProductos.TabIndex = 9;
            // 
            // pnlOrdenes
            // 
            this.pnlOrdenes.Controls.Add(this.lblIdProveedor);
            this.pnlOrdenes.Controls.Add(this.cboProveedor);
            this.pnlOrdenes.Controls.Add(this.btnRegistrarOrden);
            this.pnlOrdenes.Controls.Add(this.lblIdOrden);
            this.pnlOrdenes.Controls.Add(this.txtIdOrden);
            this.pnlOrdenes.Controls.Add(this.lblIdProd);
            this.pnlOrdenes.Controls.Add(this.cboProducto);
            this.pnlOrdenes.Controls.Add(this.lblCant);
            this.pnlOrdenes.Controls.Add(this.txtCantidad);
            this.pnlOrdenes.Controls.Add(this.lblPrecio);
            this.pnlOrdenes.Controls.Add(this.txtPrecioUnitario);
            this.pnlOrdenes.Controls.Add(this.btnAgregarDetalle);
            this.pnlOrdenes.Controls.Add(this.btnConfirmarOrden);
            this.pnlOrdenes.Controls.Add(this.btnCancelarOrden);
            this.pnlOrdenes.Controls.Add(this.btnVerItemsOrden);
            this.pnlOrdenes.Controls.Add(this.dgvItemsOrden);
            this.pnlOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrdenes.Location = new System.Drawing.Point(20, 80);
            this.pnlOrdenes.Name = "pnlOrdenes";
            this.pnlOrdenes.Size = new System.Drawing.Size(943, 550);
            this.pnlOrdenes.TabIndex = 3;
            this.pnlOrdenes.Visible = false;
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Location = new System.Drawing.Point(20, 30);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(126, 25);
            this.lblIdProveedor.TabIndex = 0;
            this.lblIdProveedor.Text = "Proveedor:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.Location = new System.Drawing.Point(125, 27);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(200, 32);
            this.cboProveedor.TabIndex = 1;
            // 
            // btnRegistrarOrden
            // 
            this.btnRegistrarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRegistrarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarOrden.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarOrden.Location = new System.Drawing.Point(350, 24);
            this.btnRegistrarOrden.Name = "btnRegistrarOrden";
            this.btnRegistrarOrden.Size = new System.Drawing.Size(170, 35);
            this.btnRegistrarOrden.TabIndex = 2;
            this.btnRegistrarOrden.Text = "Crear Orden Nueva";
            this.btnRegistrarOrden.UseVisualStyleBackColor = false;
            this.btnRegistrarOrden.Click += new System.EventHandler(this.btnRegistrarOrden_Click);
            // 
            // lblIdOrden
            // 
            this.lblIdOrden.AutoSize = true;
            this.lblIdOrden.Location = new System.Drawing.Point(20, 85);
            this.lblIdOrden.Name = "lblIdOrden";
            this.lblIdOrden.Size = new System.Drawing.Size(92, 25);
            this.lblIdOrden.TabIndex = 3;
            this.lblIdOrden.Text = "ID Orden:";
            // 
            // txtIdOrden
            // 
            this.txtIdOrden.Location = new System.Drawing.Point(95, 82);
            this.txtIdOrden.Name = "txtIdOrden";
            this.txtIdOrden.Size = new System.Drawing.Size(70, 32);
            this.txtIdOrden.TabIndex = 4;
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(180, 85);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(79, 25);
            this.lblIdProd.TabIndex = 5;
            this.lblIdProd.Text = "Producto:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.Location = new System.Drawing.Point(260, 82);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(160, 32);
            this.cboProducto.TabIndex = 6;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(440, 85);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(55, 25);
            this.lblCant.TabIndex = 7;
            this.lblCant.Text = "Cant:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(490, 82);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 32);
            this.txtCantidad.TabIndex = 8;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(570, 85);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(109, 25);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio Unit:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(680, 82);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(80, 32);
            this.txtPrecioUnitario.TabIndex = 10;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDetalle.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDetalle.Location = new System.Drawing.Point(780, 78);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(130, 35);
            this.btnAgregarDetalle.TabIndex = 11;
            this.btnAgregarDetalle.Text = "Agregar Item";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnConfirmarOrden
            // 
            this.btnConfirmarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnConfirmarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarOrden.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarOrden.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarOrden.Location = new System.Drawing.Point(20, 140);
            this.btnConfirmarOrden.Name = "btnConfirmarOrden";
            this.btnConfirmarOrden.Size = new System.Drawing.Size(170, 45);
            this.btnConfirmarOrden.TabIndex = 12;
            this.btnConfirmarOrden.Text = "Confirmar Orden";
            this.btnConfirmarOrden.UseVisualStyleBackColor = false;
            this.btnConfirmarOrden.Click += new System.EventHandler(this.btnConfirmarOrden_Click);
            // 
            // btnCancelarOrden
            // 
            this.btnCancelarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOrden.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarOrden.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOrden.Location = new System.Drawing.Point(210, 140);
            this.btnCancelarOrden.Name = "btnCancelarOrden";
            this.btnCancelarOrden.Size = new System.Drawing.Size(170, 45);
            this.btnCancelarOrden.TabIndex = 13;
            this.btnCancelarOrden.Text = "Cancelar Orden";
            this.btnCancelarOrden.UseVisualStyleBackColor = false;
            this.btnCancelarOrden.Click += new System.EventHandler(this.btnCancelarOrden_Click);
            // 
            // btnVerItemsOrden
            // 
            this.btnVerItemsOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnVerItemsOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerItemsOrden.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerItemsOrden.ForeColor = System.Drawing.Color.White;
            this.btnVerItemsOrden.Location = new System.Drawing.Point(400, 140);
            this.btnVerItemsOrden.Name = "btnVerItemsOrden";
            this.btnVerItemsOrden.Size = new System.Drawing.Size(170, 45);
            this.btnVerItemsOrden.TabIndex = 14;
            this.btnVerItemsOrden.Text = "Ver Items Orden";
            this.btnVerItemsOrden.UseVisualStyleBackColor = false;
            this.btnVerItemsOrden.Click += new System.EventHandler(this.btnVerItemsOrden_Click);
            // 
            // dgvItemsOrden
            // 
            this.dgvItemsOrden.AllowUserToAddRows = false;
            this.dgvItemsOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemsOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItemsOrden.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemsOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemsOrden.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.dgvItemsOrden.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvItemsOrden.ColumnHeadersHeight = 40;
            this.dgvItemsOrden.EnableHeadersVisualStyles = false;
            this.dgvItemsOrden.Location = new System.Drawing.Point(20, 200);
            this.dgvItemsOrden.Name = "dgvItemsOrden";
            this.dgvItemsOrden.ReadOnly = true;
            this.dgvItemsOrden.RowHeadersWidth = 51;
            this.dgvItemsOrden.RowTemplate.Height = 35;
            this.dgvItemsOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemsOrden.Size = new System.Drawing.Size(900, 330);
            this.dgvItemsOrden.TabIndex = 15;
            // 
            // pnlListados
            // 
            this.pnlListados.Controls.Add(this.lblEstado);
            this.pnlListados.Controls.Add(this.cboFiltroEstado);
            this.pnlListados.Controls.Add(this.lblProvH);
            this.pnlListados.Controls.Add(this.txtFiltroProveedor);
            this.pnlListados.Controls.Add(this.dtpDesde);
            this.pnlListados.Controls.Add(this.dtpHasta);
            this.pnlListados.Controls.Add(this.btnBuscarHistorial);
            this.pnlListados.Controls.Add(this.dgvResultado);
            this.pnlListados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListados.Location = new System.Drawing.Point(20, 80);
            this.pnlListados.Name = "pnlListados";
            this.pnlListados.Size = new System.Drawing.Size(943, 550);
            this.pnlListados.TabIndex = 4;
            this.pnlListados.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(20, 30);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 25);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado:";
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.Location = new System.Drawing.Point(80, 27);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(120, 32);
            this.cboFiltroEstado.TabIndex = 1;
            // 
            // lblProvH
            // 
            this.lblProvH.AutoSize = true;
            this.lblProvH.Location = new System.Drawing.Point(195, 30);
            this.lblProvH.Name = "lblProvH";
            this.lblProvH.Size = new System.Drawing.Size(77, 25);
            this.lblProvH.TabIndex = 2;
            this.lblProvH.Text = "ID Prov:";
            // 
            // txtFiltroProveedor
            // 
            this.txtFiltroProveedor.Location = new System.Drawing.Point(260, 27);
            this.txtFiltroProveedor.Name = "txtFiltroProveedor";
            this.txtFiltroProveedor.Size = new System.Drawing.Size(70, 32);
            this.txtFiltroProveedor.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(345, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.ShowCheckBox = true;
            this.dtpDesde.Size = new System.Drawing.Size(120, 32);
            this.dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(480, 27);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.ShowCheckBox = true;
            this.dtpHasta.Size = new System.Drawing.Size(120, 32);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBuscarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHistorial.Location = new System.Drawing.Point(615, 23);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(150, 35);
            this.btnBuscarHistorial.TabIndex = 6;
            this.btnBuscarHistorial.Text = "Buscar Órdenes";
            this.btnBuscarHistorial.UseVisualStyleBackColor = false;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultado.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResultado.ColumnHeadersHeight = 40;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.Location = new System.Drawing.Point(20, 160);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.RowTemplate.Height = 35;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(1473, 850);
            this.dgvResultado.TabIndex = 10;
            // 
            // FormEncargadoDeposito
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1223, 650);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormEncargadoDeposito";
            this.Text = "Ferretería - Módulo Encargado de Depósito";
            this.pnlMenu.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlOrdenes.ResumeLayout(false);
            this.pnlOrdenes.PerformLayout();
            this.pnlListados.ResumeLayout(false);
            this.pnlListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

