using System;
using System.Data;
using DAL_FERRETERIA;

namespace BLL_FERRETERIA
{
    public class EncargadoDepositoNegocio
    {
        private readonly EncargadoDepositoDatos _datos = new EncargadoDepositoDatos();

        public DataTable RegistrarOrdenCompra(int idUsuario, int idProveedor)
        {
            return _datos.RegistrarOrdenCompra(idUsuario, idProveedor);
        }

        public DataTable AgregarDetalleOrden(int idOrden, int idProducto, int cantidad, decimal precioUnitario)
        {
            return _datos.AgregarDetalleOrden(idOrden, idProducto, cantidad, precioUnitario);
        }

        public int ConfirmarOrden(int idOrden)
        {
            return _datos.ConfirmarOrden(idOrden);
        }

        public int CancelarOrden(int idOrden)
        {
            return _datos.CancelarOrden(idOrden);
        }

        public DataTable ObtenerCategorias()
        {
            return _datos.ObtenerCategorias();
        }

        public DataTable ObtenerProveedores()
        {
            return _datos.ObtenerProveedores();
        }

        public DataTable ObtenerProductos()
        {
            return _datos.ObtenerProductos();
        }

        public DataTable ObtenerItemsOrden(int idOrden)
        {
            return _datos.ObtenerItemsOrden(idOrden);
        }

        public int RegistrarEgresoStock(int idProducto, int cantidad)
        {
            return _datos.RegistrarEgresoStock(idProducto, cantidad);
        }

        public DataTable ObtenerEstadosOrden()
        {
            return _datos.ObtenerEstadosOrden();
        }

        public DataTable ObtenerListadoProductos(string categoria = null, bool soloAlertas = false)
        {
            return _datos.ObtenerListadoProductos(categoria, soloAlertas);
        }

        public DataTable GenerarAlertaStock()
        {
            return _datos.GenerarAlertaStock();
        }

        public DataTable ObtenerHistorialOrdenes(string estado = null, int? idProveedor = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            return _datos.ObtenerHistorialOrdenes(estado, idProveedor, fechaDesde, fechaHasta);
        }
    }
}