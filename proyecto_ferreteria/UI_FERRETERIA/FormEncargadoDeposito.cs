using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace UI_FERRETERIA
{
    public partial class FormEncargadoDeposito : Form
    {
        private readonly OrdenCompraService _ordenService = new OrdenCompraService();
        private readonly ProductoService _productoService = new ProductoService();
        private readonly ProveedorService _proveedorService = new ProveedorService();
        private int _idUsuarioActual = 1; // TODO: obtener del login

        public FormEncargadoDeposito(string nombreUsuario = "Encargado")
        {
            InitializeComponent();
            lblTituloAbierto.Text = "Bienvenido, " + nombreUsuario;
            CargarCategorias();
            CargarProveedores();
            CargarProductos();
            CargarEstadosOrden();
            CargarListadoProductos();
        }

        private void CargarCategorias()
        {
            try
            {
                List<CategoriaBE> categorias = _productoService.ObtenerCategorias();
                categorias.Insert(0, new CategoriaBE { Nombre = "Todas" });

                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "Nombre";
                cboCategoria.ValueMember = "Nombre";
                cboCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                List<ProveedorBE> proveedores = _proveedorService.ObtenerProveedores();
                cboProveedor.DataSource = proveedores;
                cboProveedor.DisplayMember = "RazonSocial";
                cboProveedor.ValueMember = "IdProveedor";
                cboProveedor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                List<ProductoBE> productos = _productoService.ObtenerProductos();
                cboProducto.DataSource = productos;
                cboProducto.DisplayMember = "Descripcion";
                cboProducto.ValueMember = "IdProducto";
                cboProducto.SelectedIndex = 0;

                cboProductoEgreso.DataSource = new List<ProductoBE>(productos);
                cboProductoEgreso.DisplayMember = "Descripcion";
                cboProductoEgreso.ValueMember = "IdProducto";
                cboProductoEgreso.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstadosOrden()
        {
            try
            {
                List<EstadoOrdenBE> estados = _ordenService.ObtenerEstadosOrden();
                estados.Insert(0, new EstadoOrdenBE { Estado = "" });

                cboFiltroEstado.DataSource = estados;
                cboFiltroEstado.DisplayMember = "Estado";
                cboFiltroEstado.ValueMember = "Estado";
                cboFiltroEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListadoProductos()
        {
            try
            {
                dgvProductos.DataSource = _productoService.ObtenerListadoProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string categoria = cboCategoria.SelectedValue?.ToString();
                if (categoria == "Todas") categoria = null;
                dgvProductos.DataSource = _productoService.ObtenerListadoProductos(categoria, chkSoloAlertas.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCantidadEgreso.Text))
                {
                    MessageBox.Show("Ingrese la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProducto = Convert.ToInt32(cboProductoEgreso.SelectedValue);
                int cantidad = int.Parse(txtCantidadEgreso.Text);
                _productoService.RegistrarEgresoStock(idProducto, cantidad);
                MessageBox.Show("Egreso de stock registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidadEgreso.Clear();
                CargarListadoProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = Convert.ToInt32(cboProveedor.SelectedValue);
                OrdenCompraBE orden = _ordenService.RegistrarOrdenCompra(_idUsuarioActual, idProveedor, DateTime.Now);

                if (orden != null)
                {
                    txtIdOrden.Text = orden.IdOrdenCompra.ToString();
                    MessageBox.Show($"Orden registrada con ID: {orden.IdOrdenCompra}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdOrden.Text) ||
                    string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
                {
                    MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idOrden = int.Parse(txtIdOrden.Text);
                int idProducto = Convert.ToInt32(cboProducto.SelectedValue);
                int cantidad = int.Parse(txtCantidad.Text);
                decimal precioUnitario = decimal.Parse(txtPrecioUnitario.Text);

                _ordenService.AgregarDetalleOrden(idOrden, idProducto, cantidad, precioUnitario);
                MessageBox.Show("Detalle agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<ItemOrdenBE> itemsActualizados = _ordenService.ObtenerItemsOrden(idOrden);
                dgvItemsOrden.DataSource = itemsActualizados.Count > 0 ? itemsActualizados : null;
                LimpiarDetalles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdOrden.Text))
                {
                    MessageBox.Show("Seleccione una orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idOrden = int.Parse(txtIdOrden.Text);
                _ordenService.ConfirmarOrden(idOrden);
                MessageBox.Show("Orden confirmada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarListadoProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdOrden.Text))
                {
                    MessageBox.Show("Seleccione una orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idOrden = int.Parse(txtIdOrden.Text);
                _ordenService.CancelarOrden(idOrden);
                MessageBox.Show("Orden cancelada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarOrden();
                CargarListadoProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerItemsOrden_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdOrden.Text))
                {
                    MessageBox.Show("Ingrese el ID de la orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idOrden = int.Parse(txtIdOrden.Text);
                dgvItemsOrden.DataSource = _ordenService.ObtenerItemsOrden(idOrden);
                lblTituloAbierto.Text = "Items de la Orden #" + idOrden;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlertas_Click(object sender, EventArgs e)
        {
            try
            {
                List<AlertaStockBE> alertas = _productoService.GenerarAlertaStock();
                dgvResultado.DataSource = alertas;

                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    string nivel = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn.HeaderText.ToLower().Contains("nivel") ||
                            cell.OwningColumn.Name.ToLower().Contains("nivel"))
                        {
                            nivel = cell.Value?.ToString()?.ToLower() ?? "";
                            break;
                        }
                    }

                    if (nivel.Contains("critico") || nivel.Contains("sin stock"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (nivel.Contains("bajo"))
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178);
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = cboFiltroEstado.SelectedValue?.ToString();
                int? idProveedor = string.IsNullOrWhiteSpace(txtFiltroProveedor.Text) ? (int?)null : int.Parse(txtFiltroProveedor.Text);
                DateTime? fechaDesde = dtpDesde.Checked ? dtpDesde.Value.Date : (DateTime?)null;
                DateTime? fechaHasta = dtpHasta.Checked ? dtpHasta.Value.Date : (DateTime?)null;

                dgvResultado.DataSource = _ordenService.ObtenerHistorialOrdenes(estado, idProveedor, fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivarPanel_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            pnlOrdenes.Visible = false;
            pnlListados.Visible = false;
            dgvResultado.DataSource = null;

            Button btn = (Button)sender;
            string tag = btn.Tag?.ToString() ?? "";

            switch (tag)
            {
                case "Productos":
                    pnlProductos.Visible = true;
                    lblTituloAbierto.Text = "Gestión de Inventario";
                    CargarListadoProductos();
                    break;
                case "Ordenes":
                    pnlOrdenes.Visible = true;
                    lblTituloAbierto.Text = "Gestión de Órdenes de Compra";
                    break;
                case "Historial":
                    pnlListados.Visible = true;
                    lblTituloAbierto.Text = "Historial de Órdenes";
                    break;
                case "Alertas":
                    pnlListados.Visible = true;
                    lblTituloAbierto.Text = "Alertas de Stock";
                    btnAlertas_Click(sender, e);
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            pnlProductos.Visible = false;
            pnlOrdenes.Visible = false;
            pnlListados.Visible = false;
            lblTituloAbierto.Text = "Bienvenido, Encargado";
        }

        private void LimpiarDetalles()
        {
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
        }

        private void LimpiarOrden()
        {
            txtIdOrden.Clear();
            LimpiarDetalles();
        }
    }
}
