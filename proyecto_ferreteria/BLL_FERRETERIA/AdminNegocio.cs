using System.Data;
using DAL_FERRETERIA;

namespace BLL_FERRETERIA
{
    public class AdminNegocio
    {
        private readonly AdminDatos _datos = new AdminDatos();

        public DataTable AltaUsuario(string nombre, string apellido, string email, string usuario, string clave, string nroTelefono, int idPerfil)
        {
            return _datos.AltaUsuario(nombre, apellido, email, usuario, clave, nroTelefono, idPerfil);
        }

        public DataTable ModificarUsuario(int idUsuario, string nombre, string apellido, string email, string nroTelefono)
        {
            return _datos.ModificarUsuario(idUsuario, nombre, apellido, email, nroTelefono);
        }

        public DataTable CambiarEstadoUsuario(int idUsuario, string estado)
        {
            return _datos.CambiarEstadoUsuario(idUsuario, estado);
        }

        public DataTable CambiarPerfilUsuario(int idUsuario, int idPerfil)
        {
            return _datos.CambiarPerfilUsuario(idUsuario, idPerfil);
        }

        public DataTable ListarUsuarios(int? idPerfil = null, string estado = null)
        {
            return _datos.ListarUsuarios(idPerfil, estado);
        }

        public DataTable ObtenerPerfiles()
        {
            return _datos.ObtenerPerfiles();
        }

        public DataTable ObtenerUsuarioPorId(int idUsuario)
        {
            return _datos.ObtenerUsuarioPorId(idUsuario);
        }
    }
}
