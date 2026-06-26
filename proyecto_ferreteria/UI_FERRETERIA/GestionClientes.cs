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
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
            this.Text = "Pantalla Vendedor";
            Label lbl = new Label();
            lbl.Text = "Soy Vendedor";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(lbl);
        }

        private void LimpiarCampos()
        {
            txtRazonSocial.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDirreccion.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtRazonSocial.Focus();
        }

        private void FormVendedor_Resize(object sender, EventArgs e)
        {
            panelCentral.Left =
                (panelCentralVacio.Width - panelCentralVacio.Width) / 2;

            panelCentral.Top =
                (panelCentralVacio.Height - panelCentralVacio.Height) / 2;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panelCentralVacio.Visible = false;
            panelCliente.Visible = true;
            panelCliente.BringToFront();
        }
    }
}
