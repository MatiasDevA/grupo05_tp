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
    public partial class GestionClientes : Form
    { 
        private Form menuAnterior;
        public GestionClientes(Form menu)
        {
            InitializeComponent();
            menuAnterior = menu;
            btnModificar.Enabled = false;

            this.Load += GestionClientes_Load;
            
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
        }

        
          private void ListarClientes()
        {
            ClienteNegocio obj = new ClienteNegocio();

            List<ClienteBE> lista = obj.ListarClientes();

            dgvClientes.DataSource = lista;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvClientes.ClearSelection();
            btnModificar.Enabled = false;
        }
        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuAnterior.Show();
            this.Close();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var form = new NuevoCliente(this);
            form.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ListarClientes();
            btnModificar.Enabled = false;
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {

            ClienteNegocio ObjGestorCliente = new ClienteNegocio();// instancio una clase de la capa negocio
            string criterio = cmbCriterioClientes.Text;
            string valor = txbBuscarClientes.Text;
            dgvClientes.DataSource = ObjGestorCliente.BuscarClientes(criterio,valor);
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled =
                dgvClientes.CurrentRow != null &&
                dgvClientes.CurrentRow.Index >= 0;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
           dgvClientes.CurrentRow.Cells["IdCliente"].Value);
            ClienteNegocio ObjGestorCliente = new ClienteNegocio();// instancio una clase de la capa negocio
            ClienteBE cliente = ObjGestorCliente.BuscarClientes(id);

            var form = new ModificarCliente(this, cliente);
            form.Show();
            this.Hide();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}


