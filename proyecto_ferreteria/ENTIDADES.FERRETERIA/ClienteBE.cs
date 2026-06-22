using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class ClienteBE
    {
        private int _idcliente;
        private string  _telefono;
        private string _razonsocial;
        private string _cuil;
        private string _contacto;
        private string _dni;

       

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }



        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string RazonSocial
        {
            get { return _razonsocial; }
            set { _razonsocial = value; }
        }

        public string Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public int IDCliente
        {
            get { return _idcliente; }
            set { _idcliente = value; }
        }
        public string Cuil
        {
            get { return _cuil; }
            set { _cuil = value; }
        }



    }
}
