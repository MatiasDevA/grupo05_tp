using System;
using System.Collections.Generic;
using System.Data;
using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace BLL_FERRETERIA
{
    public class ProductoService
    {
        private readonly ProductoDAL _dal = new ProductoDAL();

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

        public List<ListadoProductoBE> ObtenerListadoProductos(string categoria = null, bool soloAlertas = false)
        {
            DataTable dt = _dal.ObtenerListadoProductos(categoria, soloAlertas);
            var lista = new List<ListadoProductoBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new ListadoProductoBE
                {
                    IdProducto = SafeInt(row, "id_producto"),
                    Codigo = SafeString(row, "codigo"),
                    Descripcion = SafeString(row, "descripcion"),
                    Categoria = SafeString(row, "categoria"),
                    StockActual = SafeInt(row, "stock_actual"),
                    StockMinimo = SafeInt(row, "stock_minimo"),
                    NivelAlerta = SafeString(row, "nivel_alerta")
                });
            }

            return lista;
        }

        public List<AlertaStockBE> GenerarAlertaStock()
        {
            DataTable dt = _dal.GenerarAlertaStock();
            var lista = new List<AlertaStockBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new AlertaStockBE
                {
                    IdProducto = SafeInt(row, "id_producto"),
                    Codigo = SafeString(row, "codigo"),
                    Descripcion = SafeString(row, "descripcion"),
                    Categoria = SafeString(row, "categoria"),
                    StockActual = SafeInt(row, "stock_actual"),
                    StockMinimo = SafeInt(row, "stock_minimo"),
                    Nivel = SafeString(row, "nivel_alerta")
                });
            }

            return lista;
        }

        public int RegistrarEgresoStock(int idProducto, int cantidad)
        {
            if (idProducto <= 0)
                throw new ArgumentException("El ID de producto no es válido.");

            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a 0.");

            return _dal.RegistrarEgresoStock(idProducto, cantidad);
        }

        public List<CategoriaBE> ObtenerCategorias()
        {
            DataTable dt = _dal.ObtenerCategorias();
            var lista = new List<CategoriaBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new CategoriaBE
                {
                    Nombre = SafeString(row, "categoria")
                });
            }

            return lista;
        }

        public List<ProductoBE> ObtenerProductos()
        {
            DataTable dt = _dal.ObtenerProductos();
            var lista = new List<ProductoBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new ProductoBE
                {
                    IdProducto = SafeInt(row, "id_producto"),
                    Descripcion = SafeString(row, "descripcion")
                });
            }

            return lista;
        }
    }
}
