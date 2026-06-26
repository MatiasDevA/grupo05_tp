using System.Data;

namespace DAL_FERRETERIA
{
    public class ProveedorDAL
    {
        private readonly Conexion _conexion = new Conexion();

        public DataTable ObtenerProveedores()
        {
            return _conexion.LeerPorStoreProcedure("SP_Encargado_ObtenerProveedores");
        }
    }
}
