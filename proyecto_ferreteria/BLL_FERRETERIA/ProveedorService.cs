using System;
using System.Collections.Generic;
using System.Data;
using DAL_FERRETERIA;
using ENTIDADES.FERRETERIA;

namespace BLL_FERRETERIA
{
    public class ProveedorService
    {
        private readonly ProveedorDAL _dal = new ProveedorDAL();

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

        public List<ProveedorBE> ObtenerProveedores()
        {
            DataTable dt = _dal.ObtenerProveedores();
            var lista = new List<ProveedorBE>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new ProveedorBE
                {
                    IdProveedor = SafeInt(row, "id_proveedor"),
                    RazonSocial = SafeString(row, "razon_social")
                });
            }

            return lista;
        }
    }
}
