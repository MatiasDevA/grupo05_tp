using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class OrdenCompraBE
    {
        private int _idOrdenCompra;
        private int _idProveedor;
        private int _idUsuario;
        private DateTime _fecha;
        private string _estado;
        private decimal _total;

        public int IdOrdenCompra
        {
            get { return _idOrdenCompra; }
            set { _idOrdenCompra = value; }
        }

        public int IdProveedor
        {
            get { return _idProveedor; }
            set { _idProveedor = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
