using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_FERRETERIA
{
    public class ClienteNegocio
    {


		private int _idcliente;

		public int IdCliente
        {
			get { return _idcliente; }
			set { _idcliente = value; }
		}


		private string _telefono;

		public string Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}


		private string _razonsocial;

		public string RazonSocial
		{
			get { return _razonsocial; }
			set { _razonsocial = value; }
		}

		private string _cuil;

		public string CUIL
		{
			get { return _cuil; }
			set { _cuil = value; }
		}


		private string _direccion;

		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}

		
		

        //Hack revisar esto 1
        /*public void CargarCliente()
		{
			DAL_FERRETERIA.ClienteDatos ClienteDatos = new DAL_FERRETERIA.ClienteDatos();

			ClienteDatos.

		}*/
	}
}
