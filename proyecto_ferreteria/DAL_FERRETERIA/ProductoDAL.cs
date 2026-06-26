using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_FERRETERIA
{
    public class ProductoDAL
    {
        private readonly Conexion _conexion = new Conexion();

        public DataTable ObtenerListadoProductos(string categoria = null, bool soloAlertas = false)
        {
            var parametros = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(categoria))
                parametros.Add(_conexion.crearParametro("@categoria", categoria));

            if (soloAlertas)
                parametros.Add(_conexion.crearParametro("@solo_alertas", 1));

            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerListadoProductos",
                parametros.Count > 0 ? parametros.ToArray() : null);
        }

        public DataTable GenerarAlertaStock()
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_GenerarAlertaStock");
        }

        public int RegistrarEgresoStock(int idProducto, int cantidad)
        {
            return _conexion.EscribirPorStoreProcedure("SP_Encargado_RegistrarEgresoStock", new SqlParameter[]
            {
                _conexion.crearParametro("@id_producto", idProducto),
                _conexion.crearParametro("@cantidad", cantidad)
            });
        }

        public DataTable ObtenerCategorias()
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerCategorias");
        }

        public DataTable ObtenerProductos()
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerProductos");
        }
    }
}
