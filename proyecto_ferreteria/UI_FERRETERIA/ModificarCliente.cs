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
    public partial class ModificarCliente : Form
    {
        private Form menuAnterior;
        private ClienteBE clienteActual;
        public ModificarCliente(Form menu, ClienteBE cliente)
        {
            InitializeComponent();
            menuAnterior = menu;

            clienteActual = cliente;

            txtRazonSocial.Text = cliente.RazonSocial;
            txtTelefono.Text = cliente.Telefono;
            txtCuil.Text = cliente.Cuil;
            txtContacto.Text = cliente.Contacto;
            txtDNI.Text = cliente.DNI;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            menuAnterior.Show();
            this.Close();

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            ClienteNegocio ObjGestorCliente = new ClienteNegocio();

            clienteActual.RazonSocial = txtRazonSocial.Text;
            clienteActual.Telefono = txtTelefono.Text;
            clienteActual.Cuil = txtCuil.Text;
            clienteActual.Contacto = txtContacto.Text;
            clienteActual.DNI = txtDNI.Text;
            MessageBox.Show(clienteActual.IDCliente.ToString());
            if (ObjGestorCliente.ModificarCliente(clienteActual))
            {
                MessageBox.Show("Cambios guardados correctamente");
                menuAnterior.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al modificar cliente");
            }
        }
    }
}
