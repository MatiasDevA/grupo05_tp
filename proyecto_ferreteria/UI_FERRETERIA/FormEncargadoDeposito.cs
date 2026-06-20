using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL_FERRETERIA;

namespace UI_FERRETERIA
{
    public partial class FormEncargadoDeposito : Form
    {
        private readonly EncargadoDepositoNegocio _negocio = new EncargadoDepositoNegocio();
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
                DataTable categorias = _negocio.ObtenerCategorias();
                DataRow filaTodos = categorias.NewRow();
                filaTodos["categoria"] = "Todas";
                categorias.Rows.InsertAt(filaTodos, 0);

                cboCategoria.DataSource = categorias;
                cboCategoria.DisplayMember = "categoria";
                cboCategoria.ValueMember = "categoria";
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
                DataTable proveedores = _negocio.ObtenerProveedores();
                cboProveedor.DataSource = proveedores;
                cboProveedor.DisplayMember = "razon_social";
                cboProveedor.ValueMember = "id_proveedor";
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
                DataTable productos = _negocio.ObtenerProductos();
                cboProducto.DataSource = productos;
                cboProducto.DisplayMember = "descripcion";
                cboProducto.ValueMember = "id_producto";
                cboProducto.SelectedIndex = 0;

                cboProductoEgreso.DataSource = productos.Copy();
                cboProductoEgreso.DisplayMember = "descripcion";
                cboProductoEgreso.ValueMember = "id_producto";
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
                DataTable estados = _negocio.ObtenerEstadosOrden();
                DataRow filaTodos = estados.NewRow();
                estados.Rows.InsertAt(filaTodos, 0);

                cboFiltroEstado.DataSource = estados;
                cboFiltroEstado.DisplayMember = "estado";
                cboFiltroEstado.ValueMember = "estado";
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
                dgvProductos.DataSource = _negocio.ObtenerListadoProductos();
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
                dgvProductos.DataSource = _negocio.ObtenerListadoProductos(categoria, chkSoloAlertas.Checked);
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
                _negocio.RegistrarEgresoStock(idProducto, cantidad);
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
                DataTable resultado = _negocio.RegistrarOrdenCompra(_idUsuarioActual, idProveedor);

                if (resultado != null && resultado.Rows.Count > 0)
                {
                    int idOrden = Convert.ToInt32(resultado.Rows[0][0]);
                    txtIdOrden.Text = idOrden.ToString();
                    MessageBox.Show($"Orden registrada con ID: {idOrden}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvResultado.DataSource = resultado;
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

                DataTable resultado = _negocio.AgregarDetalleOrden(idOrden, idProducto, cantidad, precioUnitario);
                MessageBox.Show("Detalle agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvItemsOrden.DataSource = resultado;
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
                _negocio.ConfirmarOrden(idOrden);
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
                _negocio.CancelarOrden(idOrden);
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
                dgvItemsOrden.DataSource = _negocio.ObtenerItemsOrden(idOrden);
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
                DataTable alertas = _negocio.GenerarAlertaStock();
                dgvResultado.DataSource = alertas;

                foreach (DataGridViewRow row in dgvResultado.Rows)
                {
                    string nivel = row.Cells["nivel_alerta"].Value?.ToString()?.ToLower() ?? "";

                    if (nivel.Contains("critico") || nivel.Contains("sin stock"))
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                    else if (nivel.Contains("bajo"))
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 224, 178);
                        row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
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

                dgvResultado.DataSource = _negocio.ObtenerHistorialOrdenes(estado, idProveedor, fechaDesde, fechaHasta);
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
