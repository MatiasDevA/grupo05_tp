using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BLL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace UI_FERRETERIA
{
    public partial class FormAdmin : Form
    {
        private readonly AdminService _adminService = new AdminService();
        private List<PerfilBE> _perfiles;
        private string _modoFormulario = "";
        private int _idUsuarioSeleccionado = 0;

        public FormAdmin()
        {
            InitializeComponent();
            this.Text = "Panel de Administración";
            CargarPerfiles();
            CargarUsuarios();
        }

        private void CargarPerfiles()
        {
            try
            {
                _perfiles = _adminService.ObtenerPerfiles();

                var perfilesFiltro = new List<PerfilBE>();
                perfilesFiltro.Add(new PerfilBE { IdPerfil = 0, Nombre = "-- Todos --" });
                perfilesFiltro.AddRange(_perfiles);

                cboFiltroPerfil.DataSource = perfilesFiltro;
                cboFiltroPerfil.DisplayMember = "Nombre";
                cboFiltroPerfil.ValueMember = "IdPerfil";
                cboFiltroPerfil.SelectedIndex = 0;

                cboPerfil.DataSource = null;
                cboPerfil.DataSource = new List<PerfilBE>(_perfiles);
                cboPerfil.DisplayMember = "Nombre";
                cboPerfil.ValueMember = "IdPerfil";
                cboPerfil.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios(int? idPerfil = null, string estado = null, string textoBusqueda = null)
        {
            try
            {
                dgvUsuarios.DataSource = _adminService.ListarUsuarios(idPerfil, estado, textoBusqueda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? idPerfil = cboFiltroPerfil.SelectedValue as int?;
            if (idPerfil == 0) idPerfil = null;
            string estado = chkSoloActivos.Checked ? "Activo" : null;
            string textoBusqueda = string.IsNullOrWhiteSpace(txtBuscar.Text) ? null : txtBuscar.Text.Trim();
            CargarUsuarios(idPerfil, estado, textoBusqueda);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _modoFormulario = "agregar";
            lblFormularioTitulo.Text = "Agregar Usuario";
            RestablecerFormulario();
            pnlFormulario.Visible = true;
            pnlFormulario.BringToFront();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _modoFormulario = "modificar";
            lblFormularioTitulo.Text = "Modificar Usuario";
            RestablecerFormulario();

            _idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells["Apellido"].Value?.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value?.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells["Telefono"].Value?.ToString();
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString();

            pnlFormulario.Visible = true;
            pnlFormulario.BringToFront();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            string estadoActual = dgvUsuarios.CurrentRow.Cells["Estado"].Value?.ToString();
            string nuevoEstado = estadoActual?.ToLower() == "activo" ? "Inactivo" : "Activo";

            DialogResult resultado = MessageBox.Show(
                $"¿Desea cambiar el estado a '{nuevoEstado}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                _adminService.CambiarEstadoUsuario(idUsuario, nuevoEstado);
                MessageBox.Show("Estado cambiado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }
        }

        private void btnCambiarPerfil_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _modoFormulario = "cambiarPerfil";
            lblFormularioTitulo.Text = "Cambiar Perfil";
            RestablecerFormulario();

            _idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            string nombreUsuario = dgvUsuarios.CurrentRow.Cells["Usuario"].Value?.ToString();
            lblInfoUsuario.Text = $"Usuario: {nombreUsuario}";

            pnlFormulario.Visible = true;
            pnlFormulario.BringToFront();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_modoFormulario)
                {
                    case "agregar":
                        if (cboPerfil.SelectedIndex < 0)
                        {
                            MessageBox.Show("Seleccione un perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int idPerfil = Convert.ToInt32(cboPerfil.SelectedValue);
                        _adminService.AltaUsuario(
                            txtNombre.Text.Trim(),
                            txtApellido.Text.Trim(),
                            txtEmail.Text.Trim(),
                            txtUsuario.Text.Trim(),
                            txtClave.Text.Trim(),
                            txtTelefono.Text.Trim(),
                            idPerfil);
                        MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "modificar":
                        _adminService.ModificarUsuario(
                            _idUsuarioSeleccionado,
                            txtNombre.Text.Trim(),
                            txtApellido.Text.Trim(),
                            txtEmail.Text.Trim(),
                            txtTelefono.Text.Trim());

                        if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                        {
                            _adminService.ModificarUsuarioClave(
                                _idUsuarioSeleccionado,
                                txtUsuario.Text.Trim(),
                                txtClave.Text.Trim());
                        }
                        MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "cambiarPerfil":
                        if (cboPerfil.SelectedIndex < 0)
                        {
                            MessageBox.Show("Seleccione un perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int nuevoPerfil = Convert.ToInt32(cboPerfil.SelectedValue);
                        _adminService.CambiarPerfilUsuario(_idUsuarioSeleccionado, nuevoPerfil);
                        MessageBox.Show("Perfil cambiado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                pnlFormulario.Visible = false;
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Visible = false;
        }

        private void RestablecerFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
            cboPerfil.SelectedIndex = -1;
            lblInfoUsuario.Text = "";

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtUsuario.Enabled = true;
            txtClave.Enabled = true;
            cboPerfil.Enabled = false;

            switch (_modoFormulario)
            {
                case "agregar":
                    cboPerfil.Enabled = true;
                    break;
                case "modificar":
                    txtClave.Clear();
                    break;
                case "cambiarPerfil":
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtEmail.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtClave.Enabled = false;
                    cboPerfil.Enabled = true;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var login = new Login())
            {
                login.ShowDialog();
            }
            this.Close();
        }
    }
}
