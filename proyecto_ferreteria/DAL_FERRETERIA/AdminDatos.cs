using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL_FERRETERIA
{
    public class AdminDatos
    {
        private readonly Conexion _conexion = new Conexion();

        public DataTable AltaUsuario(string nombre, string apellido, string email, string usuario, string clave, string nroTelefono, int idPerfil)
        {
            var parametros = new List<SqlParameter>
            {
                _conexion.crearParametro("@nombre", nombre),
                _conexion.crearParametro("@apellido", apellido),
                _conexion.crearParametro("@email", email),
                _conexion.crearParametro("@usuario", usuario),
                _conexion.crearParametro("@clave", clave),
                _conexion.crearParametro("@id_perfil", idPerfil)
            };

            if (!string.IsNullOrWhiteSpace(nroTelefono))
                parametros.Add(_conexion.crearParametro("@nro_telefono", nroTelefono));

            return _conexion.LeerPorStoreProcedure("SP_Admin_AltaUsuario", parametros.ToArray());
        }

        public DataTable ModificarUsuario(int idUsuario, string nombre, string apellido, string email, string nroTelefono)
        {
            var parametros = new List<SqlParameter>
            {
                _conexion.crearParametro("@id_usuario", idUsuario),
                _conexion.crearParametro("@nombre", nombre),
                _conexion.crearParametro("@apellido", apellido),
                _conexion.crearParametro("@email", email)
            };

            if (!string.IsNullOrWhiteSpace(nroTelefono))
                parametros.Add(_conexion.crearParametro("@nro_telefono", nroTelefono));

            return _conexion.LeerPorStoreProcedure("SP_Admin_ModificarUsuario", parametros.ToArray());
        }

        public DataTable CambiarEstadoUsuario(int idUsuario, string estado)
        {
            return _conexion.LeerPorStoreProcedure("SP_Admin_CambiarEstadoUsuario", new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario),
                _conexion.crearParametro("@estado", estado)
            });
        }

        public DataTable CambiarPerfilUsuario(int idUsuario, int idPerfil)
        {
            return _conexion.LeerPorStoreProcedure("SP_Admin_CambiarPerfilUsuario", new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario),
                _conexion.crearParametro("@id_perfil", idPerfil)
            });
        }

        public DataTable ListarUsuarios(int? idPerfil = null, string estado = null)
        {
            var parametros = new List<SqlParameter>();

            if (idPerfil.HasValue)
                parametros.Add(_conexion.crearParametro("@id_perfil", idPerfil.Value));

            if (!string.IsNullOrWhiteSpace(estado))
                parametros.Add(_conexion.crearParametro("@estado", estado));

            return _conexion.LeerPorStoreProcedure("SP_Admin_ListarUsuarios",
                parametros.Count > 0 ? parametros.ToArray() : null);
        }

        public DataTable ObtenerPerfiles()
        {
            return _conexion.LeerPorStoreProcedure("SP_Admin_ObtenerPerfiles");
        }

        public DataTable ObtenerUsuarioPorId(int idUsuario)
        {
            return _conexion.LeerPorStoreProcedure("SP_Admin_ObtenerUsuarioPorId", new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario)
            });
        }
    }
}
