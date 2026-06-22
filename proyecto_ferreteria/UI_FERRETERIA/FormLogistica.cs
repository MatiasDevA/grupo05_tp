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
    public partial class FormLogistica : Form
    {
        public FormLogistica()
        {
            InitializeComponent();
            this.Text = "Pantalla Cliente";
            Label lbl = new Label();
            lbl.Text = "Soy Cliente";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(lbl);
        }
    }
}
