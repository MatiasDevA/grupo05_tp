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
    public partial class Form1 : Form
    {
        public Form1()
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
            using (var form = new FormVendedor())
            {
                form.ShowDialog(this);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            using (var form = new FormCliente())
            {
                form.ShowDialog(this);
            }
        }
}
}
