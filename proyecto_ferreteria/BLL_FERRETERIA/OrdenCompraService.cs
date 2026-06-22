using System;
using System.Collections.Generic;
using System.Data;
using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace BLL_FERRETERIA
{
    public class OrdenCompraService
    {
        private readonly OrdenCompraDAL _dal = new OrdenCompraDAL();

        private static string SafeString(DataRow row, string columnName)
        {
            if (!row.Table.Columns.Contains(columnName))
                return null;
            return row[columnName] == DBNull.Value ? null : row[columnName].ToString();
        }

        private static int SafeInt(DataRow row, string columnName, int defaultValue = 0)
        {
            if (!row.Table.Columns.Contains(columnName))
                return defaultValue;
            if (row[columnName] == DBNull.Value)
                return defaultValue;
            return Convert.ToInt32(row[columnName]);
        }

        private static decimal SafeDecimal(DataRow row, string columnName, decimal defaultValue = 0)
        {
            if (!row.Table.Columns.Contains(columnName))
                return defaultValue;
            if (row[columnName] == DBNull.Value)
                return defaultValue;
            return Convert.ToDecimal(row[columnName]);
        }

        public OrdenCompraBE RegistrarOrdenCompra(int idUsuario, int idProveedor, DateTime fecha)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("El ID de usuario no es válido.");

            if (idProveedor <= 0)
                throw new ArgumentException("El ID de proveedor no es válido.");

            DataTable dt = _dal.RegistrarOrdenCompra(idUsuario, idProveedor, fecha);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new OrdenCompraBE
                {
                    IdOrdenCompra = SafeInt(row, "id_orden"),
                    IdProveedor = idProveedor,
                    IdUsuario = idUsuario,
                    Fecha = fecha,
                    Estado = SafeString(row, "estado")
                };
            }

            return null;
        }

        public List<ItemOrdenBE> AgregarDetalleOrden(int idOrden, int idProducto, int cantidad, decimal precioUnitario)
        {
            if (idOrden <= 0)
                throw new ArgumentException("El ID de orden no es válido.");

            if (idProducto <= 0)
                throw new ArgumentException("El ID de producto no es válido.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0.");

            if (precioUnitario < 0)
                throw new ArgumentException("El precio unitario no puede ser negativo.");

            DataTable dt = _dal.AgregarDetalleOrden(idOrden, idProducto, cantidad, precioUnitario);
            return ConvertirAItemsOrden(dt);
        }

        public int ConfirmarOrden(int idOrden)
        {
            if (idOrden <= 0)
                throw new ArgumentException("El ID de orden no es válido.");

            return _dal.ConfirmarOrden(idOrden);
        }

        public int CancelarOrden(int idOrden)
        {
            if (idOrden <= 0)
                throw new ArgumentException("El ID de orden no es válido.");

            return _dal.CancelarOrden(idOrden);
        }

        public List<HistorialOrdenBE> ObtenerHistorialOrdenes(string estado = null, int? idProveedor = null, DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            DataTable dt = _dal.ObtenerHistorialOrdenes(estado, idProveedor, fechaDesde, fechaHasta);
            var lista = new List<HistorialOrdenBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new HistorialOrdenBE
                {
                    IdOrden = SafeInt(row, "id_orden"),
                    Proveedor = SafeString(row, "proveedor"),
                    Fecha = row.Table.Columns.Contains("fecha") && row["fecha"] != DBNull.Value
                        ? Convert.ToDateTime(row["fecha"])
                        : DateTime.MinValue,
                    Estado = SafeString(row, "estado"),
                    Total = SafeDecimal(row, "total")
                });
            }

            return lista;
        }

        public OrdenCompraBE ObtenerDetalleOrden(int idOrden)
        {
            if (idOrden <= 0)
                throw new ArgumentException("El ID de orden no es válido.");

            DataTable dt = _dal.ObtenerDetalleOrden(idOrden);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new OrdenCompraBE
                {
                    IdOrdenCompra = SafeInt(row, "id_orden"),
                    IdProveedor = SafeInt(row, "id_proveedor"),
                    Fecha = row.Table.Columns.Contains("fecha") && row["fecha"] != DBNull.Value
                        ? Convert.ToDateTime(row["fecha"])
                        : DateTime.MinValue,
                    Estado = SafeString(row, "estado"),
                    Total = SafeDecimal(row, "total")
                };
            }

            return null;
        }

        public List<ItemOrdenBE> ObtenerItemsOrden(int idOrden)
        {
            if (idOrden <= 0)
                throw new ArgumentException("El ID de orden no es válido.");

            DataTable dt = _dal.ObtenerItemsOrden(idOrden);
            return ConvertirAItemsOrden(dt);
        }

        public List<EstadoOrdenBE> ObtenerEstadosOrden()
        {
            DataTable dt = _dal.ObtenerEstadosOrden();
            var lista = new List<EstadoOrdenBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new EstadoOrdenBE
                {
                    Estado = SafeString(row, "estado")
                });
            }

            return lista;
        }

        private List<ItemOrdenBE> ConvertirAItemsOrden(DataTable dt)
        {
            var lista = new List<ItemOrdenBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new ItemOrdenBE
                {
                    IdOrden = SafeInt(row, "id_orden"),
                    IdProducto = SafeInt(row, "id_producto"),
                    DescripcionProducto = SafeString(row, "descripcion_producto"),
                    Cantidad = SafeInt(row, "cantidad"),
                    PrecioUnitario = SafeDecimal(row, "precio_unitario"),
                    Subtotal = SafeDecimal(row, "subtotal")
                });
            }

            return lista;
        }
    }
}
