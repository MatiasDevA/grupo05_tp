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
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
            this.Text = "Pantalla Vendedor";
            Label lbl = new Label();
            lbl.Text = "Soy Vendedor";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(lbl);
        }
    }
}
