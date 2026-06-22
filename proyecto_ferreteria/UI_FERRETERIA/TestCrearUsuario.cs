using BLL_FERRETERIA;
using ENTIDADES.FERRETERIA;
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
    public partial class TestCrearUsuario : Form
    {
        public TestCrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioFactory factory = new UsuarioFactory();
            Usuario usuario = factory.CrearUsuario(TipoUsuario.Administrador, 1, "admin", "admin123", "Juan", "Perez");
            //          (TipoUsuario tipo, int idUsuario, string nombreUsuario,string clave,string nombre,string apellido)
                MessageBox.Show(usuario.GetType().Name);
        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            UsuarioFactory factory = new UsuarioFactory();
            Usuario usuario = factory.CrearUsuario(TipoUsuario.Vendedor, 1, "vendedor1", "plata123", "Jose", "Gomez");
            //          (TipoUsuario tipo, int idUsuario, string nombreUsuario,string clave,string nombre,string apellido)
            MessageBox.Show(usuario.GetType().Name);

        }
    }
}
