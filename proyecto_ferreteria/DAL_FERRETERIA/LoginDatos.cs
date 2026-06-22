using System.Data;
using System.Data.SqlClient;

namespace DAL_FERRETERIA
{
    public class LoginDatos
    {
        private readonly Conexion _conexion = new Conexion();

        public DataTable Login(string usuario, string clave)
        {
            return _conexion.LeerPorStoreProcedure("SP_Admin_Login", new SqlParameter[]
            {
                _conexion.crearParametro("@usuario", usuario),
                _conexion.crearParametro("@clave", clave)
            });
        }
    }
}
