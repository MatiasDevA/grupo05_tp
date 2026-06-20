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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            using (var form = new FormAdmin())
            {
                form.ShowDialog(this);
            }
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            using (var form = new FormGerente())
            {
                form.ShowDialog(this);
            }
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var form = new GestionClientes())
            {
                form.ShowDialog(this);

            }
            this.Close();
        }

        private void btnEncargado_Click(object sender, EventArgs e)
        {
            using (var form = new FormEncargadoDeposito())
            {
                form.ShowDialog(this);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            GestionClientes form = new GestionClientes();

            form.FormClosed += (s, args) => this.Close();

            this.Hide();

            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
