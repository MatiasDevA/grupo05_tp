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
    public partial class FormGerente : Form
    {
        public FormGerente()
        {
            InitializeComponent();
            this.Text = "Pantalla Gerente";
            Label lbl = new Label();
            lbl.Text = "Soy Gerente";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(lbl);
        }
    }
}
