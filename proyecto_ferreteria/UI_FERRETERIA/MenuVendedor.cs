using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_FERRETERIA
{
    public partial class MenuVendedor : Form
    {
        private Form menuAnterior;
        public MenuVendedor(Form menu)
        {
            InitializeComponent();
            menuAnterior = menu;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var form = new GestionClientes(this); 
            form.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuAnterior.Show();
            this.Close();
        }
        private void MenuVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
