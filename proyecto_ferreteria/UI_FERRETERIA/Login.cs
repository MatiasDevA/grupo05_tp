using System;
using System.Drawing;
using System.Windows.Forms;
using BLL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace UI_FERRETERIA
{
    public partial class Login : Form
    {
        private readonly LoginService _loginService = new LoginService();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Focus();
                    return;
                }

                UsuarioBE usuario = _loginService.Login(txtUsuario.Text.Trim(), txtClave.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClave.Clear();
                    txtClave.Focus();
                    return;
                }

                this.Hide();

                switch (usuario.IdPerfil)
                {
                    case 1:
                        using (var form = new FormAdmin())
                        {
                            form.ShowDialog();
                        }
                        break;
                    case 2:
                        using (var form = new FormGerente())
                        {
                            form.ShowDialog();
                        }
                        break;
                    case 3:
                        using (var form = new GestionClientes())
                        {
                            form.ShowDialog();
                        }
                        break;
                    case 4:
                        using (var form = new FormEncargadoDeposito(usuario.Nombre + " " + usuario.Apellido))
                        {
                            form.ShowDialog();
                        }
                        break;
                    default:
                        MessageBox.Show("Perfil no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
