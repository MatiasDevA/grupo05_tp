using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class DetalleCompraBE
    {
        private int _idDetalle;
        private int _idOrdenCompra;
        private int _idProducto;
        private string _descripcionProducto;
        private int _cantidad;
        private decimal _precioUnitario;
        private decimal _subtotal;

        public int IdDetalle
        {
            get { return _idDetalle; }
            set { _idDetalle = value; }
        }

        public int IdOrdenCompra
        {
            get { return _idOrdenCompra; }
            set { _idOrdenCompra = value; }
        }

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string DescripcionProducto
        {
            get { return _descripcionProducto; }
            set { _descripcionProducto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        public decimal Subtotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }
    }
}
