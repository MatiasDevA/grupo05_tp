using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_FERRETERIA
{
    public class OrdenCompraDAL
    {
        private readonly Conexion _conexion = new Conexion();

        public DataTable RegistrarOrdenCompra(int idUsuario, int idProveedor, DateTime fecha)
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_RegistrarOrdenCompra", new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario),
                _conexion.crearParametro("@id_proveedor", idProveedor),
                _conexion.crearParametro("@fecha", fecha)
            });
        }

        public DataTable AgregarDetalleOrden(int idOrden, int idProducto, int cantidad, decimal precioUnitario)
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_AgregarDetalleOrden", new SqlParameter[]
            {
                _conexion.crearParametro("@id_orden", idOrden),
                _conexion.crearParametro("@id_producto", idProducto),
                _conexion.crearParametro("@cantidad", cantidad),
                _conexion.crearParametro("@precio_unitario", precioUnitario)
            });
        }

        public int ConfirmarOrden(int idOrden)
        {
            return _conexion.EscribirPorStoreProcedure("SP_Encargado_ConfirmarOrden", new SqlParameter[]
            {
                _conexion.crearParametro("@id_orden", idOrden)
            });
        }

        public int CancelarOrden(int idOrden)
        {
            return _conexion.EscribirPorStoreProcedure("SP_Encargado_CancelarOrden", new SqlParameter[]
            {
                _conexion.crearParametro("@id_orden", idOrden)
            });
        }

        public DataTable ObtenerHistorialOrdenes(string estado = null, int? idProveedor = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            var parametros = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(estado))
                parametros.Add(_conexion.crearParametro("@estado", estado));

            if (idProveedor.HasValue)
                parametros.Add(_conexion.crearParametro("@id_proveedor", idProveedor.Value));

            if (fechaDesde.HasValue)
                parametros.Add(_conexion.crearParametro("@fecha_desde", fechaDesde.Value));

            if (fechaHasta.HasValue)
                parametros.Add(_conexion.crearParametro("@fecha_hasta", fechaHasta.Value));

            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerHistorialOrdenes",
                parametros.Count > 0 ? parametros.ToArray() : null);
        }

        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerDetalleOrden", new SqlParameter[]
            {
                _conexion.crearParametro("@id_orden", idOrden)
            });
        }

        public DataTable ObtenerItemsOrden(int idOrden)
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerItemsOrden", new SqlParameter[]
            {
                _conexion.crearParametro("@id_orden", idOrden)
            });
        }

        public DataTable ObtenerEstadosOrden()
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerEstadosOrden");
        }
    }
}
