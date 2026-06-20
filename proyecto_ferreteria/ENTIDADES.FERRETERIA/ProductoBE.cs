using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES.FERRETERIA
{
    public class ProductoBE
    {
        private int _idProducto;
        private string _codigo;
        private string _descripcion;
        private string _categoria;
        private decimal _precioCompra;
        private decimal _precioVenta;
        private int _stockActual;
        private int _stockMinimo;
        private string _estado;

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public decimal PrecioCompra
        {
            get { return _precioCompra; }
            set { _precioCompra = value; }
        }

        public decimal PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }

        public int StockActual
        {
            get { return _stockActual; }
            set { _stockActual = value; }
        }

        public int StockMinimo
        {
            get { return _stockMinimo; }
            set { _stockMinimo = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
