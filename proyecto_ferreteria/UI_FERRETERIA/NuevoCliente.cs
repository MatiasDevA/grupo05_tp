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
    public partial class NuevoCliente : Form
    {
        private Form menuAnterior;
        public NuevoCliente(Form menu)
        {
            InitializeComponent();
            menuAnterior = menu;
        }

        private void LimpiarCampos()
        {
            txtRazonSocial.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtRazonSocial.Focus();

        }


        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            ClienteNegocio ObjGestorCliente = new ClienteNegocio();// instancio una clase de la capa negocio
            ClienteBE Nuevocliente = new ClienteBE(); // y le envio la caja con los datos
            Nuevocliente.RazonSocial = txtRazonSocial.Text;
            Nuevocliente.Telefono = txtTelefono.Text;
            Nuevocliente.Cuil = txtCuil.Text;
            Nuevocliente.Contacto = txtDNI.Text;
            Nuevocliente.DNI = txtDNI.Text;


            if (ObjGestorCliente.CrearCliente(Nuevocliente))
            {
                MessageBox.Show("Se ha creado un Nuevo Cliente exitosamente");
                LimpiarCampos();
                
            }

            else
            {
                MessageBox.Show("No se ha podido crear Nuevo CLiente corectamente");
                LimpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        
            menuAnterior.Show();
            this.Close();
        
    }
    }
}
