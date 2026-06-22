using BLL_FERRETERIA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_FERRETERIA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; //Hack Usuario
            string clave = txtContrasena.Text;

            Autenticador auth = new Autenticador();// instancion un objeto de negocio
            Rol rol = auth.Validar(usuario, clave); //valido los datos

            //HACK esta harcodeado tiene que ser con facthory methode
            if (rol == Rol.Gerente)
            {
                FormGerente frm = new FormGerente();
                frm.Show();
                this.Hide();
            }
            else if (rol == Rol.Vendedor)
            {
                MenuVendedor frm = new MenuVendedor(this);
                frm.Show();
                this.Hide();
            }
            else if (rol == Rol.Logistica)
            {
                FormLogistica frm = new FormLogistica();
                frm.Show();
                this.Hide();
            }
            else if (rol == Rol.Sistema)
            {
                FormAdmin frm = new FormAdmin();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }
    }
}
